﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookKeeper.Controllers
{
    public class EditController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}