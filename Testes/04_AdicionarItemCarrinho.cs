using AcademiaSpec.Abstracao;
using AcademiaSpec.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Testes
{
    public class _04_AdicionarItemCarrinho
    {
        private IWebDriver dirver;
        private Home_model home;
        private Product_model product;

        public _04_AdicionarItemCarrinho() : base()
        {

        }
        [Test]
        public void AdicionaCarrinho()
        {
            home.abreProdutoHome();
            product.adicionaCarrinho();
        }

        [TearDown]
        public void quit()
        {
            //Dispose();
        }

    }
}
