using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationtesting.Utilities
{
    public class Utilities

    {
        public static String getRandomString(int stringLength)
        {

            // Create an instance of the Random class
            Random random = new Random();

            // Define the characters that can be used in the random string
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Generate a random string
            return new string(Enumerable.Repeat(chars, stringLength)
              .Select(s => s[random.Next(s.Length)]).ToArray());


        }

    }

    
}
