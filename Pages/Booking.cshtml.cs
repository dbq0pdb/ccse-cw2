using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ccsecw1.Models;
using Microsoft.EntityFrameworkCore;

namespace ccsecw1.Pages
{
    public class BookingModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public BookingModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Hotel> Hotels { get; set; } = new List<Hotel>();
        public List<Tour> Tours { get; set; } = new List<Tour>();

        [BindProperty]
        public HotelFilterModel HotelFilter { get; set; }
        public class HotelFilterModel
        {
            public string Brand { get; set; }

            [DataType(DataType.Date)]
            public DateTime? CheckInDate { get; set; }

            [DataType(DataType.Date)]
            public DateTime? CheckOutDate { get; set; }
        }

        public TourFilterModel TourFilter { get; set; }
        public class TourFilterModel
        {
            public string Brand { get; set; }

            [DataType(DataType.Date)]
            public DateTime? TourCheckInDate { get; set; }

            [DataType(DataType.Date)]
            public DateTime? TourCheckOutDate { get; set; }
        }


        [BindProperty]
        public RoomBookingModel RoomBooking { get; set; }
        public class RoomBookingModel
        {
            public Guid RoomBookingId { get; set; }
            public Guid RoomId { get; set; }
        }


        [BindProperty]
        public TourBookingModel TourBooking { get; set; }
        public class TourBookingModel
        {
            public Guid TourBookingId { get; set; }
            public Guid TourId { get; set; }
        }


        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            public Guid HotelId { get; set; }
            public Guid TourId { get; set; }
            public string RoomType { get; set; } = "";

            [Display(Name = "Booking ID")]
            public Guid BookingId { get; set; }

            [Display(Name = "Customer Number")]
            public string CustomerNumber { get; set; } = "";

            [Display(Name = "Room Booking ID")]
            public Guid RoomBookingId { get; set; }

            [Display(Name = "Check In Date")]
            [DataType(DataType.Date)]
            public DateTime CheckInDate { get; set; }

            [Display(Name = "Check Out Date")]
            [DataType(DataType.Date)]
            public DateTime CheckOutDate { get; set; }

            [Display(Name = "Tour Booking ID")]
            public Guid TourBookingId { get; set; }

            [Display(Name = "Tour Check In Date")]
            [DataType(DataType.Date)]
            public DateTime TourCheckInDate { get; set; }

            [Display(Name = "Tour Check Out Date")]
            [DataType(DataType.Date)]
            public DateTime TourCheckOutDate { get; set; }

            [Display(Name = "Discount Percentage")]
            public int DiscountPercentage { get; set; }

            [Display(Name = "Total Price")]
            public int TotalPrice { get; set; }

            [Display(Name = "Cancelled")]
            public bool Cancelled { get; set; } = false;

            [Display(Name = "Fulfilled")]
            public bool Fulfilled { get; set; } = false;
        }


        /*
        private int CalculateTotalPrice()
        {
            var totalPrice = (durationOfStay * PriceOfRoomAtHotel) * discountpercentage;
            // Code to calculate total price
            return totalPrice;
        }
        */

        public async Task<IActionResult> OnGetAsync()
        {
            // Retrieve hotel and tour data from the database
            Hotels = await _context.Hotels.ToListAsync();
            Tours = await _context.Tours.ToListAsync();
            return Page();
        }

 

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // If the model state is not valid, return the page with the validation errors
                Hotels = _context.Hotels.ToList(); // Populate the hotels list again
                Tours = _context.Tours.ToList();// Populate the tours list again
                return Page();
            }

            // If the model state is valid, you can proceed with the booking
            // Here you can handle the booking logic, such as saving the booking details to the database

            return RedirectToPage("/Confirmation"); // Redirect to a confirmation page after successful booking
        }


        public IActionResult OnPostFilterHotels()
        {
            // Implement filtering logic based on form data
            // Update the displayed hotel grid based on the filtered results
            return new JsonResult(Hotels);
        }

        public IActionResult OnPostBookHotel(int hotelId)
        {
            // Handle booking the selected hotel
            // Save the booking details to the database
            return RedirectToPage("/Confirmation"); // Redirect to a confirmation page after successful booking
        }
    }
}