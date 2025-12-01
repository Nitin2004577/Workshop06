using System;
using System.Collections.Generic;
using System.Linq;

class Booking
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public double Price { get; set; }
    public int DurationInDay { get; set; }
    public bool IsInternational { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Sample List of Bookings
        List<Booking> bookings = new List<Booking>()
        {
            new Booking { CustomerName = "Nitin", Destination = "Pokhara", Price = 12000, DurationInDay = 5, IsInternational = false },
            new Booking { CustomerName = "Sam", Destination = "Thailand", Price = 45000, DurationInDay = 7, IsInternational = true },
            new Booking { CustomerName = "Rita", Destination = "Chitwan", Price = 8000, DurationInDay = 3, IsInternational = false },
            new Booking { CustomerName = "Aarav", Destination = "Dubai", Price = 65000, DurationInDay = 4, IsInternational = true }
        };

        // LINQ Filter: Price above 10,000 AND Duration more than 4 days
        var filteredTours = bookings
            .Where(b => b.Price > 10000 && b.DurationInDay > 4)
            .ToList();

        // Print Summary Report
        Console.WriteLine("Summary Report:");
        foreach (var tour in filteredTours)
        {
            Console.WriteLine($"Customer: {tour.CustomerName}, Destination: {tour.Destination}, " +
                              $"Price: Rs.{tour.Price}, Duration: {tour.DurationInDay} days, " +
                              $"International: {tour.IsInternational}");
        }
    }
}