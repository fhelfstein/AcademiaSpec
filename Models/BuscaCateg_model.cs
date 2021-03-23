using AcademiaSpec.Abstracao;
using AcademiaSpec.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Models
{
    public class BuscaCateg_model
    {
        private IWebDriver driver;
        private Home_page home;
        private BuscaCateg_page busca;
        private Product_page product;

        public BuscaCateg_model(IWebDriver _driver)
        {
            driver = _driver;
            home = new Home_page(driver);
            busca = new BuscaCateg_page(driver);
            product = new Product_page(driver);
        }

        public void BuscaProduto(string sTermo)
        {
            Assert.IsTrue(home.txtSearch().Displayed);
            home.txtSearch().SendKeys(sTermo + Keys.Enter);
            Assert.True(busca.lstProduct()[0].Displayed);
            Utils.screenshot(driver);
        }

        public void AbreProduto()
        {
            Assert.True(busca.lstProduct()[0].Displayed);
            busca.lstProduct()[0].Click();
            Assert.True(product.lblNomeProduto().Displayed);
            Utils.screenshot(driver);
        }

        public void abreSubDepartamento()
        {
            IWebElement element = null;
            Actions action = new Actions(driver);

            foreach (IWebElement elemento in home.TopMenu())
            {
                if (elemento.Text.Equals("WOMEN"))
                {
                    element = elemento;
                    action.MoveToElement(elemento).Perform();
                    break;
                }
            }

            foreach (IWebElement elemento in home.subItemInMenu(element))
            {
                if (elemento.Text.Contains("TOPS"))
                {
                    elemento.FindElement(By.TagName("a")).Click();
                    break;
                }
            }
            Utils.screenshot(driver);
        }
    }
}
