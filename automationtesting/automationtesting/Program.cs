
using automationtesting.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // open the chrome browser
        IWebDriver driver = new ChromeDriver();

        //Login page object initialisation and definition
        LoginPage loginPageobj = new LoginPage();
        loginPageobj.LoginActions(driver);

        //Home page object initialisation and definition
        HomePage homePageObj = new HomePage();
        homePageObj.VerifyLoggedUser(driver);
        homePageObj.GoToTmPage(driver);

        //TMpage object initialisation and definition
        TimeMaterialPage timeMaterialPageobj = new TimeMaterialPage();
        timeMaterialPageobj.CreateTimeRecord(driver);
        timeMaterialPageobj.EditTimeRecord(driver);
        timeMaterialPageobj.DeleteTimeRecord(driver);




    }
}