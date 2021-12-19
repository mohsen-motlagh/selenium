using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Linq;

namespace selenium
{
    
    public class Tests
    {
        
        [Test]
        public void FailedLoginTest()
        {
            Yahoo yahoo = new Yahoo("faill");
            TryFacebook fb = new TryFacebook("faill");
            TopLearn tp = new TopLearn("faill");
            Assert.Pass();
        }

        [Test]
        public void SuccessfulLoginTest()
        {
            TryFacebook fb = new TryFacebook("success");
            Yahoo yahoo = new Yahoo("success");
            TopLearn tp = new TopLearn("success");
            Assert.Pass();
        }
    }
}