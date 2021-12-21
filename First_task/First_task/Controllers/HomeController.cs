using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_task.Controllers
{
    public class HomeController : Controller
    {
      
        //public ViewResult Index()
        //{
        //    ViewResult view = new ViewResult();
        //    view.ViewName = "Index";
        //    return view;
        //}

        //public ViewResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index()
        {
            return View();
        }



        //public ViewResult About()
        //{
        //    ViewResult view = new ViewResult();
        //    view.ViewName = "About";
        //    return view;
        //}

        //public ViewResult About()
        //{
        //    return View();
        //}

        public ActionResult About()
        {
            return View();
        }


        //public ViewResult Contact()
        //{
        //    ViewResult view = new ViewResult();
        //    view.ViewName = "Contact";
        //    return view;
        //}

        //public ViewResult Contact()
        //{
        //    return View();
        //}

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            ViewData["Id"] = 55;
            ViewBag.Id = 10;

            TempData["Id"] = id;
            return View();
        }




        //public ContentResult Content()
        //{
        //    var result = new ContentResult();
        //    result.Content = "Content";
        //    return result;
        //}

        //public ContentResult Content()
        //{
        //    return Content();
        //}

        public ActionResult Content()
        {
            return Content();
        }




        //public JsonResult Json()
        //{
        //    var result = new JsonResult(new { name = "Vusal", surname = "Hebibi" });
        //    return result;

        //}

        //public JsonResult Json()
        //{
        //    return Json();
        //}

        public ActionResult Json()
        {
            return Json();
        }

    }
}
