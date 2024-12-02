using dolgozat_240212;
using System;
using System.Collections.Generic;
using System.Linq;

public static List<Book> konyvek = new List<Book>();
public class Program
{
    private static int initialStockCount;
    private static int soldBooksCount = 0;
    private static int outOfStockCount = 0;
    private static int totalRevenue = 0;
    private static object books;

    public static void Main()
    {
        GenerateBooks();
       PrintResults();
    }

    private static void GenerateBooks()
    {
        var rand = new Random();
        string[] titles = {
            "A Nagy Gőzmozdony Kalandjai", "A Híd a Két Világ", "Az Elveszett Kincs",
            "A Titkos Kert", "A Rózsa Neve", "A Barátság Ereje",
            "Time Machine Journey", "Understanding Quantum Physics", "Basics of C# Programming",
            "The Art of War", "The Invisible Man", "Pride and Prejudice",
            "1984 by George Orwell", "To Kill a Mockingbird", "Brave New World"
        };
        string[] authorNames = {
            "József Attila", "Móricz Zsigmond", "Agatha Christie",
            "Kurt Vonnegut", "George Orwell", "Jane Austen",
            "Albert Einstein", "Isaac Asimov", "Stephen King"
        };

        for (int i = 0; i < 15; i++)
        {
            var authors = new List<Author>();
            int numAuthors = rand.Next(1, 4); // 1 to 3 authors
            for (int j = 0; j < numAuthors; j++)
            {
                authors.Add(new Author(authorNames[rand.Next(authorNames.Length)]));
            }

            string title = titles[rand.Next(titles.Length)];
            int year = rand.Next(2007, DateTime.Now.Year + 1);
            string language = rand.NextDouble() < 0.8 ? "magyar" : "angol"; // 80% magyar, 20% angol
            int stock = rand.NextDouble() < 0.3 ? 0 : rand.Next(5, 11); // 30% 0, 5-10 egyébként
            int price = (rand.Next(10, 101) * 100) % 10000; // Kerek 100-as szám

            books.Add(new Book(isbn, authors, title, year, language, stock, price));
        }
    }

  
    private static void PrintResults()
    {
        Console.WriteLine($"Bruttó bevétel: {totalRevenue} Ft");
        Console.WriteLine($"Kiproffolt könyvek száma a nagykerből: {outOfStockCount}");
        Console.WriteLine($"Kezdő állomány: {initialStockCount} db");
        Console.WriteLine($"Jelenlegi állomány: {books.Sum(b => b.Stock)} db");
        Console.WriteLine($"Összesített változás: {books.Sum(b => b.Stock) - initialStockCount} db");
    }
}

