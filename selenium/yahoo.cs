using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium
{
    public class Yahoo : Loginsteps
    {
        public Yahoo(string key)
        {
            if (key == "faill")
            {
                VerifyFailedLoginUser();
            }
            else
            {
                VerifyLogin(UserNameCorrect(),PassCorrect(),key);
            }
            
        }
        public override void FillLogin(string username)
        {
            driver.FindElement(By.Id("login-username")).SendKeys(username);
            driver.FindElement(By.Id("login-username")).SendKeys(Keys.Enter);
            Wait(10);
        }

        public override void FillPassword(string password)
        {
            driver.FindElement(By.CssSelector("#login-passwd")).SendKeys(password);
        }


        public override void PressButtton()
        {
            driver.FindElement(By.CssSelector("#login-passwd")).SendKeys(Keys.Enter);
        }

        public override void CheckFailedLogin_Pass()
        {
            driver.FindElement(By.XPath("//*[@id='username-error']")).GetAttribute("class");
            Wait(10);
        }
        public override void ChecksuccessfulLogin()
        {
            driver.FindElement(By.XPath("//*[@id='ybarMailLink']/span[1]")).GetAttribute("class");
        }

        public override string UserNameCorrect()
        {
            return "mohsenmotlaq";
        }

        public override string PassCorrect()
        {
            return "2080655442";
        }

        public override string Url()
        {
            return "https://login.yahoo.com/";
        }

        public override void CheckFailedLogin()
        {
            driver.FindElement(By.XPath("//*[@id='password-challenge']/form/p")).GetAttribute("class");
        }
    }
}
