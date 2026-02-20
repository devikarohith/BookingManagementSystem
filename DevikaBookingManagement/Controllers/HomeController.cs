using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookingManagementBLL;
using DevikaBookingManagement.Models;

namespace DevikaBookingManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReservationList()
        {
            BookingModel bookingModel = new BookingModel();
            BookingBLL obj = new BookingBLL();
            var lstResult = obj.GetAllReservation();
            if (lstResult != null)
            {
                bookingModel.Bookings = lstResult.Select(item => new BookingModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Amount = item.Amount
                }).ToList();
            }
            
            return View(bookingModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}