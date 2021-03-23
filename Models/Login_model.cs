using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Models
{
    public class Login_model
    {
        private IWebDriver driver;
        public Login_model(IWebDriver _driver)
        {
            driver = _driver;
        }
    }
}
