using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace selenium
{
    
    public abstract class Loginsteps
    {
        public WebDriver driver = new ChromeDriver();
        public void GoUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public abstract void FillLogin(string username);
        public abstract void FillPassword(string password);
        public abstract void ChecksuccessfulLogin();
        public void Wait(int secounds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(secounds);
        }
        public void VerifyLogin(string UserName,string Password ,string key)
        {
            GoUrl(Url());
            FillLogin(UserName);
            FillPassword(Password);
            TimeSpan ts = new TimeSpan(0, 0, 5);
            Thread.Sleep(ts);
            Wait(10);
            PressButtton();
            Wait(10);
            if(key == "faill")
            {
                CheckFailedLogin();
            }
            else if(key == "success")
            {
                ChecksuccessfulLogin();
            }
            driver.Close();
        }
        public void VerifyFailedLoginUser()
        {
            GoUrl(Url());
            FillLogin(WrongUser());
            CheckFailedLogin_Pass();
            VerifyLogin(UserNameCorrect(),WrongPass(),"faill");
        }
        public abstract void CheckFailedLogin_Pass();
        public abstract String UserNameCorrect();
        public abstract String PassCorrect();
        public abstract String Url();
        public String WrongPass()
        {
            return "ggg";
        }
        public String WrongUser()
        {
            return "klwecmlkw";
        }


        public abstract void CheckFailedLogin();
        public abstract void PressButtton();
    }
}
