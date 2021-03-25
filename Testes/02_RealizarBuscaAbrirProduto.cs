using AcademiaSpec.Abstracao;
using AcademiaSpec.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Testes
{
    public class _02_RealizarBuscaAbrirProduto : SuperBase
    {
        private IWebDriver dirver;
        private Home_model home;
        private BuscaCateg_model busca;

        public _02_RealizarBuscaAbrirProduto() : base()
        {
            busca = new BuscaCateg_model(driver);
        }

        //[Test]
        public void buscaProduto()
        {
            busca.BuscaProduto("Dress");
            busca.AbreProduto();
        }

        //[TearDown]
        public void quit()
        {
            Dispose();
        }

    }
}
