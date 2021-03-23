using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Pages
{
    public class BuscaCateg_page
    {
        private IWebDriver driver;

        public BuscaCateg_page(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IList<IWebElement> lstProduct()
        {
            try
            {
                return driver.FindElements(By.CssSelector("a.product_img_link"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
