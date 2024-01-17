using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace automationtesting.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            //Maximize the Browser
            driver.Manage().Window.Maximize();

            //Launch TurnUp portal and navigate to website login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2fTimeMaterial");

            //Enter Username Textbox and enter valid username
            IWebElement userNameTextBox = driver.FindElement(By.XPath("//*[@id='UserName\']"));
            string UserName = "Hari";
            userNameTextBox.SendKeys(UserName);
            //or usernameTextBox.SendKeys("hari");


            //Enter password Textbox and enter valid username
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            string Password = "123123";
            passwordTextBox.SendKeys(Password);

            //Identify the login button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm\']/form/div[3]/input[1]"));
            loginButton.Click();

        }

    }
}
