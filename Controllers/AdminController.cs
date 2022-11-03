using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Trividi_Booking.Models;
using Trividi_Booking.Ultils;

namespace Trividi_Booking.Controllers
{
    public class AdminController : Controller
    {
        private readonly Net_BookingContext _db;

        public AdminController(Net_BookingContext db)
        {
            _db = db;
        }

        public IActionResult HotelManagement(string username, string password, string show)
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
            ViewBag.city = listcity;
            ViewBag.category = category;
            ViewBag.Acc = _db.Accounts.Where(a => a.RoleId == 2 && a.IdHotel == null).ToList();
            if (username != null && password != null && show != null)
            {
                ViewBag.Username = username;
                ViewBag.Password = password;
                ViewBag.Show = show;
            }
            return View(list2);
        }

        public IActionResult AddHotelWithNewStaff()
        {
            Hotel hotel = new Hotel();
            hotel.Name = RandomString.GenerateName(10);
            hotel.Description = RandomString.GenerateName(10);
            hotel.Image = RandomString.GenerateName(10);
            hotel.Address = RandomString.GenerateName(10);
            hotel.NumberOfStars = 0;
            hotel.Status = false;
            hotel.IdCategory = 1;
            hotel.IdCity = 1;
            _db.Hotels.Add(hotel);
            _db.SaveChanges();
            Hotel newHotel = _db.Hotels.FirstOrDefault(a => a.Name == hotel.Name && a.Status == false && a.Phone == null);

            string username = RandomString.GenerateName(8);
            String password = RandomString.GeneratePassword(6);
            Account acc = new Account();
            acc.FullName = RandomString.GenerateName(6);
            acc.Status = true;
            acc.RoleId = 2;
            acc.Username = username;
            acc.HashPassword = PasswordEncryption.MD5Hash(password);
            acc.IdHotel = newHotel.IdHotel;
            _db.Accounts.Add(acc);
            _db.SaveChanges();

            return RedirectToAction("HotelManagement", "Admin", new { username = username, password = password, show = 1 });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddHotel(int uid)
        {
            Hotel hotel = new Hotel();
            hotel.Name = RandomString.GenerateName(10);
            hotel.Description = RandomString.GenerateName(10);
            hotel.Image = RandomString.GenerateName(10);
            hotel.Address = RandomString.GenerateName(10);
            hotel.NumberOfStars = 0;
            hotel.Status = false;
            hotel.IdCategory = 1;
            hotel.IdCity = 1;
            _db.Hotels.Add(hotel);
            _db.SaveChanges();
            Hotel newHotel = _db.Hotels.FirstOrDefault(a => a.Name == hotel.Name && a.Status == false && a.Phone == null);
            Account acc = _db.Accounts.FirstOrDefault(a => a.Uid == uid);
            acc.IdHotel = newHotel.IdHotel;
            _db.Accounts.Update(acc);
            _db.SaveChanges();
            return RedirectToAction("HotelManagement", "Admin");
        }



        public IActionResult AccountManagement(string username, string password, string show)
        {
            int id = HttpContext.Session.GetInt32("id").Value;
            var listA = _db.Accounts.Where(a => a.Uid != id).ToList();
            ViewBag.ListH = _db.Hotels.ToList();
            List<Hotel> listH = _db.Hotels.ToList();
            System.Console.WriteLine(listH.Count);
            var list1 = (listA.Join(listH,
                                acc => acc.IdHotel,
                                hotel => hotel.IdHotel,
                                (acc, hotel) => new
                                {
                                    IdHotel = hotel.IdHotel,
                                    Name = hotel.Name
                                })).ToList();

            List<Hotel> err = new List<Hotel>();
            for (int i = 0; i < listH.Count; i++)
            {
                for (int j = 0; j < list1.Count; ++j)
                {
                    if (listH[i].IdHotel == list1[j].IdHotel)
                    {
                        listH.Remove(listH[i]);
                    }
                }
            }
                ViewBag.ListHforStaff = listH;
                if (username != null && password != null && show != null)
                {
                    ViewBag.Username = username;
                    ViewBag.Password = password;
                    ViewBag.Show = show;
                }
                return View(listA);
            
        }

        public IActionResult CreateAccount()
        {
            string username = RandomString.GenerateName(8);
            String password = RandomString.GeneratePassword(6);
            Account acc = new Account();
            acc.FullName = RandomString.GenerateName(6);
            acc.Status = true;
            acc.RoleId = 1;
            acc.Username = username;
            acc.HashPassword = PasswordEncryption.MD5Hash(password);
            _db.Accounts.Add(acc);
            _db.SaveChanges();
            return RedirectToAction("AccountManagement", "Admin", new { username = username, password = password, show = 1 });
        }
        public IActionResult Statistics( string err)
        {
            int numberBooking = _db.Bookings.Where(b => b.Confirm == true).Count();
            int? sumTotal = _db.Bookings.Where(b => b.Confirm == true).Sum(b => b.TotalCosts);
            if (sumTotal == null)
                sumTotal = 0;
            else
            {
                sumTotal = Convert.ToInt32(sumTotal - 0.99 * sumTotal);
            }
            int numberBookingToday = _db.Bookings.Where(b => b.Confirm == true && b.CreateAt == DateTime.Now).Count();
            int? sumTotalToday = _db.Bookings.Where(b => b.Confirm == true && b.CreateAt == DateTime.Now).Sum(b => b.TotalCosts);
            if (sumTotalToday == null)
                sumTotalToday = 0;
            else
            {
                sumTotalToday = Convert.ToInt32(sumTotalToday - 0.99 * sumTotalToday);
            }
            Statistic stastic = new Statistic(numberBooking, sumTotal.Value, numberBookingToday, sumTotalToday.Value);
            ViewBag.time = DateTime.Now.ToString("hh:mm");

            var booking = _db.Bookings.Where(b => b.Confirm == true).ToList();
            var final_list = booking.GroupBy(b => b.CreateAt).Select(b => new Chart(b.Key, b.Count(), b.Sum(b => b.TotalCosts * 0.01))).ToList();
            ViewBag.list = final_list;
            if(err != null) ViewBag.Err = err;
            return View(stastic);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Statistics(string timeS, string timeE)
        {
            if(DateValid.duration(timeS,timeE)<0 ){
                return RedirectToAction("Statistics","Admin", new {err = "Date is invalid! Input again."});
            }
            int numberBooking = _db.Bookings.Where(b => b.Confirm == true).Count();
            int? sumTotal = _db.Bookings.Where(b => b.Confirm == true).Sum(b => b.TotalCosts);
            if (sumTotal == null)
                sumTotal = 0;
            else
            {
                sumTotal = Convert.ToInt32(sumTotal - 0.99 * sumTotal);
            }
            int numberBookingToday = _db.Bookings.Where(b => b.Confirm == true && b.CreateAt == DateTime.Now).Count();
            int? sumTotalToday = _db.Bookings.Where(b => b.Confirm == true && b.CreateAt == DateTime.Now).Sum(b => b.TotalCosts);
            if (sumTotalToday == null)
                sumTotalToday = 0;
            else
            {
                sumTotalToday = Convert.ToInt32(sumTotalToday - 0.99 * sumTotalToday);
            }
            Statistic stastic = new Statistic(numberBooking, sumTotal.Value, numberBookingToday, sumTotalToday.Value);

            DateTime S = DateTime.Parse(timeS);
            DateTime E = DateTime.Parse(timeE);
            System.Console.WriteLine(S);
            System.Console.WriteLine(E);
            ViewBag.time = DateTime.Now.ToString("hh:mm");
            var booking = _db.Bookings.Where(b => b.Confirm == true).ToList();


            var final_list = booking.Where(b => DateValid.durationDateTime(S,b.CreateAt.Value)>=0 && DateValid.durationDateTime(b.CreateAt.Value,E)>=0).ToList();
            Console.WriteLine(booking.Count);
            var list = final_list.GroupBy(b => b.CreateAt).Select(b => new Chart(b.Key, b.Count(), b.Sum(b => b.TotalCosts * 0.01))).ToList();
            ViewBag.list = list;
            return View(stastic);
        }

        public IActionResult ActivateHotel(int id)
        {
            Hotel hotel = _db.Hotels.FirstOrDefault(h => h.IdHotel == id);
            hotel.Status = !hotel.Status;
            _db.Hotels.Update(hotel);
            _db.SaveChanges();
            return RedirectToAction("HotelManagement", "Admin");
        }

        public IActionResult ActivateAccount(int id)
        {
            Account acc = _db.Accounts.FirstOrDefault(a => a.Uid == id);
            acc.Status = !acc.Status;
            _db.Accounts.Update(acc);
            _db.SaveChanges();
            return RedirectToAction("AccountManagement", "Admin");
        }

        public IActionResult UpdateRole(int id, int role)
        {
            Account acc = _db.Accounts.FirstOrDefault(a => a.Uid == id);
            acc.RoleId = role;
            if (role != 2)
            {
                acc.IdHotel = null;
            }
            _db.Accounts.Update(acc);
            _db.SaveChanges();
            return RedirectToAction("AccountManagement", "Admin");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddHotelforStaff(int staffid, int idhotel)
        {
            Account acc = _db.Accounts.Find(staffid);
            acc.IdHotel = idhotel;
            _db.Accounts.Update(acc);
            _db.SaveChanges();
            return RedirectToAction("AccountManagement", "Admin");
        }






    }
}