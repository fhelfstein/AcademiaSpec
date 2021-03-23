using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Pages
{
    public class Product_page
    {
        private IWebDriver driver;

        public Product_page(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IWebElement lblNomeProduto()
        {
            try
            {
                return driver.FindElement(By.TagName("h1"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement lblPreco()
        {
            try
            {
                return driver.FindElement(By.Id("our_price_display"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement btnAdiciona()
        {
            try
            {
                return driver.FindElement(By.Id("add_to_cart")).FindElement(By.TagName("button"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement btnIrCarrinho()
        {
            try
            {
                return driver.FindElement(By.CssSelector("a[title='Proceed to checkout']"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
