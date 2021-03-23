using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Models
{
    public class CreateAccout_Model
    {
        private IWebDriver driver;
        public CreateAccout_Model(IWebDriver _driver)
        {
            driver = _driver;
        }
    }
}
