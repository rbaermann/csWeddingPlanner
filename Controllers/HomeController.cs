using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using weddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace weddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private WeddingPlannerContext dbContext;

        public HomeController(WeddingPlannerContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("register")]
        public IActionResult Register(LoginAndReg createUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == createUser.NewUser.Email))
                {
                    ModelState.AddModelError("NewUser.Email", "Email is already in use");
                    return View("Index");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                createUser.NewUser.Password = Hasher.HashPassword(createUser.NewUser, createUser.NewUser.Password);

                dbContext.Add(createUser.NewUser);
                dbContext.SaveChanges();

                HttpContext.Session.SetInt32("InSession", createUser.NewUser.UserId);

                return RedirectToAction("Dashboard");
            }

            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult CheckingUser(LoginAndReg userSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.CheckUser.Email);

                if(userInDb == null)
                {
                    ModelState.AddModelError("CheckUser.Email", "Email does not excist");
                    return View("Index");
                }
                
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(userSubmission.CheckUser, userInDb.Password, userSubmission.CheckUser.Password);

                if(result == 0)
                {
                    ModelState.AddModelError("CheckUser.Password", "Wrong password");
                    return View("Index");
                }

                HttpContext.Session.SetInt32("InSession", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }

            return View("Index");
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetInt32("InSession") == null)
            {
                return RedirectToAction("Index");
            }
            UserAndListOfWeddings viewModel = new UserAndListOfWeddings();

            viewModel.ListOfWeddings = dbContext.Weddings
            .Include(w => w.WeddingsUsers)
            .ThenInclude(u => u.User)
            .ToList();

            viewModel.UsersWedding = dbContext.Users
            .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("InSession"));

            return View("Dashboard", viewModel);
        }

        [HttpGet("new")]
        public IActionResult NewWedding()
        {
            if(HttpContext.Session.GetInt32("InSession") == null)
            {
                return RedirectToAction("Index");
            }
            return View("NewWedding");
        }

        [HttpPost("create")]
        public IActionResult Create(NewWedding submittedWedding)
        {
            if(ModelState.IsValid)
            {
                Wedding viewModel = submittedWedding.NewlyWeds;
                viewModel.Host = dbContext.Users
                .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("InSession"));
                dbContext.Add(viewModel);
                dbContext.SaveChanges();
                return RedirectToAction("Info", new{WeddingId = viewModel.WeddingId});
            }
            return View("NewWedding");
        }

        [HttpGet("wedding/{WeddingId}")]
        public IActionResult Info(int WeddingId)
        {
            if(HttpContext.Session.GetInt32("InSession") == null)
            {
                return RedirectToAction("Index");
            }
            Wedding thisWedding = dbContext.Weddings
            .Include(w => w.WeddingsUsers)
            .ThenInclude(u => u.User)
            .FirstOrDefault(p => p.WeddingId == WeddingId);

            return View("Info", thisWedding);
        }

        [HttpGet("RSVP/{WeddingId}/{UserId}")]
        public RedirectToActionResult RSVP(int WeddingId, int UserId)
        {
            UserWedding rsvpWedding = new UserWedding();

            rsvpWedding.UserId = UserId;
            rsvpWedding.WeddingId = WeddingId;

            dbContext.UserWeddings.Add(rsvpWedding);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("remove/{WeddingId}/{UserId}")]
        public RedirectToActionResult RemoveRSVP(int WeddingId, int UserId)
        {
            UserWedding unRSVPWedding = dbContext.UserWeddings
            .FirstOrDefault(uw => uw.WeddingId == WeddingId && uw.UserId == UserId);

            dbContext.UserWeddings.Remove(unRSVPWedding);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("delete/{WeddingId}")]
        public RedirectToActionResult Delete(int WeddingId)
        {
            Wedding thisWedding = dbContext.Weddings
            .Include(w => w.Host)
            .FirstOrDefault(w => w.WeddingId == WeddingId);

            if(HttpContext.Session.GetInt32("InSession") != thisWedding.Host.UserId)
            {
                return RedirectToAction("Index");
            }
            Wedding delWedding = dbContext.Weddings
            .FirstOrDefault(d => d.WeddingId == WeddingId);

            dbContext.Weddings.Remove(delWedding);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
