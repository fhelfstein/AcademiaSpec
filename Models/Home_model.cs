using AcademiaSpec.Abstracao;
using AcademiaSpec.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Models
{
    public class Home_model
    {
        private IWebDriver driver;
        private Home_page home;
        private Product_page product;
        public Home_model(IWebDriver _driver)
        {
            driver = _driver;
            home = new Home_page(driver);
            product = new Product_page(driver);
        }

        public void verificaAberturaHome()
        {
            Assert.IsTrue(home.txtSearch().Displayed);
            Utils.screenshot(driver);
        }

        public void abreProdutoHome()
        {
            Assert.IsTrue(home.txtSearch().Displayed);
            home.ProdutoHome()[0].Click();
            Assert.True(product.lblNomeProduto().Displayed);
            Utils.screenshot(driver);
        }

        public void abreProdutoHome(int iNumeroProduto)
        {
            Assert.IsTrue(home.txtSearch().Displayed);
            home.ProdutoHome()[iNumeroProduto].Click();
            Assert.True(product.lblNomeProduto().Displayed);
            Utils.screenshot(driver);
        }
    }
}
