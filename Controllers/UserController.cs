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

    public class UserController : Controller
    {
        private readonly Net_BookingContext _db;

        public UserController(Net_BookingContext db)
        {
            _db = db;
        }

        public IActionResult Index(string username, string password, string show)
        {
            int id = HttpContext.Session.GetInt32("id").Value;
            Account acc = _db.Accounts.FirstOrDefault(a => a.Uid == id);
            ViewBag.Account = acc;
            var hotel = _db.Hotels.ToList();
            var room = _db.RoomDetails.ToList();
            var booking = _db.Bookings.Where(a => a.Uid == id).ToList();
            var listR = room.Join(hotel,
                r => r.IdHotel,
                hotel => hotel.IdHotel,
                (r, hotel) => new
                {
                    RoomName = r.Name,
                    HotelName = hotel.Name,
                    IdRoomDetails = r.IdRoomDetails
                }
            );
            var book_details = booking.Join(listR,
                booking => booking.IdRoomDetails,
                room => room.IdRoomDetails,
                (booking, room) => new BookingDetails(booking.IdBooking, room.RoomName, room.HotelName, booking.DateStart, booking.DateEnd, booking.NumberOfRooms, booking.TotalCosts, booking.Confirm, booking.CreateAt, acc.FullName, acc.Email, acc.Phone));
            if (username != null && password != null && show != null)
            {
                ViewBag.Username = username;
                ViewBag.Password = password;
                ViewBag.Show = show;
            }
            return View(book_details);
        }

        public IActionResult EditProfile(string Error)
        {
            if (Error != null)
            {
                ViewBag.Error = Error;
            }
            int id = HttpContext.Session.GetInt32("id").Value;
            Account acc = _db.Accounts.FirstOrDefault(a => a.Uid == id);
            return View(acc);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProfile(string name, string email, string phone, string pass, string repass)
        {
            int id = HttpContext.Session.GetInt32("id").Value;
            Account acc = _db.Accounts.FirstOrDefault(a => a.Uid == id);
            if (email != null)
            {
                if (!Validation.ValidEmail(email))
                {
                    ViewBag.Error = "Email is not valid!";
                    return View(acc);

                }
                Account a2 = _db.Accounts.Where(a => a.Email == email && a.Uid != id).FirstOrDefault();
                if (a2 != null)
                {
                    ViewBag.Error = "Email is already exist!";
                    return View(acc);

                }
            }

            if (phone != null)
            {
                if (!Validation.ValidMobileNumber(phone))
                {
                    ViewBag.Error = "Phone is not valid!";
                    return View(acc);

                }
                Account a1 = _db.Accounts.Where(a => a.Phone == phone && a.Uid != id).FirstOrDefault();
                if (a1 != null)
                {
                    ViewBag.Error = "Phone is already exist!";
                    return View(acc);

                }
            }

            if (pass != repass)
            {
                ViewBag.Error = "Password is not match!";
                return View(acc);

            }


            acc.FullName = name;
            acc.Email = email;
            acc.Phone = phone;
            if (pass != null || repass != null)
            {
                acc.HashPassword = PasswordEncryption.MD5Hash(pass);
            }


            _db.SaveChanges();
            return RedirectToAction("Index", "User");
        }
        public IActionResult DeleteBooking(int id)
        {
            Booking booking = _db.Bookings.FirstOrDefault(a => a.IdBooking == id);
            _db.Bookings.Remove(booking);
            _db.SaveChanges();
            return RedirectToAction("Index", "User");
        }

    }
}