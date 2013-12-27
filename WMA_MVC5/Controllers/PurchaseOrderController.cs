using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace WMAStart.Controllers
{
    public class PurchaseOrderController : Controller
    {
        //
        // GET: /PurchaseOrder/

        public ActionResult Index(int id)
        {

            BusinessLayer.PurchaseOrder_BusinessLayer My_PO = new BusinessLayer.PurchaseOrder_BusinessLayer();
            IEnumerable<Purchase_Order> sForms = My_PO.PurchaseOrder_With_ConsignmentNoteID(id).ToList();

            return View(sForms);

        }

        //
        // GET: /PurchaseOrder/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PurchaseOrder/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PurchaseOrder/Create

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
        // GET: /PurchaseOrder/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PurchaseOrder/Edit/5

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
        // GET: /PurchaseOrder/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PurchaseOrder/Delete/5

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
