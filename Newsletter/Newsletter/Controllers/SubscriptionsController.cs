using Newsletter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Newsletter.Controllers
{
    public class SubscriptionsController : Controller
    {
        private NewsletterDbContext _db = new NewsletterDbContext();

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(SubscriptionViewModel model)
        {
            if(ModelState.IsValid)
            {

                Subscriptions subscription = new Subscriptions
                {
                    ID = model.ID,
                    Name = model.Name,
                    Email = model.Email,
                    Interval = model.Interval
                };

                _db.Entry(subscription).State = EntityState.Added;
                _db.SaveChanges();

                return RedirectToAction("Details", new { id = subscription.ID});
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int ID)
        {
            var subscriber = _db.Subscriptions.Find(ID);

            SubscriptionViewModel subscription = new SubscriptionViewModel
            {
                ID = subscriber.ID,
                Name = subscriber.Name,
                Email = subscriber.Email,
                Interval = subscriber.Interval
            };

            return View(subscription);
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var subscriber = _db.Subscriptions.Find(ID);

            SubscriptionViewModel subscription = new SubscriptionViewModel
            {
                ID = subscriber.ID,
                Name = subscriber.Name,
                Email = subscriber.Email,
                Interval = subscriber.Interval
            };

            return View(subscription);
        }

        [HttpPost]
        public ActionResult Edit(SubscriptionViewModel model)
        {
            if (ModelState.IsValid)
            {
                Subscriptions subscription = new Subscriptions
                {
                    ID = model.ID,
                    Name = model.Name,
                    Email = model.Email,
                    Interval = model.Interval,
                };

                _db.Entry(subscription).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Details", new { id = subscription.ID });
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var subscriber = _db.Subscriptions.Find(ID);

            SubscriptionViewModel subscription = new SubscriptionViewModel
            {
                ID = subscriber.ID,
                Name = subscriber.Name,
                Email = subscriber.Email,
                Interval = subscriber.Interval
            };

            return View(subscription);
        }


        [HttpPost]
        public ActionResult Delete(int ID, string value)
        {
            if (value == "Yes")
            {
                var subscriber = _db.Subscriptions.Find(ID);

                _db.Subscriptions.Remove(subscriber);
                _db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Details", new { id = ID });
            }
        }
    }
}