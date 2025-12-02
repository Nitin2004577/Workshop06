using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // ===========================================
        // 1. AGGREGATION OPERATORS
        // ===========================================

        List<CashierSales> cashierSales = new List<CashierSales>
        {
            new CashierSales("Cashier A", 12000),
            new CashierSales("Cashier B", 15000),
            new CashierSales("Cashier C", 9000),
            new CashierSales("Cashier D", 18000)
        };

        // Total number of cashiers
        int totalCashiers = cashierSales.Count();

        // Total sales of the day
        double totalSales = cashierSales.Sum(s => s.SalesAmount);

        // Highest sale
        double highestSale = cashierSales.Max(s => s.SalesAmount);

        // Lowest sale
        double lowestSale = cashierSales.Min(s => s.SalesAmount);

        // Average sale
        double averageSale = cashierSales.Average(s => s.SalesAmount);

        Console.WriteLine("=== Aggregation Results ===");
        Console.WriteLine($"Total Cashiers: {totalCashiers}");
        Console.WriteLine($"Total Sales: Rs. {totalSales}");
        Console.WriteLine($"Highest Sale: Rs. {highestSale}");
        Console.WriteLine($"Lowest Sale: Rs. {lowestSale}");
        Console.WriteLine($"Average Sale: Rs. {averageSale}");


        // ===========================================
        // 2. QUANTIFIER OPERATORS (Any / All)
        // ===========================================

        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant("Ram", 17),
            new Applicant("Sita", 22),
            new Applicant("Hari", 19),
            new Applicant("Bishal", 16)
        };

        // Any applicant under 18?
        bool anyUnder18 = applicants.Any(a => a.Age < 18);

        // Check if ALL applicants are above 16
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine("\n=== Quantifier Results ===");
        Console.WriteLine($"Any Applicant Under 18: {anyUnder18}");
        Console.WriteLine($"All Applicants Above 16: {allAbove16}");


        // ===========================================
        // 3. ELEMENT OPERATORS (First, Last, FirstOrDefault)
        // ===========================================

        List<Song> songs = new List<Song>
        {
            new Song("Song A", 210),   // 3.5 min
            new Song("Song B", 300),   // 5 min
            new Song("Song C", 180),   // 3 min
            new Song("Song D", 450)    // 7.5 min
        };

        // First song
        var firstSong = songs.First();

        // Last song
        var lastSong = songs.Last();

        // First song with duration above 4 minutes (240 sec)
        var firstAbove4Min = songs.First(s => s.Duration > 240);

        // Safe result for song longer than 10 minutes (600 sec)
        var longerThan10 = songs.FirstOrDefault(s => s.Duration > 600);

        Console.WriteLine("\n=== Element Operator Results ===");
        Console.WriteLine($"First Song: {firstSong.Title}");
        Console.WriteLine($"Last Song: {lastSong.Title}");
        Console.WriteLine($"First Song > 4 mins: {firstAbove4Min.Title}");

        if (longerThan10 == null)
            Console.WriteLine("No song longer than 10 minutes found.");
        else
            Console.WriteLine($"Song Longer than 10 mins: {longerThan10.Title}");
    }
}


// ===========================================
// Supporting Classes
// ===========================================

// CashierSales for aggregation
public class CashierSales
{
    public string CashierName { get; set; }
    public double SalesAmount { get; set; }

    public CashierSales(string name, double sales)
    {
        CashierName = name;
        SalesAmount = sales;
    }
}

// Applicant for Any/All
public class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Applicant(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Song for element operators
public class Song
{
    public string Title { get; set; }
    public int Duration { get; set; }  // In seconds

    public Song(string title, int duration)
    {
        Title = title;
        Duration = duration;
    }
}
