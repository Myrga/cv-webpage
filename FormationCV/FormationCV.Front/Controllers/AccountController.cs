using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormationCV.Front.Models;
using FormationCV.Data;
using FormationCV.Front.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FormationCV.Front.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View("Index_bootstrap");
        }
    }
}
