using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace WMAStart.Controllers
{
    public class PurchaseOrderItemsController : Controller
    {
        //
        // GET: /PurchaseOrderItems/

        public ActionResult Index(int id)
        {

            BusinessLayer.Purchase_Order_Item_BusinessLayer My_POItems = new BusinessLayer.Purchase_Order_Item_BusinessLayer();
            IEnumerable<Purchase_Order_Item> sForms = My_POItems.Purchase_Order_Item_With_PurchaseOrderID(id).ToList();
            return View(sForms);

        }




        public ActionResult AllItems(int id)
        {

            BusinessLayer.Purchase_Order_Item_BusinessLayer My_POItems = new BusinessLayer.Purchase_Order_Item_BusinessLayer();
            IEnumerable<Purchase_Order_Item> sForms = My_POItems.Purchase_Order_Item_With_ConsignmentID(id).ToList();
            return View(sForms);

        }
        //
        // GET: /PurchaseOrderItems/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PurchaseOrderItems/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PurchaseOrderItems/Create

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
        // GET: /PurchaseOrderItems/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PurchaseOrderItems/Edit/5

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
        // GET: /PurchaseOrderItems/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PurchaseOrderItems/Delete/5

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
