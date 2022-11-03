using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Trividi_Booking.Models;

namespace Trividi_Booking.Controllers
{
    public class HotelController : Controller
    {
        private readonly Net_BookingContext _db;

        public HotelController(Net_BookingContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var listH = _db.Hotels.Where(a => a.Status == true).ToList();
            List<HotelCategory> category = _db.HotelCategories.ToList();
            var list1 = listH.Join(
                category,
                hotel => hotel.IdCategory,
                cate => cate.IdCategory,
                (hotel, cate) => new
                {
                    ID = hotel.IdHotel,
                    Name = hotel.Name,
                    Description = hotel.Description,
                    Image = hotel.Image,
                    Phone = hotel.Phone,
                    Address = hotel.Address,
                    NumberOfStars = hotel.NumberOfStars,
                    Status = hotel.Status,
                    IdCity = hotel.IdCity,
                    Category = cate.Name
                });
            List<City> listcity = _db.Cities.ToList();

            var list2 = list1.Join(
                listcity,
                hotel => hotel.IdCity,
                city => city.IdCity,
                (hotel, city) => new HotelDetail(
                     hotel.ID, hotel.Name, hotel.Description, hotel.Image, hotel.Phone, hotel.Address, hotel.NumberOfStars, hotel.Status,
                    city.Name,
                  hotel.Category
                    ));
            ViewBag.city = listcity;
            ViewBag.category = category;
            ViewBag.page = "Home";
            return View(list2);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string search, string search_category, string search_city, int? star)
        {

            var listH = _db.Hotels.ToList();
            if(search_category == null){
                search_category = "";
            }
            if(search_city == null){
                search_city = "";
            }
            if(search == null){
                search = "";
            }
            Console.WriteLine(search_category);

            Console.WriteLine(search_city);

             Console.WriteLine(search);
            List<HotelCategory> category = _db.HotelCategories.ToList();
            var list1 = listH.Join(
                category,
                hotel => hotel.IdCategory,
                cate => cate.IdCategory,
                (hotel, cate) => new
                {
                    ID = hotel.IdHotel,
                    Name = hotel.Name,
                    Description = hotel.Description,
                    Image = hotel.Image,
                    Phone = hotel.Phone,
                    Address = hotel.Address,
                    NumberOfStars = hotel.NumberOfStars,
                    Status = hotel.Status,
                    IdCity = hotel.IdCity,
                    Category = cate.Name
                });
            List<City> listcity = _db.Cities.ToList();
            ViewBag.city = listcity;
            ViewBag.category = category;
            ViewBag.page = "Home";
            if (star != null)
            {
                var list2 = list1.Join(
                listcity,
                hotel => hotel.IdCity,
                city => city.IdCity,
                (hotel, city) => new HotelDetail(
                     hotel.ID, hotel.Name, hotel.Description, hotel.Image, hotel.Phone, hotel.Address, hotel.NumberOfStars, hotel.Status,
                    city.Name,
                  hotel.Category
                    )).Where(x => x.Name.Contains(search) && x.Category.Contains(search_category) && x.City.Contains(search_city) && x.NumberOfStars == star);
                return View(list2);
            }
            else
            {
                var list2 = list1.Join(
                listcity,
                hotel => hotel.IdCity,
                city => city.IdCity,
                (hotel, city) => new HotelDetail(
                     hotel.ID, hotel.Name, hotel.Description, hotel.Image, hotel.Phone, hotel.Address, hotel.NumberOfStars, hotel.Status,
                    city.Name,
                  hotel.Category
                    )).Where(x => x.Name.Contains(search) && x.Category.Contains(search_category) && x.City.Contains(search_city));
                return View(list2);

            }


        }
    }
}