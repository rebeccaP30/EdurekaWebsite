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
            SignUpPage signUpPage = new SignUpPage(getDriver());
            
        }

        [Test, Category("Smoke")]
        public void StartToEndFlow() 
        {
            driver.FindElement(By.CssSelector(".signup_click.signup-vd.giTrackElementHeader")).Click();
            driver.FindElement(By.Id("sg_popup_email")).SendKeys("rmrama@test.com");
            driver.FindElement(By.Id("sg_popup_phone_no")).SendKeys("680528441");
            driver.FindElement(By.XPath("//button[normalize-space()='Sign Up']")).Click();
            driver.FindElement(By.Id("signup_password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.XPath("//button[normalize-space()='Start Learning']")).Click();


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
           .TextToBePresentInElementValue(driver.FindElement(By.Id("signInBtn")), "Sign In"));

            String errorMessage = driver.FindElement(By.ClassName("alert-danger")).Text;
            TestContext.Progress.WriteLine(errorMessage);
        }
    }

    
    
}