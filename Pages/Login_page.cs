using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Pages
{
    public class Login_page
    {
        private IWebDriver driver;

        public Login_page(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IWebElement txtEmai_New()
        {
            try
            {
                return driver.FindElement(By.Id("email_create"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement btnCreateNewAccount()
        {
            try
            {
                return driver.FindElement(By.Id("SubmitCreate"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtLogin()
        {
            try
            {
                return driver.FindElement(By.Id("email"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtPassword()
        {
            try
            {
                return driver.FindElement(By.Id("passwd"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement btnLogin()
        {
            try
            {
                return driver.FindElement(By.Id("SubmitLogin"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
