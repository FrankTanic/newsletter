using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newsletter.Models;

namespace Newsletter.Controllers
{
    public class HomeController : Controller
    {
        private NewsletterDbContext _db = new NewsletterDbContext();

        // GET: Index
        public ActionResult Index()
        {
            List<SubscriptionViewModel> subscriptions = (from s in _db.Subscriptions
                                 select new SubscriptionViewModel
                                 {
                                     ID = s.ID,
                                     Name = s.Name,
                                     Email = s.Email,
                                     Interval = s.Interval
                                 }).ToList();

            if(subscriptions != null)
            {
                return View(subscriptions);
            }
            return View();
        }
    }
}