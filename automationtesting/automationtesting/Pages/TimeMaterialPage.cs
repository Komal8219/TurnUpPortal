using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using automationtesting.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V118.Overlay;
using System.IO;


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


            //this is the Explicit wait
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 3);


            //Check if a new time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 3);


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

            //Click on edit button

            IWebElement clickEditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            clickEditButton.Click();

            //Edit the Code field

            IWebElement editTheCode = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            editTheCode.Click();
            editTheCode.Clear();
            editTheCode.SendKeys("komal");

            //edit the description

            IWebElement editTheDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            editTheDescription.Click();
            editTheDescription.Clear();
            // Generate the random text
            string expectedRandomText = Utilities.Utilities.getRandomString(10);
            editTheDescription.SendKeys(expectedRandomText);

            //Save the Record after edit

            IWebElement saveTheEditRecord = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveTheEditRecord.Click();

            Thread.Sleep(3000);

           
            //To check if record is edited.

            //Check if a new time record has been edited successfully
            IWebElement goLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goLastPageButton.Click();

            IWebElement newEditRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            newEditRecord.Click();

            if (newEditRecord.Text == "komal")
            {
                Console.WriteLine("Record is edited");

            }

            else
            {
                Console.WriteLine("Record is not edited.");
            }

            IWebElement newEditDescriptionRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            newEditDescriptionRecord.Click();

            //To verify the random text

            // Locate the element on the page where the random text is expected
            IWebElement textElement = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]")); 

            // Get the text from the web element
            string actualText = textElement.Text;

            // Compare the text
            if (actualText.Equals(expectedRandomText))
            {
                Console.WriteLine("Verification Passed: Random text matches!");
            }
            else
            {
                Console.WriteLine("Verification Failed: Random text does not match.");
            }

        }
        public void DeleteTimeRecord(IWebDriver driver) 
        {

            //Verify if Record is deleted.

            IWebElement clickLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            clickLastPageButton.Click();

            //click the delete button
            IWebElement clickDeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            clickDeleteButton.Click();

            driver.Quit();          

        }

    }
    
    
}









    
    











    
      
    

    






