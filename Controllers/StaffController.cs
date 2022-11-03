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
    public class StaffController : Controller
    {
        private readonly Net_BookingContext _db;

        public StaffController(Net_BookingContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            int idHotel = HttpContext.Session.GetInt32("idH").Value;
            Hotel hotel = _db.Hotels.Find(idHotel);
            List<HotelCategory> listcategory = _db.HotelCategories.ToList();
            List<City> listcity = _db.Cities.ToList();
            string category = "";
            string city = "";
            foreach (var i in listcategory)
            {
                if (i.IdCategory == hotel.IdCategory)
                {
                    category = i.Name;
                    break;
                }
            }

            foreach (var c in listcity)
            {
                if (c.IdCity == hotel.IdCity)
                {
                    city = c.Name;
                    break;
                }
            }
            HotelDetail hd = new HotelDetail(hotel.IdHotel, hotel.Name, hotel.Description, hotel.Image, hotel.Phone, hotel.Address, hotel.NumberOfStars, hotel.Status, city, category);
            ViewBag.ListRoom = _db.RoomDetails.Where(room => room.IdHotel == idHotel);
            var Lhotel = _db.Hotels.ToList();
            var Lroom = _db.RoomDetails.ToList();
            var booking = _db.Bookings.ToList();
            var listR = Lroom.Join(Lhotel,
                r => r.IdHotel,
                hotel => hotel.IdHotel,
                (r, hotel) => new
                {
                    RoomName = r.Name,
                    HotelName = hotel.Name,
                    IdRoomDetails = r.IdRoomDetails,
                    IdHotel = hotel.IdHotel
                });

            var book_info = booking.Join(listR,
                booking => booking.IdRoomDetails,
                room => room.IdRoomDetails,
                (booking, room) => new
                {
                    IdBooking = booking.IdBooking,
                    RoomName = room.RoomName,
                    HotelName = room.HotelName,
                    Uid = booking.Uid,
                    StaffID = booking.StaffId,
                    DateS = booking.DateStart,
                    DateE = booking.DateEnd,
                    NumberOfRooms = booking.NumberOfRooms,
                    TotalCost = booking.TotalCosts,
                    CreateAt = booking.CreateAt,
                    Confirm = booking.Confirm,
                    Idhotel = room.IdHotel
                });
            var booking_info = book_info.Where(a => a.Idhotel == idHotel).ToList();
            var Laccount = _db.Accounts.ToList();
            var booking_details = booking_info.Join(Laccount,
            book => book.Uid,
            acc => acc.Uid,
            (book, acc) => new BookingDetails(
                book.IdBooking, book.RoomName, book.HotelName, book.DateS, book.DateE, book.NumberOfRooms, book.TotalCost, book.Confirm, book.CreateAt, acc.FullName, acc.Email, acc.Phone
            ));
            ViewBag.Bookings = booking_details;
            return View(hd);
        }

        public IActionResult Statistics(string err)
        {
            int idHotel = HttpContext.Session.GetInt32("idH").Value;
            var bookings = _db.Bookings.ToList();
            var listR = _db.RoomDetails.ToList();
            var booking_details = bookings.Join(listR,
                booking => booking.IdRoomDetails,
                room => room.IdRoomDetails,
                (booking, room) => new
                {
                    IdBooking = booking.IdBooking,
                    IdRoomDetails = room.IdRoomDetails,
                    IdHotel = room.IdHotel,
                    DateStart = booking.DateStart,
                    DateEnd = booking.DateEnd,
                    NumberOfRooms = booking.NumberOfRooms,
                    TotalCosts = booking.TotalCosts,
                    Confirm = booking.Confirm,
                    CreateAt = booking.CreateAt
                });
            int numberBooking = (from x in booking_details
                                 where x.IdHotel == idHotel
                                 select booking_details).Count();
            int? sumTotal = (from x in booking_details
                             where x.IdHotel == idHotel
                             select x.TotalCosts).Sum();
            if (sumTotal == null)
                sumTotal = 0;
            int numberBookingToday = (from x in booking_details
                                      where x.IdHotel == idHotel && x.CreateAt == DateTime.Now.Date
                                      select booking_details).Count();
            int? sumTotalToday = (from x in booking_details
                                  where x.IdHotel == idHotel && x.CreateAt == DateTime.Now.Date
                                  select x.TotalCosts).Sum();
            if (sumTotalToday == null)
                sumTotalToday = 0;
            Statistic stastic = new Statistic(numberBooking, sumTotal.Value, numberBookingToday, sumTotalToday.Value);
            ViewBag.time = DateTime.Now.ToString("hh:mm");
            var booking_hotel = booking_details.Where(a=> a.IdHotel == idHotel && a.Confirm == true ).ToList();

            var final_list = booking_hotel.GroupBy(b => b.CreateAt).Select(b => new Chart(b.Key, b.Count(), b.Sum(b => b.TotalCosts))).ToList();
            ViewBag.list = final_list;

            if(err != null) ViewBag.Err = err;
            return View(stastic);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Statistics(string timeS, string timeE)
        {
            if(DateValid.duration(timeS,timeE)<0){
                return RedirectToAction("Statistics","Staff", new {err = "Date is invalid! Input again."});
            }
            int idHotel = HttpContext.Session.GetInt32("idH").Value;
            var bookings = _db.Bookings.ToList();
            var listR = _db.RoomDetails.ToList();
            var booking_details = bookings.Join(listR,
                booking => booking.IdRoomDetails,
                room => room.IdRoomDetails,
                (booking, room) => new
                {
                    IdBooking = booking.IdBooking,
                    IdRoomDetails = room.IdRoomDetails,
                    IdHotel = room.IdHotel,
                    DateStart = booking.DateStart,
                    DateEnd = booking.DateEnd,
                    NumberOfRooms = booking.NumberOfRooms,
                    TotalCosts = booking.TotalCosts,
                    Confirm = booking.Confirm,
                    CreateAt = booking.CreateAt
                });
            int numberBooking = (from x in booking_details
                                 where x.IdHotel == idHotel
                                 select booking_details).Count();
            int? sumTotal = (from x in booking_details
                             where x.IdHotel == idHotel
                             select x.TotalCosts).Sum();
            if (sumTotal == null)
                sumTotal = 0;
            int numberBookingToday = (from x in booking_details
                                      where x.IdHotel == idHotel && x.CreateAt == DateTime.Now.Date
                                      select booking_details).Count();
            int? sumTotalToday = (from x in booking_details
                                  where x.IdHotel == idHotel && x.CreateAt == DateTime.Now.Date
                                  select x.TotalCosts).Sum();
            if (sumTotalToday == null)
                sumTotalToday = 0;
            Statistic stastic = new Statistic(numberBooking, sumTotal.Value, numberBookingToday, sumTotalToday.Value);
            ViewBag.time = DateTime.Now.ToString("hh:mm");
            DateTime S = DateTime.Parse(timeS);
            DateTime E = DateTime.Parse(timeE);
            System.Console.WriteLine(S);
            System.Console.WriteLine(E);
            var booking = booking_details.Where(b => b.Confirm == true && b.IdHotel==idHotel).ToList();
            var final_list = booking.Where(b => DateValid.durationDateTime(S,b.CreateAt.Value)>=0 && DateValid.durationDateTime(b.CreateAt.Value,E)>=0).ToList();

            var list = final_list.GroupBy(b => b.CreateAt).Select(b => new Chart(b.Key, b.Count(), b.Sum(b => b.TotalCosts))).ToList();
            ViewBag.list = list;

            return View(stastic);
        }

        public IActionResult Confirm(int id)
        {
            Booking booking = _db.Bookings.Find(id);
            booking.Confirm = true;
            _db.Bookings.Update(booking);
            _db.SaveChanges();
            return RedirectToAction("Index", "Staff");
        }

        public IActionResult Activate(int id)
        {
            Hotel hotel = _db.Hotels.Find(id);
            hotel.Status = !hotel.Status;
            _db.Hotels.Update(hotel);
            _db.SaveChanges();
            return RedirectToAction("Index", "Staff");
        }

        public IActionResult ActivateRoom(int id)
        {
            RoomDetail room = _db.RoomDetails.Find(id);
            room.Status = !room.Status;
            _db.RoomDetails.Update(room);
            _db.SaveChanges();
            return RedirectToAction("Index", "Staff");
        }

        public IActionResult EditHotel(int idhotel, string error)
        {
            var hotel = _db.Hotels.Find(idhotel);
            ViewBag.City = _db.Cities.ToList();
            ViewBag.Cate = _db.HotelCategories.ToList();
            if (error != null) { ViewBag.Err = error; };
            return View(hotel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditHotel(int idhotel, string name, string description, int cate, string image, string phone, string address, int numOfStar, int city)
        {
            if (!Validation.ValidMobileNumber(phone))
            {
                return RedirectToAction("EditHotel", "Staff", new { idhotel = idhotel, error = "Phone number is invalid!" });
            }
            Hotel h = _db.Hotels.Find(idhotel);
            h.Name = name;
            h.Description = description;
            h.IdCategory = cate;
            h.Image = image;
            h.Phone = phone;
            h.Address = address;
            h.NumberOfStars = numOfStar;
            h.IdCity = city;
            _db.Hotels.Update(h);
            _db.SaveChanges();
            return RedirectToAction("Index", "Staff");
        }

        public IActionResult AddRoom(int idhotel)
        {
            ViewBag.idhotel = idhotel;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddRoom(int idhotel, string name, string image, int cost, int discount, string description)
        {
            RoomDetail room = new RoomDetail();
            room.IdHotel = idhotel;
            room.Name = name;
            room.Image = image;
            room.Cost = cost;
            room.Discount = discount;
            room.Description = description;
            room.Status = true;
            _db.RoomDetails.Add(room);
            _db.SaveChanges();
            return RedirectToAction("Index", "Staff");
        }

        public IActionResult EditRoom(int idroom)
        {
            RoomDetail room = _db.RoomDetails.Find(idroom);
            return View(room);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditRoom(int idroom, int idhotel, string name, string description, string image, int cost, int discount)
        {
            RoomDetail room = _db.RoomDetails.Find(idroom);
            room.IdHotel = idhotel;
            room.Name = name;
            room.Description = description;
            room.Image = image;
            room.Cost = cost;
            room.Discount = discount;
            _db.RoomDetails.Update(room);
            _db.SaveChanges();
            return RedirectToAction("Index", "Staff");
        }
        




    }
}