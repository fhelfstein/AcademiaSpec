using AcademiaSpec.Abstracao;
using AcademiaSpec.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Testes
{
    public class _03_AbrirDepartamentoAbriProduto : SuperBase
    {
        private IWebDriver dirver;
        private Home_model home;
        private BuscaCateg_model busca;

        public _03_AbrirDepartamentoAbriProduto() : base()
        {
            busca = new BuscaCateg_model(driver);
        }

        //[Test]
        public void NavegaDepartamento()
        {
            busca.abreSubDepartamento();
            busca.AbreProduto();
        }

        //[TearDown]
        public void quit()
        {
            Dispose();
        }
    }
}
