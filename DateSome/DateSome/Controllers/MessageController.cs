﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DateSome.DataAccess;
using DateSome.Models;
namespace DateSome.Controllers
{
    public class MessageController : Controller
    {
        private readonly DateSomeDbContext _db = new DateSomeDbContext();

        public ActionResult Send(int senderId, int receiverId)
        {
            Message message = new Message()
            {
                SenderId = senderId,
                ReceiverId = receiverId
            };

            return View(message);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Send(Message message)
        {
            if (ModelState.IsValid)
            {
                _db.Messages.Add(message);
                _db.SaveChanges();
                RedirectToAction("Index", "Home");
            }

            return View(message);
        }

        //add pagination
        public ActionResult ShowReceivedList(int receiverId)
        {
            var messages = _db.Messages.Where(m => m.ReceiverId == receiverId);
            return View(messages);
        }

        //add pagination
        public ActionResult ShowSentList(int senderId)
        {
            var messages = _db.Messages.Where(m => m.SenderId == senderId);
            return View(messages);
        }

        public ActionResult Show(int messageId)
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
	}
}