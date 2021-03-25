using AcademiaSpec.Abstracao;
using AcademiaSpec.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Testes
{
    public class _01_AbrirItemHome : SuperBase
    {
        private IWebDriver dirver;
        private Home_model home;
        public _01_AbrirItemHome() : base()
        {
          
        }

        //[Test]
        public void AbreProduto()
        {
            home.abreProdutoHome();
        }

        //[TearDown]
        public void quit()
        {
            Dispose();
        }
    }
}
