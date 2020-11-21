using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Week_One_Challenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameAndAge()
        {
            string firstName = "Lisa";
            string lastName = "Humpert";
            int age = 52;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);
        }
        [TestMethod]
        public void Array()
        {
            string[] movie = { "Batman", "Die Hard", "Inception", "Little Women" };
        }
        [TestMethod]
        public void ListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Today;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020, 12, 25));
            listOfDates.Add(new DateTime(2020, 3, 12));
            listOfDates.Add(new DateTime(2020, 6, 16));
        }

        [TestMethod]
        public void HowMuchSleepDidYouGet()
        {
            Console.WriteLine("How many hours of  sleep did you get??");
            int hours = 4; 
            if(hours >= 10)
            {
                Console.WriteLine("Wow, That's alot of sleep");
            }
            else if(hours >= 8 && hours < 10)
            {
                Console.WriteLine("You should be well rested");
            }
            else if(hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("oh man get some sleep");
            }

        }
        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "Okay";
            switch(userDay)
            {
                case "Great":
                    Console.WriteLine("Glad you are having a great day");
                    break;
                case "Good":
                    Console.WriteLine("It is a day to be good on");
                    break;
                case "Okay";
                    Console.WriteLine("Hopefully it will get better from here");
                    break;
                case "Bad":
                    Console.WriteLine("There is always tomorrow");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;


               


                    
            }
        }
        [TestMethod]
        public void Supercalifragilisticexplialidocious()
        {
            string name = "Supercalifragilisticexplialidocious";
            foreach(char letter in name)
            {
                if(letter =='i')
                {
                Console.WriteLine(letter);
                }
                else
                {
                Console.WriteLine("not an i");
                }
                

            }
        }





    }
}
    