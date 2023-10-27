using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdurekaWebsite.pageObjects
{
    public class Profile
    {
        IWebDriver driver;
       

        public Profile (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//a[@class='dropdown-toggle trackButton']//img[@class='img30']")]
        private IList<IWebElement> allCourses;

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='My Profile']")]
        private IList<IWebElement> profile;

        [FindsBy(How = How.XPath, Using = "//div[@class='personal-details']//i[@class='icon-pr-edit']")]
        private IWebElement edit;

        [FindsBy(How = How.XPath, Using = "//input[@id='fullName']")]
        private IWebElement download;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Experience *']")]
        private IWebElement experience;


        public void waitForPageDisplay()

        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("//div[@class='personal-details']//i[@class='icon-pr-edit']")));

        }
    }
}
