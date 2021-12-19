using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium
{
    class TopLearn : Loginsteps
    {
        public TopLearn(string key)
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

        public override void FillLogin(string username)
        {
            driver.FindElement(By.Id("Email")).SendKeys(username);
        }

        public override void FillPassword(string password)
        {
            driver.FindElement(By.Id("Password")).SendKeys(password);
            Captcha();
        }
        public override void PressButtton()
        {
            driver.FindElement(By.XPath("/html/body/div[8]/div/div[2]/div/form/div[1]/div[8]/button")).Click();
        }
        public void Captcha()
        {
            driver.FindElement(By.XPath("/html/body/div[8]/div/div[2]/div/form/div[1]/div[7]/div/label")).Click();
            driver.FindElement(By.XPath("//div[@class='g-recaptcha']")).Click();
        }
        public override void ChecksuccessfulLogin()
        {
            driver.FindElement(By.XPath("/html/body/div[8]/div/div[2]/div/div[1]/aside/section"));
        }

        public override string UserNameCorrect()
        {
            return "mrostam55@gmail.com";
        }

        public override string PassCorrect()
        {
            return "2080655442";
        }

        public override string Url()
        {
            return "https://toplearn.com/Login";
        }

        public override void CheckFailedLogin()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='Email-error']"));
            }
            catch
            {
                try
                {
                    driver.FindElement(By.XPath("/html/body/div[8]/div/div[2]/div/form/div[1]/div[1]/div/span"));
                }
                catch
                {
                    driver.FindElement(By.XPath("//*[@id='Password-error']"));
                }  
            }
        }

        public override void CheckFailedLogin_Pass()
        {
            throw new NotImplementedException();
        }
    }
}
