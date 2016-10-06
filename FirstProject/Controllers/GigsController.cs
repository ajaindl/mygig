using System;
using System.Linq;
using System.Web.Mvc;
using FirstProject.Models;
using FirstProject.ViewModels;
using Microsoft.AspNet.Identity;

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
        [Authorize]
        public ActionResult Create()
        {
            var viewModel=new GigFormViewModel { 
                Genres= _context.Genres.ToList()
                };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {



            var artistId = User.Identity.GetUserId();
            var gig = new Gig
            {
                ArtistId = artistId,
                DateTime = viewModel.DateTime,
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();
            
            return RedirectToAction("Index", "Home");
        }

     
    }
}