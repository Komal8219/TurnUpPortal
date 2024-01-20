using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationtesting.Pages
{
    public class HomePage
    {
        public void GoToTmPage(IWebDriver driver)
        {

            IWebElement administrationdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));

            administrationdropdown.Click();

            IWebElement Timeandmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            Timeandmaterial.Click();


        }

        //Navigate to time and material module (Click on Administration - Time and material link)

        public void VerifyLoggedUser(IWebDriver driver) 
        {
            //Check if user has logged in successfully
            IWebElement HelloHari = driver.FindElement(By.XPath("//*[@id='logoutForm\']/ul/li/a"));

            //In the code below we are reading the element.
            if (HelloHari.Text == "Hello hari!")
            {
                Console.WriteLine("The user has logged in");

            }

            else
            {
                Console.WriteLine("The user is not logged in");
            }


        }

       
    }
}
