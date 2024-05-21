using ccsecw1.Models;
using System;
using System.Collections.Generic;

namespace ccsecw1.SeedData
{
    public static class ModelData
    {
        public static string GenerateRandomPassportNumber()
        {
            Random random = new Random();
            string passportNumber = "P" + random.Next(100000, 999999).ToString();
            return passportNumber;
        }

        public static string GenerateRandomPhoneNumber()
        {
            Random random = new Random();
            string phoneNumber = "077" + random.Next(10000000, 99999999).ToString();
            return phoneNumber;
        }


        public static string GenerateRandomHotelName()
        {
            string[] hotelNames = { "Grand Hotel", "Riverside Inn", "Mountain View Lodge", "Sunset Beach Resort", "The Plaza", "Lakeside Manor", "Golden Sands Hotel", "Palm Tree Resort", "Harbor View Inn", "Seaside Retreat" };
            Random random = new Random();
            return hotelNames[random.Next(hotelNames.Length)];
        }

        public static string GenerateRandomTourName()
        {
            string[] tourNames = { "Adventure Expedition", "Nature Discovery Tour", "Cultural Heritage Journey", "Tropical Paradise Getaway", "Wildlife Safari Adventure", "Historical Landmarks Tour", "Mountain Trekking Experience", "Coastal Exploration Trip", "Urban City Excursion", "Relaxing Beach Retreat" };
            Random random = new Random();
            return tourNames[random.Next(tourNames.Length)];
        }

        public static bool GenerateRandomBoolean()
        {
            Random random = new Random();
            return random.Next(0, 2) == 0;
        }

        public static string GenerateRandomName()
        {
            string[] firstNames = { "John", "Alice", "Michael", "Emily", "David", "Emma", "Daniel", "Olivia", "James" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore" };
            Random random = new Random();
            string firstName = firstNames[random.Next(firstNames.Length)];
            string lastName = lastNames[random.Next(lastNames.Length)];
            return firstName + " " + lastName;
        }

        public static string GenerateRandomAddress()
        {
            string[] addresses = { "123 High St, Manchester, England, M1 4RF", "135 New North Road, London, England N1 7AA", "456 Park Ln, Liverpool, England L8 3TW", "789 South Ave, Birmingham, England B2 4BB" };
            Random random = new Random();
            return addresses[random.Next(addresses.Length)];
        }

        public static string GenerateRandomBrand()
        {
            string[] holidayBrands = { "Voyage", "Wanderlust", "Odyssey", "Excursion", "Journey", "Roamer", "Venture", "Safari", "Odyssey", "Quest" };
            Random random = new Random();
            return holidayBrands[random.Next(holidayBrands.Length)];
        }

        public static int GenerateRandomRating()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

        public static List<RoomType> GenerateRoomTypes()
        {
            var roomTypesList = new List<RoomType>();

            string[] roomTypes = { "Single", "Double", "Family" };
            foreach (var type in roomTypes)
            {
                var roomType = new RoomType
                {
                    Type = type,
                    RoomTypeId = Guid.NewGuid()
                };
                roomTypesList.Add(roomType);
            }

            return roomTypesList;
        }


        public static string GenerateRandomLocation()
        {
            string[] locations = { "London", "Manchester", "Birmingham", "Liverpool", "Bristol", "Leeds", "Newcastle", "Sheffield", "Nottingham", "Leicester" };
            Random random = new Random();
            return locations[random.Next(locations.Length)];
        }

        public static string GenerateRandomDescription()
        {
            string[] descriptions = { "Exciting adventure tours for everyone", "Discover the world with us", "Unforgettable travel experiences await you", "Your gateway to amazing destinations", "Explore new cultures and traditions" };
            Random random = new Random();
            return descriptions[random.Next(descriptions.Length)];
        }

        public static int GenerateRandomSingleRoomPrice()
        {
            int[] prices = { 100, 150, 200, 250, 300 };
            Random random = new Random();
            return prices[random.Next(prices.Length)];
        }

        public static int GenerateRandomDoubleRoomPrice()
        {
            int[] prices = { 200, 250, 300, 350, 400 };
            Random random = new Random();
            return prices[random.Next(prices.Length)];
        }

        public static int GenerateRandomFamilyRoomPrice()
        {
            int[] prices = { 300, 350, 400, 450, 500 };
            Random random = new Random();
            return prices[random.Next(prices.Length)];
        }

        public static int GenerateRandomDuration()
        {
            return new Random().Next(5, 21);
        }

        public static int GenerateRandomTourPricePerDay()
        {
            List<int> priceOptions = new List<int> { 10, 20, 30, 40, 50 };
            return priceOptions[new Random().Next(priceOptions.Count)];
        }

        public static decimal GenerateTourPrice(int duration, int pricePerDay)
        {
            return duration * pricePerDay;
        }

        public static int GenerateRandomTotalSpaces()
        {
            return new Random().Next(5, 26);
        }


    }
}
