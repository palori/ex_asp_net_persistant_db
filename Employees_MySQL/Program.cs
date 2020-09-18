using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;
using System.Text;
using Employees_MySQL.Models;

namespace Employees_MySQL
{
    public class Program
    {/* Original code (start) -----------------------------------------------------*/
        public static void Main(string[] args)
        {
            TestEmployees();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        /*Original code (end) -----------------------------------------------------*/
        
        private static void TestEmployees()
        {
            // Employee DB created? (Library example method)
            using(var context = new EmployeesContext())
            {
                // Creates the database if not exists
                var dbNotExisting = context.Database.EnsureCreated(); // dbNotExisting = true -> create DB, false -> does nothing

                // Add some data if the DB does not exist
                // (If you run the code below and the primary keys of these books are already declared in the DB it will throw an error)
                Console.WriteLine($"EmployeeDB do not exist = {dbNotExisting}");
                if (dbNotExisting)
                {
                    // Adds some employees
                    context.Employees.Add(new Employee
                    {
                        Name = "Justin",
                        Surname = "Time",
                        Job = "Rellotger",
                        Salary = 1000
                    });
                    context.Employees.Add(new Employee
                    {
                        Name = "Elena",
                        Surname = "Nito Del Bosque",
                        Job = "Jardiner",
                        Salary = 5000
                    });

                    // Saves changes
                    context.SaveChanges();
                }
            }
        }


        /*
            Library example

            Source: https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html
        *//*
        static void Main(string[] args)
        {
            InsertData();
            PrintData();
        }

        private static void InsertData()
        {
            using(var context = new LibraryContext())
            {
                // Creates the database if not exists
                var dbNotExisting = context.Database.EnsureCreated(); // dbNotExisting = true -> create DB, false -> does nothing

                // Add some data if the DB does not exist
                // (If you run the code below and the primary keys of these books are already declared in the DB it will throw an error)
                if (dbNotExisting)
                {
                    // Adds a publisher
                    var publisher = new Publisher
                    {
                        Name = "Mariner Books"
                    };
                    context.Publisher.Add(publisher);

                    // Adds some books
                    context.Book.Add(new Book
                    {
                        ISBN = "978-0544003415",
                        Title = "The Lord of the Rings",
                        Author = "J.R.R. Tolkien",
                        Language = "English",
                        Pages = 1216,
                        Publisher = publisher
                    });
                    context.Book.Add(new Book
                    {
                        ISBN = "978-0547247762",
                        Title = "The Sealed Letter",
                        Author = "Emma Donoghue",
                        Language = "English",
                        Pages = 416,
                        Publisher = publisher
                    });

                    // Saves changes
                    context.SaveChanges();
                }
            }
        }

        private static void PrintData()
        {
            // Gets and prints all books in database
            using (var context = new LibraryContext())
            {
                var books = context.Book
                .Include(p => p.Publisher);
                foreach(var book in books)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"ISBN: {book.ISBN}");
                    data.AppendLine($"Title: {book.Title}");
                    data.AppendLine($"Publisher: {book.Publisher.Name}");
                    Console.WriteLine(data.ToString());
                }
            }
        }*/
    }
}
