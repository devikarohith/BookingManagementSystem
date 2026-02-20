using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevikaBookingManagement.Models
{
    public class BookingModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }

        public List<BookingModel> Bookings { get; set; }
    }
}