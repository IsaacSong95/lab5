using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab5.Models;

namespace lab5.Controllers
{
    public class DeleteController : Controller
    {
        // GET: Delete
        public ActionResult Index()
        {
            return View();
        }
        public string del(int ID)
        {
            Database1Entities ent = new Database1Entities();

            job em = ent.jobs.First(X => X.Id == ID);
            ent.jobs.Remove(em);
            ent.SaveChanges();

            return "Done";

        }
        public string del2(string n)
        {
            Database1Entities ent = new Database1Entities();

            List<job> jo = ent.jobs.Where(x => x.Title == n).ToList();
            foreach(var i in jo)
            { ent.jobs.Remove(i); }
            ent.SaveChanges();

            return "Done";


        }

    }
}