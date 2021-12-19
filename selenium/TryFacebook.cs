using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium
{
    class TryFacebook : Loginsteps
    {
        public TryFacebook(string key)
        {
            if (key == "faill")
            {
                VerifyLogin(WrongUser(),WrongPass(),key);
            }
            else
            {
                VerifyLogin(UserNameCorrect(),PassCorrect(),key);
            }
           
        }

        public override void CheckFailedLogin()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='email_container']/div[2]")).GetAttribute("class");
            }
            catch
            {
                driver.FindElement(By.XPath("//*[@id='loginform']/div[2]/div[2]")).GetAttribute("class");
            }
        }

        public override void CheckFailedLogin_Pass()
        {
            throw new NotImplementedException();
        }

        public override void ChecksuccessfulLogin()
        {
            driver.FindElement(By.ClassName("p361ku9c"));
        }

        public override void FillLogin(string username)
        {
            driver.FindElement(By.Id("email")).SendKeys(username);
        }

        public override void FillPassword(string password)
        {
            driver.FindElement(By.Id("pass")).SendKeys(password);
        }

        public override string PassCorrect()
        {
            return "06Gab26efe";
        }

        public override void PressButtton()
        {
            driver.FindElement(By.Id("pass")).SendKeys(Keys.Enter);
        }

        public override string Url()
        {
            return "https://facebook.com";
        }

        public override string UserNameCorrect()
        {
            return "+905413348255";
        }
    }
}
