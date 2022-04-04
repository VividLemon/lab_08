﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab_06.Data;
using Lab_06.Models;
using Lab_06.Models.ViewModels;

namespace Lab_06.Controllers
{
    public class VideosController : Controller
    {
        private readonly IVideoRepository _context;
        public int PageSize = 6;

        public VideosController(IVideoRepository context)
        {
            _context = context;
        }

        // GET: Videos
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(new VideosIndexViewModels
            {
                Videos = await _context.VideosWithUser.OrderBy(el => el.VideoId).Skip((page - 1) * page).Take(PageSize).ToListAsync(),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = await _context.Videos.CountAsync()
                }
            }); 
        }

        public IActionResult Create(Video video)
        {
                return View();
        }
        public async Task<IActionResult> Edit(int videoId)
        {
            var video = await _context.Videos.FirstOrDefaultAsync(el => el.VideoId == videoId);
            return View(video);
        }

        // GET: Videos/Play/{id}
        public async Task<IActionResult> Play(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            return View(await _context.VideosGetAll.FirstOrDefaultAsync(el => el.VideoId == id));
        }

        // GET: Videos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var video = await _context.VideosWithUser
                .FirstOrDefaultAsync(m => m.VideoId == id);
            if (video == null)
            {
                return NotFound();
            }

            return View(video);
        }
        [HttpPost]
        public async Task<RedirectToActionResult> Destroy (int videoId)
        {
            await _context.DeleteVideo(videoId);
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> Update (Video video)
        {
            if (ModelState.IsValid)
            {
            await _context.SaveVideo(video);
            return RedirectToAction("Index", "Admin");

            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Store (Video video)
        {
            if (ModelState.IsValid)
            {
                await _context.CreateVideo(video);
                return RedirectToAction("Index", "Admin");

            }
            else
            {
                return View("Create");
            }
        }
    }
}
