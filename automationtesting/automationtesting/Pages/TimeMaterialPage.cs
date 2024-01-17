using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationtesting.Pages
{
    public class TimeMaterialPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            //Click on create new button
            IWebElement createnew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnew.Click();

            //Select Time from DropDown
            IWebElement MaindropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            MaindropDown.Click();

            IWebElement TimedropDown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            TimedropDown.Click();

            //Enter Code
            IWebElement Entercode = driver.FindElement(By.Id("Code"));
            Entercode.SendKeys("December 2023");

            //Enter Description
            IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
            DescriptionTextBox.SendKeys("December - January 2024");

            //Enter Price
            IWebElement PriceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceTextBox.SendKeys("123123.123");

            //Click on Save Button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();

            Thread.Sleep(3000);

            //Check if a new time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            Thread.Sleep(2000);

            IWebElement newRecordData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            newRecordData.Click();
            if (newRecordData.Text == "December 2023")
            {
                Console.WriteLine("New Record is enetered");

            }

            else
            {
                Console.WriteLine("New record is not eneterd");
            }
        }

        public void EditTimeRecord(IWebDriver driver)
        { 
        
        }

        public void DeleteTimeRecord(IWebDriver driver) 
        {
        
        
        }

    }
    
    
}









    
    











    
      
    

    






