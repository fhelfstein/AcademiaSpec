using AcademiaSpec.Abstracao;
using AcademiaSpec.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Models
{
    public class Product_model
    {
        private IWebDriver driver;
        private Product_page product;

        public Product_model(IWebDriver _driver)
        {
            driver = _driver;
            product = new Product_page(driver);
        }

        public void adicionaCarrinho()
        {
            Assert.True(product.lblNomeProduto().Displayed);
            product.btnAdiciona().Click();
            product.btnIrCarrinho().Click();
            Utils.screenshot(driver);
        }

        public void verificaTelaProduto()
        {
            Assert.True(product.lblNomeProduto().Displayed);
            Constantes.logInfo.Add($"O nome do produto aberto é: {product.lblNomeProduto().Text}");
            Utils.screenshot(driver);
        }
    }
}
