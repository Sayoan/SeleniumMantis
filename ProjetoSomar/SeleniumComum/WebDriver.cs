using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using SeleniumWebDriver.Basics.SeleniumUteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Basics
{
    //Modificador de acesso public
    public class WebDriver
    {
       
        //variável global referente ao driver (navegador)
        public static IWebDriver _driver { get; set; }
        //swlbase**

        //decoração simbolizando método que executa antes de iniciar o teste
        [SetUp]
        public void SetUp() //NATIVO
        {

            _driver = new ChromeDriver(SeleniumUteis.SeleniumUteis.getPathSeleniumDriver());
            //ChromeDriver: nativo do selenium, usar path para o driver
            //Criei um método que retorna o path do driver: SeleniumUteis.SeleniumUteis.getPathSeleniumDriver


            //Ação que navega para o site
            _driver.Navigate().GoToUrl("http://mantis-prova.base2.com.br/");

            //Ação que maximiza a tela
            _driver.Manage().Window.Maximize();
        }

        //public void SetUp() //GRID
        //{
        //    //ChromeOptions chrome = new ChromeOptions();

        //    //_driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), chrome.ToCapabilities());
        //    /*
        //                FirefoxProfile firefox = new FirefoxProfile();
        //                DesiredCapabilities desire = new DesiredCapabilities();
        //                desire.SetCapability(FirefoxDriver.ProfileCapabilityName, firefox);
        //     */


        //    string navegador = "chrome";
        //    if (navegador == "firefox")
        //    {
        //        FirefoxOptions firefox = new FirefoxOptions();
        //        _driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), firefox.ToCapabilities());
        //    }
        //    else if (navegador == "chrome")
        //    {
        //        ChromeOptions chrome = new ChromeOptions();
        //        _driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), chrome.ToCapabilities());
        //    }
        //    else if (navegador == "safari")
        //    {
        //        SafariOptions chrome = new ChromeOptions();
        //        _driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), chrome.ToCapabilities());

        //    }


        //    ///127.0.0.1:4444 local
        //    ///
        //    //_driver = new ChromeDriver(SeleniumUteis.SeleniumUteis.getPathSeleniumDriver());
        //    //ChromeDriver: nativo do selenium, usar path para o driver
        //    //Criei um método que retorna o path do driver: SeleniumUteis.SeleniumUteis.getPathSeleniumDriver


        //    //Ação que navega para o site
        //    _driver.Navigate().GoToUrl("http://mantis-prova.base2.com.br/");

        //    //Ação que maximiza a tela
        //    _driver.Manage().Window.Maximize();
        //}



        //decoração simbolizando método que serpa executado depois que o teste finalizar
        [TearDown]
        public void TearDown()
        {
            //Método que fecha o driver
            _driver.Quit();
        }
    }

}