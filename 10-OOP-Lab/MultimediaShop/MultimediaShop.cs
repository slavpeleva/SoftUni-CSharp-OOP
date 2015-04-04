﻿using MultimediaShop.Engine;
using MultimediaShop.Enums;
using MultimediaShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaShop
{
    class MultimediaShop
    {
        static void Main(string[] args)
        {
            //Item sallingerBook = new Book("4adwlj4", "Catcher in the Rye", 20.00m, "J. D. Salinger", "fiction");
            //Item threeManBook = new Book("84djesd", "Three Men in a Boat", 39.99m, "Jerome K. Jerome", new List<string> { "comedy" });
            //Item acGame = new Game("9gkjdsa", "AC Revelations", 78.00m, "historical", AgeRestriction.Teen);
            //Item bubbleSplashGame = new Game("r8743jf", "Bubble Splash", 7.80m, new List<string> { "child", "fun" });
            //Item godfatherMovie = new Video("483252j", "The Godfather", 99.00m, 178, "crime");
            //Item dieHardMovie = new Video("9853kfds", "Die Hard 4", 9.90m, 144, new List<string> { "action", "crime", "thriller" });

            //DateTime today = DateTime.Now;
            //DateTime fiveYearsAgo = today.AddYears(-5);
            //Sale dieHardSale = new Sale(dieHardMovie, fiveYearsAgo);
            //Console.WriteLine(dieHardSale.SaleDate); // 1/30/2015 2:31:55 PM (today)
            //Sale acSale = new Sale(acGame);
            //Console.WriteLine(acSale.SaleDate); // 1/30/2010 2:31:55 PM


            //DateTime afterOneWeek = today.AddDays(30);
            //Rent bookRent = new Rent(sallingerBook, today, afterOneWeek);
            //Console.WriteLine(bookRent.RentStatus); // Pending

            //DateTime lastMonth = today.AddDays(-34);
            //DateTime lastWeek = today.AddDays(-8);
            //Rent movieRent = new Rent(godfatherMovie, lastMonth, lastWeek);
            //Console.WriteLine(movieRent.RentStatus); // Overdue

            //movieRent.ReturnItem();
            //Console.WriteLine(movieRent.RentStatus); // Returned
            //Console.WriteLine(movieRent.DateOfReturn); // 1/30/2015 2:41:53 PM
            //Console.WriteLine(movieRent.RentFine); // 7.9200
            ShopEngine.Run();
        }
    }
}
