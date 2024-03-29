﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Claymore.Models;


namespace Claymore.Controllers
{
    public class HomeController : Controller
    {
        private YourContext _context;
 
        public HomeController(YourContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.FName = TempData["FirstName"];
            ViewBag.LName = TempData["LastName"];
            ViewBag.Password = TempData["Password"];
            ViewBag.PConfirm = TempData["PasswordConfirmation"];
            ViewBag.Login = TempData["LoginBasic"];
            ViewBag.NoUser = TempData["NoUser"];
            ViewBag.BadInfo = TempData["IncorrectInfo"];
            ViewBag.ExistingUser = TempData["ExistingUser"];

//Display Active Users
        int UsersCount = _context.Users.ToList().Count();
        ViewBag.UsersCount = UsersCount;

            return View();
        }

[HttpPost]
        public IActionResult RegisterUser(User newuser)
        {
            if (ModelState.IsValid)
            {
                List<User> userlist = _context.Users.Where(u => u.Email == newuser.Email).ToList();
                if (userlist.Count() > 0)
                {
                    TempData["ExistingUser"] = "This email already exists";
                    return RedirectToAction("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newuser.Password = Hasher.HashPassword(newuser, newuser.Password);
                User registeringuser = new User
                {
                    FirstName = newuser.FirstName,
                    LastName = newuser.LastName,
                    Email = newuser.Email, 
                    Password = newuser.Password,
                };
                 _context.Add(registeringuser);
                 _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", registeringuser.Id);
                return RedirectToAction("Home");
            }
            else
            {
                foreach (var MSkey in ModelState.Keys)
                {
                    var val = ModelState[MSkey];
                    foreach (var error in val.Errors)
                    {
                        var key = MSkey;
                        var EM = error.ErrorMessage;
                        TempData[key] = EM;
                    }
                }

//Display Active Users
        int UsersCount = _context.Users.ToList().Count();
        ViewBag.UsersCount = UsersCount;



                return RedirectToAction("Index");
            }
        }

[HttpPost]
        public IActionResult LoginUser(string Email, string Password)
        {
            if (Password ==null || Email ==null)
            {
                TempData["LoginBasic"] = "Please Enter Your Email and Password";
                return RedirectToAction("Index");
            }

            List<User> userlist = _context.Users.Where(u => u.Email == Email).Select(u =>u).ToList();
            if (userlist.Count ==0 || Password == null){
                TempData["NoUser"]= "No user with that email exists";
                return RedirectToAction("Index");
            }
            else
            {
                User user = userlist.First();
                var Hasher = new PasswordHasher<User>();
                // Pass the user object, the hashed password, and the PasswordToCheck
    		    var result = Hasher.VerifyHashedPassword(user, user.Password, Password);
                if(result != 0)
                    {
                        HttpContext.Session.SetInt32("UserId", user.Id);
                        return RedirectToAction("Home");
                    }
                else
                {
                    TempData["IncorrectInfo"] = "Info is not correct";
                    return RedirectToAction("Index");
                }
            }
        }
        //////////////////////HOME///////////////////////////

[HttpGet("Home")]
        public async Task<IActionResult> Home(string sortOrder, string searchString, string currentFilter)
        {
            ViewBag.Id = HttpContext.Session.GetInt32("UserId");
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null){
                return RedirectToAction("Index");
    
            }
            List<PostingEvent> AllPostings =_context.Postings.Include(w=>w.Creator).Include(w=>w.Guests).ThenInclude(g => g.User).ToList();
        

            User user = _context.Users.Where(u => u.Id == (HttpContext.Session.GetInt32("UserId"))).FirstOrDefault();
            ViewBag.user= user;

            ////////////////BEGIN NEW SORTING FUNC//////////////

         
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            
            ViewData["CurrentFilter"] = searchString;
            var posting = from s in _context.Postings.Where(u => u.Creator.Id == (HttpContext.Session.GetInt32("UserId")))
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                posting = posting.Where(s => s.Company.Contains(searchString)
                               || s.PositionTitle.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    posting = posting.OrderByDescending(s => s.Company);
                    break;
                case "Date":
                    posting = posting.OrderBy(s => s.DateApply);
                    break;
                case "date_desc":
                    posting = posting.OrderByDescending(s => s.DateApply);
                    break;
                default:
                    posting = posting.OrderBy(s => s.Company);
                    break;
            }
            
                    ////////////////END NEW SORTING FUNC/////////
    
            List<PostingEvent> DateBasedAllPostings= _context.Postings.Where(u => u.Creator.Id == (HttpContext.Session.GetInt32("UserId"))).ToList();
            List<PostingEvent> Regular=_context.Postings.ToList().OrderBy(a => a.DateApply).ToList();
            ViewBag.AA = DateBasedAllPostings;
            
            int JobCount = _context.Postings.Where(u => u.Creator.Id == (HttpContext.Session.GetInt32("UserId"))).ToList().Count();
            ViewBag.JobCount = JobCount;

            //JOBS APPLIED TODAY
            int TodayCount = _context.Postings.Where(u => u.Creator.Id == (HttpContext.Session.GetInt32("UserId"))&& u.CreatedAt >= DateTime.Now.Date).ToList().Count();
            ViewBag.TodayCount = TodayCount;      

            //Phone Screen TODAY
            int ScreenCount = _context.Postings.Where(u => u.Creator.Id == (HttpContext.Session.GetInt32("UserId"))&& u.PhoneScreen >= DateTime.Now.Date).ToList().Count();
            ViewBag.ScreenCount = ScreenCount;  

            //Phone Interview TODAY
            int PhoneCount = _context.Postings.Where(u => u.Creator.Id == (HttpContext.Session.GetInt32("UserId"))&& u.PhoneInterview >= DateTime.Now.Date).ToList().Count();
            ViewBag.PhoneCount = PhoneCount;      


            //Interview TODAY
            int InterviewCount = _context.Postings.Where(u => u.Creator.Id == (HttpContext.Session.GetInt32("UserId"))&& u.Interview >= DateTime.Now.Date).ToList().Count();
            ViewBag.InterviewCount = InterviewCount; 


           //INSERT ALL FOLLOW-UPS FOR FALSE HERE


            
            //end of home, return view
            return View(await posting.AsNoTracking().ToListAsync());
        }


/////////////////////////ADD POSTING/////////////////////////////////

    [HttpGet("AddPosting")]
        public IActionResult AddPosting()
        {
            if(HttpContext.Session.GetInt32("UserId") == null){
                return RedirectToAction("Index");
            }
            ViewBag.CreatorId = HttpContext.Session.GetInt32("UserId");
            return View();
        }

    [HttpGet("posting/{postId}")]
    public IActionResult Posting(int postId){
       if(HttpContext.Session.GetInt32("UserId") == null){
                return RedirectToAction("Index");
            }
            ViewBag.Id = HttpContext.Session.GetInt32("UserId");
            PostingEvent posting= _context.Postings.Where(w => w.PostingId == postId).FirstOrDefault();
            ViewBag.posting = posting;
            List<PostingEvent> guests = _context.Postings.Where(w => w.PostingId == postId).Include( u=> u.Creator).Include(u =>u.Guests).ThenInclude(u=> u.User).ToList();
            ViewBag.Guests = guests;
            return View();
    }


[HttpPost]
        public IActionResult CreatePosting(PostingEvent newposting)
        {
            newposting.CreatorId= (int)HttpContext.Session.GetInt32("UserId");
             _context.Add(newposting);
               // OR dbContext.Goods.Add(newGood);
               _context.SaveChanges();
               return RedirectToAction("Home");
            // if(HttpContext.Session.GetInt32("UserId") == null){
            //     return RedirectToAction("Index");
            // }


            // var nh = DateTime.Now.Hour;
            // var nm = DateTime.Now.Minute;
            // if (newposting.DateApply > DateTime.Today){
            //     User user = _context.Users.Where(u => u.Id == (HttpContext.Session.GetInt32("UserId"))).FirstOrDefault();
            //     if (ModelState.IsValid){
            //         PostingEvent creatingposting = new PostingEvent(){
            //             Creator = user,
            //             CreatorId = user.Id,
            //             Company = newposting.Company,
            //             DateApply = newposting.DateApply,
            //             JobLink = newposting.JobLink,
            //             JobPosting = newposting.JobPosting,
            //             PositionTitle = newposting.PositionTitle,
            //             Notes = newposting.Notes,
            //             RecruiterName = newposting.RecruiterName,
            //             ContactName = newposting.ContactName,
            //             PhoneScreen = newposting.PhoneScreen,
            //             ScreenNotes = newposting.ScreenNotes,
            //             PhoneInterview = newposting.PhoneInterview,
            //             PhoneNotes = newposting.PhoneNotes,
            //             Interview = newposting.Interview,
            //             InterviewNotes = newposting.InterviewNotes,
            //             Denied = newposting.Denied,
            //             DeniedNotes = newposting.DeniedNotes,

            //         };
            //         _context.Postings.Add(creatingposting);
            //         _context.SaveChanges();
            //         return RedirectToAction("Posting", new {postId = creatingposting.PostingId});
            //     }
            //     else{
            //         return View("AddPosting");
            //     }
            //  }
            // else if (newposting.DateApply == DateTime.Today){
              
            //         User user = _context.Users.Where(u => u.Id == (HttpContext.Session.GetInt32("UserId"))).FirstOrDefault();
            //         if (ModelState.IsValid){
            //             PostingEvent creatingposting = new PostingEvent(){
            //             Creator = user,
            //             CreatorId = user.Id,
            //             Company = newposting.Company,
            //             DateApply = newposting.DateApply,
            //             JobLink = newposting.JobLink,
            //             JobPosting = newposting.JobPosting,
            //             PositionTitle = newposting.PositionTitle,
            //             Notes = newposting.Notes,
            //             RecruiterName = newposting.RecruiterName,
            //             ContactName = newposting.ContactName,
            //             PhoneScreen = newposting.PhoneScreen,
            //             ScreenNotes = newposting.ScreenNotes,
            //             PhoneInterview = newposting.PhoneInterview,
            //             PhoneNotes = newposting.PhoneNotes,
            //             Interview = newposting.Interview,
            //             InterviewNotes = newposting.InterviewNotes,
            //             Denied = newposting.Denied,
            //             DeniedNotes = newposting.DeniedNotes,

            //             };
            //             _context.Postings.Add(creatingposting);
            //             _context.SaveChanges();
            //             return RedirectToAction("Posting", new {postId = creatingposting.PostingId});
            //         }
            //         else{
            //             return View("AddPosting");
            //             }
            //     }
                
            //     else{
            //     TempData["Future"] = "Please enter a Time and Date in the future";
            //     return RedirectToAction("AddPosting");
            //     }

            }

[HttpGet("edit/{id}")]
        public IActionResult Update(int id)
        {
            PostingEvent PostToUpdate = _context.Postings.FirstOrDefault(PostingEvent => PostingEvent.PostingId == id);
            
            return View("Edit", PostToUpdate);
        }

        [HttpPost("edit/{id}")]
        public IActionResult Edit (int id, PostingEvent UpdatedPost)
        {
            
            PostingEvent PostToUpdate = _context.Postings.FirstOrDefault(PostingEvent => PostingEvent.PostingId == id);


            PostToUpdate.Company = UpdatedPost.Company;
            PostToUpdate.DateApply = UpdatedPost.DateApply;
            PostToUpdate.JobLink = UpdatedPost.JobLink;
            PostToUpdate.JobPosting = UpdatedPost.JobPosting;
            PostToUpdate.PositionTitle = UpdatedPost.PositionTitle;
            PostToUpdate.Notes = UpdatedPost.Notes;
            // PostToUpdate.JobLocation = UpdatedPost.JobLocation;
            PostToUpdate.RecruiterName = UpdatedPost.RecruiterName;
            PostToUpdate.ContactName = UpdatedPost.ContactName;
            PostToUpdate.PhoneScreen = UpdatedPost.PhoneScreen;
            PostToUpdate.ScreenNotes = UpdatedPost.ScreenNotes;
            PostToUpdate.Interview = UpdatedPost.Interview;
            PostToUpdate.InterviewNotes = UpdatedPost.InterviewNotes;
            PostToUpdate.PhoneInterview = UpdatedPost.PhoneInterview;
            PostToUpdate.PhoneNotes = UpdatedPost.PhoneNotes;
            PostToUpdate.Denied = UpdatedPost.Denied;
            PostToUpdate.DeniedNotes = UpdatedPost.DeniedNotes;
            PostToUpdate.ScreenEmail = UpdatedPost.ScreenEmail;
            PostToUpdate.ScreenLetter = UpdatedPost.ScreenLetter;
            PostToUpdate.ScreenCall = UpdatedPost.ScreenCall;
            PostToUpdate.PhoneEmail = UpdatedPost.PhoneEmail;
            PostToUpdate.PhoneLetter = UpdatedPost.PhoneLetter;
            PostToUpdate.PhoneCall = UpdatedPost.PhoneCall;
            PostToUpdate.InterviewEmail = UpdatedPost.InterviewEmail;
            PostToUpdate.InterviewLetter = UpdatedPost.InterviewLetter;
            PostToUpdate.InterviewCall = UpdatedPost.InterviewCall;
            PostToUpdate.DeniedEmail = UpdatedPost.DeniedEmail;
            PostToUpdate.DeniedLetter = UpdatedPost.DeniedLetter;
            PostToUpdate.DeniedCall = UpdatedPost.DeniedCall;
            PostToUpdate.ConfirmationEmail = UpdatedPost.ConfirmationEmail;

            PostToUpdate.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Home");
        }






        

[Route("logout")]
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

[HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
           
            PostingEvent PostingToDelete = _context.Postings.SingleOrDefault(Posting => Posting.PostingId == id);
            _context.Postings.Remove(PostingToDelete);
            
            _context.SaveChanges();
            return RedirectToAction("Home");
        }


}}