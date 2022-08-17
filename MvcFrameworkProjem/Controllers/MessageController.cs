using BLL.Concrete;
using DAL.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFrameworkProjem.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager msm = new MessageManager(new EfMessageDal());
        public ActionResult Inbox()
        {
            var messagelist = msm.GetListInbox();
            return View(messagelist);
        }
        public ActionResult Sendbox()
        {
            var messagelist=msm.GetListSendbox();
            return View(messagelist);
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var values = msm.GetByID(id);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            return View();
        }
    }
}