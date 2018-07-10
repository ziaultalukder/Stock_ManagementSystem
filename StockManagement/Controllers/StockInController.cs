using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using StockeManagement.Models.DatabaseContext;
using StockeManagement.Models.Models;
using StockeManagement.Models.ViewModels;
using StockManagement.BLL;

namespace StockManagement.Controllers
{
    public class StockInController : Controller
    {
        StockDBContext db = new StockDBContext();
        PartyManager _partyManager = new PartyManager();
        // GET: StockIn
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult StockIn()
        {
            var model = new StockCreateVM();
            model.Categories = db.Categories.ToList();
            model.Parties = _partyManager.GetAll().ToList();
            ViewBag.ProductDropDown = new SelectListItem[] {new SelectListItem() {Value = "", Text = "Select...."} };            
            return View(model);
        }

        [HttpPost]
        public ActionResult StockIn(StockCreateVM model)
        {
            //var stck = new StockIn()
            //{
            //    StocInDate = model.StocInDate,
            //    Description = model.Description,
            //    StockInDetails = model.StockInDetails
            //};


            StockIn stockIn =  Mapper.Map<StockIn>(model);
            db.StockIns.Add(stockIn);
            int isSaved = db.SaveChanges();
            if (isSaved > 0)
            {
                TempData["msg"] = "Successful";
            }
            
            model.Categories = db.Categories.ToList();
            model.Parties = _partyManager.GetAll().ToList();
            ViewBag.ProductDropDown = new SelectListItem[] { new SelectListItem() { Value = "", Text = "Select...." } };
            return View(model);
        }
    }
}