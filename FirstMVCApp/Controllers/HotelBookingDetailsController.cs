using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HotelBookingDetailsController : Controller
    {
        public IActionResult Index()
        {
            var hotelBooking = new HotelBookingViewModel()
            {
                Id = 1,
                GuestName = "Shyam",
                DateStart = DateTime.Today,
                DateEnd = DateTime.Today.AddMonths(1)
            };
            return View(hotelBooking);
        }
    }
}
