using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.IO;

namespace AcademiaSpec.Abstracao
{
    public class SuperBase : IDisposable
    {
        protected IWebDriver driver { get; }
        public SuperBase()
        {
            Constantes.logInfo.Add($"Config.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json");
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
#if DEBUG
                .AddJsonFile("Config.json", optional: false, reloadOnChange: true)
#else
                .AddJsonFile("Config.Release.json", optional: false, reloadOnChange: true)
#endif
                .AddJsonFile($"Config.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            Constantes.sBROWSER = configuration["Browser"];

            switch (Constantes.sBROWSER)
            {
                case "Chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("headless");
                    driver = new ChromeDriver(options);
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                case "FireFox":
                    driver = new FirefoxDriver();
                    break;
                case "Edge":
                    driver = new EdgeDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constantes.iTIMEOUT);
            driver.Navigate().GoToUrl(Constantes.sURL);
        }

        public void Dispose()
        {
            driver?.Quit();
            driver?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
