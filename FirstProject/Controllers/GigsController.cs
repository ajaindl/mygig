using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor;
using FirstProject.Models;
using FirstProject.ViewModels;

namespace FirstProject.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context=new ApplicationDbContext();
        }
        // GET: Gigs
        public ActionResult Create()
        {
            var viewModel=new GigFormViewModel { 
                Genres= _context.Genres.ToList()
                };
            return View(viewModel);
        }
    }
}