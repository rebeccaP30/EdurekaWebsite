using EdurekaWebsite.pageObjects;
using EdurekaWebsite.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace EdurekaWebsite.tests
{
    public class Tests : Base
    {
        [Test]
        public void EndToEndFlow()
        {
            //SignUpPage signUpPage = new SignUpPage(getDriver());
           //Profile profile = new Profile(getDriver());

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
           .TextToBePresentInElementValue(driver.FindElement(By.Id("signInBtn")), "Sign In"));

            String errorMessage = driver.FindElement(By.ClassName("alert-danger")).Text;
            TestContext.Progress.WriteLine(errorMessage);

        }


        [Test, Category("Smoke")]
        public void StartToEndFlow() 
        {
            //signup

            //driver.FindElement(By.CssSelector(".signup_click.signup-vd.giTrackElementHeader")).Click();
            //driver.FindElement(By.Id("sg_popup_email")).SendKeys("rmrama@test.com");
            //driver.FindElement(By.Id("sg_popup_phone_no")).SendKeys("680528441");
            //driver.FindElement(By.XPath("//button[normalize-space()='Sign Up']")).Click();
            //driver.FindElement(By.Id("signup_password")).SendKeys("P@ssw0rd");
            //driver.FindElement(By.XPath("//button[normalize-space()='Start Learning']")).Click();

            //Login
            driver.FindElement(By.CssSelector(".login_click.login-vd.giTrackElementHeader")).Click();
            driver.FindElement(By.Id("si_popup_email")).SendKeys("rmrama@test.com");
            driver.FindElement(By.Id("si_popup_passwd")).SendKeys("P@ssw0rd");
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            //Profile
            driver.FindElement(By.XPath("//a[@class='dropdown-toggle trackButton']//img[@class='img30']")).Click();
            //driver.FindElement(By.XPath("//span[normalize-space()='EdurekaGuest']")).Click();
            driver.FindElement(By.XPath("//a[normalize-space()='My Profile']")).Click();
            driver.FindElement(By.XPath("//div[@class='personal-details']//i[@class='icon-pr-edit']")).Click();
            driver.FindElement(By.XPath("//input[@id='fullName']")).SendKeys("Rebecca Pakathi");
            IWebElement link = driver.FindElement(By.XPath("//div[@class='personal-details']//i[@class='icon-pr-edit']"));

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("//div[@class='personal-details']//i[@class='icon-pr-edit']")));


        }
    }

    
    
}