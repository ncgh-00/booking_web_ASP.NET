using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trividi_Booking.Models;
using Trividi_Booking.Ultils;

namespace Trividi_Booking.Controllers
{
    public class BookingController : Controller
    {
        private readonly Net_BookingContext _db;

        public BookingController(Net_BookingContext db)
        {
            _db = db;
        }

        public IActionResult Index(int id, string error)
        {
            var listH = _db.Hotels.ToList();
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
            HotelDetail hd = list2.Where(hotel => hotel.ID == id).FirstOrDefault();
            IEnumerable<RoomDetail> room = _db.RoomDetails.Where(room => room.IdHotel == id && room.Status == true);
            ViewBag.RoomDetails = room;
            ViewBag.page = "Booking";
            if (error != null)
            {
                ViewBag.error = error;
            }
            return View(hd);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Book(string idhotel, string name, string phone, int roomtype, int numofroom, string dateS, string dateE)
        {
            if (DateValid.duration(dateS, dateE) < 0 || !DateValid.isLogicDate(dateS) || !DateValid.isLogicDate(dateE))
            {
                return RedirectToAction("Index", "Booking", new { id = idhotel, error = "Date is invalid!" });
            }
            if (HttpContext.Session.GetInt32("id") == null)
            {
                if (!Validation.ValidMobileNumber(phone))
                {
                    return RedirectToAction("Index", "Booking", new { id = idhotel, error = "Phone number is invalid!" });
                }
                else if (_db.Accounts.Where(a => a.Phone == phone).FirstOrDefault() != null)
                {
                    System.Console.WriteLine(_db.Accounts.Where(a => a.Phone == phone));
                    return RedirectToAction("Index", "Booking", new { id = idhotel, error = "Phone number was used for another account!" });
                }
                string password = RandomString.GeneratePassword(6);
                Account acc = new Account();
                acc.FullName = name;
                acc.Status = true;
                acc.RoleId = 1;
                acc.Username = phone;
                acc.Phone = phone;
                acc.HashPassword = PasswordEncryption.MD5Hash(password);
                _db.Accounts.Add(acc);
                _db.SaveChanges();
                Account newAcc = _db.Accounts.Where(a => a.Username == phone).FirstOrDefault();
                HttpContext.Session.SetInt32("roleid", (int)newAcc.RoleId);
                HttpContext.Session.SetString("name", newAcc.FullName);
                HttpContext.Session.SetInt32("id", newAcc.Uid);
                if(newAcc.IdHotel!=null){
                    HttpContext.Session.SetInt32("idH", (int)newAcc.IdHotel);
                }

                Booking book = new Booking();
                book.Confirm = false;
                book.DateStart = DateTime.ParseExact(dateS, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                book.DateEnd = DateTime.ParseExact(dateE, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                book.IdRoomDetails = roomtype;
                book.NumberOfRooms = numofroom;
                RoomDetail room = _db.RoomDetails.Find(roomtype);
                var cost = (Double)(room.Cost/24000) * (Double)(1-room.Discount /100);
                book.TotalCosts = (Int32)(cost * DateValid.duration(dateS,dateE) * numofroom);
                book.Uid = newAcc.Uid;
                _db.Bookings.Add(book);
                _db.SaveChanges();
                return RedirectToAction("Index", "User", new { username = phone, password = password, show = 1 });
            } else {
                int uid = HttpContext.Session.GetInt32("id").Value;
                Booking book = new Booking();
                book.Confirm = false;
                book.DateStart = DateTime.ParseExact(dateS, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                book.DateEnd = DateTime.ParseExact(dateE, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                book.IdRoomDetails = roomtype;
                book.NumberOfRooms = numofroom;
                RoomDetail room = _db.RoomDetails.Find(roomtype);
                var cost = (Double)(room.Cost * (1-(Double)room.Discount /100)) /24000;
                book.TotalCosts = (Int32)(cost * DateValid.duration(dateS,dateE) * numofroom);
                book.Uid = uid;
                _db.Bookings.Add(book);
                _db.SaveChanges();
                return RedirectToAction("Index", "User");
            }
        }


    }
}