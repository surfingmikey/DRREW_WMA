using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;


namespace WMAStart.Controllers
{
    public class ManifestController : Controller
    {
        //
        // GET: /Manifest/

        public ActionResult Index()
        {

            Manifest_BusinessLayer My_Manifest = new Manifest_BusinessLayer();

            IEnumerable<Manifest> sForms = My_Manifest.ManifestItem.ToList();
            


            return View(sForms);


        }



        public ActionResult Grid()
        {

            Manifest_BusinessLayer My_Manifest = new Manifest_BusinessLayer();

            IEnumerable<Manifest> sForms = My_Manifest.ManifestItem.ToList();


            return View(sForms);


        }

        //
        // GET: /Manifest/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Manifest/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Manifest/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Manifest/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Manifest/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Manifest/Delete/5

       
      
        
        
        public ActionResult Delete()
        {
            Manifest_BusinessLayer My_Manifest = new Manifest_BusinessLayer();

          //  My_Manifest.ManifestDeleteItem();
            













           




            
            
            return View();
        }

        //
        // POST: /Manifest/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        [ValidateInput(false)]
        public ActionResult DataViewPartial()
        {
            var model = new object[0];
            return PartialView("_DataViewPartial", model);
        }


        [ValidateInput(false)]
        public ActionResult DataViewPartial2()
        {
            var model = new object[0];
            return PartialView("_DataViewPartial2", model);
        }
    }
}
