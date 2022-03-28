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
    public class HomeController : Controller
    {
        private int PageSize = 8;
        private readonly IVideoRepository _context;

        public HomeController(IVideoRepository context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string search, int page = 1)
        {
            return View(new VideosIndexViewModels
            {
                Videos = await _context.VideosWithUser
                .Where(el => search == null || el.Name.Contains(search.Trim()) || el.Description.Contains(search.Trim()))
                .OrderBy(el => el.VideoId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync(),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = await _context.VideosWithUser.CountAsync()
                },
                SearchQuery = search
            });
        }
    }
}
