using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(Planner newPlanner)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.planners.Any(p => p.Email == newPlanner.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                    return View("Index");
                }
                PasswordHasher<Planner> Hasher = new PasswordHasher<Planner>();
                newPlanner.Password = Hasher.HashPassword(newPlanner, newPlanner.Password);
                dbContext.planners.Add(newPlanner);
                dbContext.SaveChanges();
                HttpContext.Session.SetString("FirstName", newPlanner.FirstName);
                HttpContext.Session.SetInt32("PlannerId", newPlanner.PlannerId);
                return RedirectToAction("Index");

            }
            else
            {
                return View("Index");
            }
        }
        [HttpPost("login")]
        public IActionResult Login(Login plannerSubmission)
        {
            if (ModelState.IsValid)
            {
                var hasher = new PasswordHasher<Login>();
                var signedInPlanner = dbContext.planners.FirstOrDefault(p => p.Email == plannerSubmission.LoginEmail);
                if (signedInPlanner == null)
                {
                    ViewBag.Message = "Email/Password is invalid";
                    return View("Index");
                }
                else
                {
                    var result = hasher.VerifyHashedPassword(plannerSubmission, signedInPlanner.Password, plannerSubmission.LoginPassword);
                    if (result == 0)
                    {
                        ViewBag.Message = "Email/Password is invalid";
                        return View("Index");
                    }
                }

                HttpContext.Session.SetInt32("PlannerId", signedInPlanner.PlannerId);
                return Redirect("/dashboard");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            Planner plannerInDb = dbContext.planners.FirstOrDefault(p => p.PlannerId == (int)HttpContext.Session.GetInt32("PlannerId"));
            List<Wedding> AllWeddings = dbContext.wedders.Include(w => w.Creater).Include(w => w.MyGuests).ThenInclude(w => w.Guests).ToList();
            if (plannerInDb == null)
            {
                return RedirectToAction("Logout");
            }
            else
            {
                ViewBag.Planner = plannerInDb;
                return View(AllWeddings);
            }
        }
        [HttpGet("create")]
        public IActionResult PlanWedding()
        {
            return View();
        }

        [HttpPost("newWedding")]
        public IActionResult NewWedding(Wedding newWedding)
        {
            if (ModelState.IsValid)
            {
                newWedding.PlannerId = (int)HttpContext.Session.GetInt32("PlannerId");
                dbContext.wedders.Add(newWedding);
                dbContext.SaveChanges();
                return Redirect("dashboard");
            }
            else
            {
                return View("PlanWedding");
            }
        }
        [HttpGet("join/{weddingId}/{plannerId}")]
        public IActionResult RSVP(int weddingId, int plannerId)
        {
            Guest rsvp = new Guest();
            rsvp.PlannerId = plannerId;
            rsvp.WeddingId = weddingId;
            dbContext.attendants.Add(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("cancel/{weddingId}/{plannerId}")]
        public IActionResult UNRSVP(int weddingId, int plannerId)
        {
            Guest remove = dbContext.attendants.FirstOrDefault(g => g.PlannerId == plannerId && g.WeddingId == weddingId);
            dbContext.attendants.Remove(remove);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("delete/{weddingId}")]
        public IActionResult Delete(int weddingId)
        {
            Wedding delete = dbContext.wedders.FirstOrDefault(w => w.WeddingId == weddingId);

            dbContext.wedders.Remove(delete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("detail/{weddingId}")]
        public IActionResult Detail(int weddingId)
        {
            Planner plannerInDb = dbContext.planners.FirstOrDefault(p => p.PlannerId == (int)HttpContext.Session.GetInt32("PlannerId"));
            List<Wedding> detail = dbContext.wedders.Include(w => w.Creater).Include(w => w.MyGuests).ThenInclude(w => w.Guests).ToList();
            if (plannerInDb == null)
            {
                return RedirectToAction("Logout");
            }
            else
            {
                ViewBag.Planner = plannerInDb;
                return View(detail);
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }
    }
}
