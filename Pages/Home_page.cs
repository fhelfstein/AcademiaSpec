using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Pages
{
    public class Home_page
    {
        private IWebDriver driver;
        public Home_page(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IList<IWebElement> ProdutoHome()
        {
            try
            {
                IList<IWebElement> list = new List<IWebElement>();
                list = driver.FindElements(By.CssSelector("a.product-name"));
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtSearch()
        {
            try
            {
                return driver.FindElement(By.Id("search_query_top"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<IWebElement> TopMenu()
        {
            try
            {
                IList<IWebElement> list = new List<IWebElement>();
                list = driver.FindElement(By.Id("block_top_menu")).FindElements(By.TagName("li"));
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<IWebElement> subItemInMenu(IWebElement element)
        {
            try
            {
                IList<IWebElement> list = new List<IWebElement>();
                list = element.FindElements(By.TagName("li"));
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement btnSignIn()
        {
            try
            {
                return driver.FindElement(By.CssSelector("a.login"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
