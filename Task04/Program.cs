using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        
        // List of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Use LINQ to square each number
        var squaredNumbers = numbers.Select(n => n * n).ToList();

        Console.WriteLine("Squared Numbers:");
        foreach (var sq in squaredNumbers)
        {
            Console.WriteLine(sq);
        }


        // List of book objects
        List<Book> books = new List<Book>
        {
            new Book("C# Basics", 750),
            new Book("Advanced .NET", 1500),
            new Book("Data Science Guide", 2200),
            new Book("Python Intro", 500),
            new Book("Machine Learning", 1800)
        };

        // Extract books priced above Rs. 1000
        var premiumBooks = books.Where(b => b.Price > 1000).ToList();

        Console.WriteLine("\nPremium Books (Price > Rs. 1000):");
        foreach (var book in premiumBooks)
        {
            Console.WriteLine($"{book.Title} - Rs. {book.Price}");
        }


        
        // List of student objects
        List<Student> students = new List<Student>
        {
            new Student("Nitin"),
            new Student("Anuj"),
            new Student("Bishal"),
            new Student("Aarav"),
            new Student("Kritika"),
            new Student("Manish"),
            new Student("Sita"),
            new Student("Prakash"),
            new Student("Sujan"),
            new Student("Isha")
        };

        // Sort student names alphabetically
        var sortedStudents = students.OrderBy(s => s.Name).ToList();

        Console.WriteLine("\nSorted Student Names:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student.Name);
        }
    }
}



// Book class for filtering example
public class Book
{
    public string Title { get; set; }
    public double Price { get; set; }

    public Book(string title, double price)
    {
        Title = title;
        Price = price;
    }
}

// Student class for sorting example
public class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}
