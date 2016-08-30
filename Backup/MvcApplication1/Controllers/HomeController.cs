using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //http://professorweb.ru/my/ASP_NET/mvc/level8/8_3.php
        //http://dotnet.today/ru/aspnet5-mvc6/getting-started/first-web-api.html
        public ViewResult Index()
        {
            return View();
        }
        
        ReservationRespository repository = ReservationRespository.Current;
        /*
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }
        */
        public ActionResult Add(Reservation item)
        {
            /*
            string[] filePaths = Directory.GetFiles(System.Web.HttpContext.Current.Server.MapPath("~/"));
            List<ListItem> files = new List<ListItem>();
            foreach (string filePath in filePaths)
            {
                files.Add(new ListItem(Path.GetFileName(filePath), filePath));
            }*/

            if (ModelState.IsValid)
            {
                string[] filePaths = Directory.GetFiles(System.Web.HttpContext.Current.Server.MapPath("~/"));

                foreach (string filePath in filePaths)
                {
                    item.ClientName = Path.GetFileName(filePath);
                    item.Location = filePath;
                    repository.Add(item);
                }
                return RedirectToAction("Index");
            }
            else return View("Index");
        }
        /*
        public ActionResult Update(Reservation item)
        {
            if (ModelState.IsValid && repository.Update(item))
                return RedirectToAction("Index");
            else return View("Index");
        }
         * */
    }
}
