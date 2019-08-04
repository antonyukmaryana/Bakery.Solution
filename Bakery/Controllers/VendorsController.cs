using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendors/new")]
  public ActionResult New()
  {
    return View();
  }
  [HttpPost("/vendors")]
  public ActionResult Create(string vendorName)
  {
    Category newVendor = new Vendor(vendorName);
    return RedirectToAction("Index");
  }
  [HttpGet("/vendors/{id}")]
  public ActionResult Show(int id)
  {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Vendor selectedVendor = Vendor.Find(id);
    List<Item> vendorItems = selectedVendor.Orders;
    model.Add("vendor", selectedVendor);
    model.Add("orders", vendorItems);
    return View(model);
  }
    [ HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDescription)
    {
  Dictionary<string, object> model = new Dictionary<string, object>();
  Vendor foundVendor = Vendor.Find(vendorId);
  Order newOrder = new Order(orderDescription);
  foundVendor.AddOrder(newOrder);
  List<Order> categoryItems = foundVendor.Orders;
  model.Add("orders", vendorItems);
  model.Add("vendor", foundVendor);
  return View("Show", model);
    }
  }
}
