using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaSpec.Pages
{
    public class CreateAccout_Page
    {
        private IWebDriver driver;

        public CreateAccout_Page(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IWebElement rdbGenero_Masc()
        {
            try
            {
                return driver.FindElement(By.Id("id_gender"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement rdbGenero_Fem()
        {
            try
            {
                return driver.FindElement(By.Id("id_gender2"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtNome()
        {
            try
            {
                return driver.FindElement(By.Id("customer_firstname"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtSobrenome()
        {
            try
            {
                return driver.FindElement(By.Id("customer_lastname"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtEmail()
        {
            try
            {
                return driver.FindElement(By.Id("email"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtSenha()
        {
            try
            {
                return driver.FindElement(By.Id("passwd"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtEndereco_Nome()
        {
            try
            {
                return driver.FindElement(By.Id("firstname"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtEndereco_Sobrenome()
        {
            try
            {
                return driver.FindElement(By.Id("lastname"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtEndereco_Endereco()
        {
            try
            {
                return driver.FindElement(By.Id("address1"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtEndereco_Cidade()
        {
            try
            {
                return driver.FindElement(By.Id("city"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SelectElement slcEndereco_Estado()
        {
            try
            {
                SelectElement select = new SelectElement(driver.FindElement(By.Id("id_state")));
                return select;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtEndereco_CEP()
        {
            try
            {
                return driver.FindElement(By.Id("postcode"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SelectElement slcEndereco_Pais()
        {
            try
            {
                SelectElement select = new SelectElement(driver.FindElement(By.Id("id_country")));
                return select;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtEndereco_Celular()
        {
            try
            {
                return driver.FindElement(By.Id("phone_mobile"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement txtEndereco_Alias()
        {
            try
            {
                return driver.FindElement(By.Id("alias"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IWebElement btnRegistrar()
        {
            try
            {
                return driver.FindElement(By.Id("submitAccount"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}