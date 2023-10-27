using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdurekaWebsite.pageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".login_click.login-vd.giTrackElementHeader")]
        private IWebElement loginTab;

        [FindsBy(How = How.Id, Using = "si_popup_email")]
        private IWebElement emailAddress;

        [FindsBy(How = How.Id, Using = "si_popup_passwd")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Login']")]
        private IWebElement loginButton;

        public LoginPage(string email, string pass)
        { 
            emailAddress.SendKeys(email);
            password.SendKeys(pass);
            loginButton.Click();

            //return new Page(driver);
        }

        public IWebElement getEmailAddress()
        {
            return emailAddress;

        }
    }
}

