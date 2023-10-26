using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace EdurekaWebsite.pageObjects
{
    public class SignUpPage
    {
        private IWebDriver driver;


        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".signup_click.signup-vd.giTrackElementHeader")]
        private IWebElement signUpButton;

        [FindsBy(How = How.Id, Using = "sg_popup_email")]
        private IWebElement emailAddress;

        [FindsBy(How = How.Id, Using = "sg_popup_phone_no")]
        private IWebElement phonenumber;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Sign Up']")]
        private IWebElement signInButton;

        public SignUpPage(string email, string phone)
        {
            emailAddress.SendKeys(email);
            phonenumber.SendKeys(phone);
            signInButton.Click();

            //return new Page(driver);
        }

        public IWebElement getEmailAddress()
        {
            return emailAddress;

        }
    }
}



      
   
