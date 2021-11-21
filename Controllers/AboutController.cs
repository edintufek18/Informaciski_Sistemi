using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WowRoads.Data;
using WowRoads.Models;
using Microsoft.AspNetCore.Authorization;

namespace WowRoads.Controllers
{
    public class AboutController : Controller
    {
        private readonly DataContext _context;

        public AboutController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View();

        }


    }

}

