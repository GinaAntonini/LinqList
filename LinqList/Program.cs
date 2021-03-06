﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var LFruits =
                from fruit in fruits
                where fruit[0] == 'L'
                select fruit;

            var listOfLfruits = LFruits.ToList();

            listOfLfruits.ForEach(fruit => Console.WriteLine(fruit));


            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var multiplesFourSix = numbers.Where(n => n % 4 == 0 || n % 6 == 0);

            var multiples = multiplesFourSix.ToList();

            multiples.ForEach(number => Console.WriteLine(number));


            // Build a collection of these numbers sorted in ascending order
            var sortedNumbers =
                from number in numbers
                orderby number
                select number;

            var listOfSortedNumbers = sortedNumbers.ToList();

            listOfSortedNumbers.ForEach(sortedNumber => Console.WriteLine(sortedNumber));

            // Output how many numbers are in this list
            var numberOfNumbers =
                numbers.Count();

            Console.WriteLine(numberOfNumbers);


            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
            };

            var sortedNames = names.OrderByDescending(name => name);

            foreach (var s in sortedNames)
            {
                Console.WriteLine(s);
            }


            // How much money have we made?
            List<double> purchases = new List<double>()
                {
                    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                };

            var totalAllPurchases = purchases.Sum();

            Console.WriteLine(totalAllPurchases);

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            var mostExpensive = prices.Max(price => price);

            Console.WriteLine(mostExpensive);

            /*
            Store each number in the following List until a perfect square
            is detected.
            */

            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

         

            // Build a collection of customers who are millionaires
            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            var millionaires =
                from customer in customers
                where customer.Balance >= 1000000
                select $"{customer.Name}";

            var listOfmillionaires = millionaires.ToList();

            listOfmillionaires.ForEach(millionaire => Console.WriteLine(millionaire));

            /* 
              Given the same customer set, display how many millionaires per bank.

              Example Output:
              WF 2
              BOA 1
              FTB 1
              CITI 1
          */

            var howManyMillionaires = from customer in millionaires
                                      group customer by customer into millionaireByBank
                                      select new { Bank = millionaireByBank.Key, theMillionaires = millionaireByBank.Count() };

                    /*
            TASK:
            As in the previous exercise, you're going to output the millionaires,
            but you will also display the full name of the bank. You also need
            to sort the millionaires' names, ascending by their LAST name.

            Example output:
                Tina Fey at Citibank
                Joe Landy at Wells Fargo
                Sarah Ng at First Tennessee
                Les Paul at Wells Fargo
                Peg Vale at Bank of America
        */

        }
    }
}
