using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MvcFrameworkProjem.Controllers
{
    public class CategoryController : Controller
    {
        
        public ActionResult Index()
        {
            CategoryManager cm = new CategoryManager();
            return View();
        }
        //public ActionResult  GetCategoryList()
        //{
        //  var categoryvalues=
        //}
    }
}