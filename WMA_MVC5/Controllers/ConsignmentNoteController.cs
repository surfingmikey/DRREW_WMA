using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace WMAStart.Controllers
{
    public class ConsignmentNoteController : Controller
    {
        //
        // GET: /ConsignmentNote/

        public ActionResult Index(int id)
       {

                BusinessLayer.Consignment_Note_BusinessLayer My_ConsignmentNote = new BusinessLayer.Consignment_Note_BusinessLayer();
                IEnumerable<Consignment_Note> sForms = My_ConsignmentNote.Consignment_Note_With_ManifestID(id).ToList();
                return View(sForms);

                               
        }




        //
        // GET: /ConsignmentNote/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ConsignmentNote/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ConsignmentNote/Create

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
        // GET: /ConsignmentNote/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ConsignmentNote/Edit/5

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
        // GET: /ConsignmentNote/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ConsignmentNote/Delete/5

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
    }
}
