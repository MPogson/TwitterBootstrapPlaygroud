using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using FizzWare.NBuilder;
using TwitterBootStrapPlayground.Models;

namespace TwitterBootStrapPlayground.Controllers
{
    public class InventoryController : Controller
    {
        //
        // GET: /Inventory/

        public ActionResult InventoryMain()
        {
            return View();
        }

        public ActionResult GetInventory()
        {
            //var data = new List<Dictionary<string, object>>() {
            //new Dictionary<string,object>(){ {"ProductName", "Rex"}, {"UnitPrice", "45.68"}},
            //new Dictionary<string,object>(){ {"ProductName", "Smith"}, {"UnitPrice", "75.55"}}};

            var data = Builder<Braclet>
                .CreateListOfSize(10)
                .Build();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}
