using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
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
        //[SetUp]
        public void SetUpLocal() //NATIVO
        {

            _driver = new ChromeDriver(SeleniumUteis.SeleniumUteis.getPathSeleniumDriver());
            //ChromeDriver: nativo do selenium, usar path para o driver
            //Criei um método que retorna o path do driver: SeleniumUteis.SeleniumUteis.getPathSeleniumDriver


            //Ação que navega para o site
            _driver.Navigate().GoToUrl("http://mantis-prova.base2.com.br/");

            //Ação que maximiza a tela
            _driver.Manage().Window.Maximize();
        }

        [SetUp]
        public void SetUpGrid() //GRID
        {
            string navegador = "chrome";
            string nodeURL = "http://192.168.0.10:4444/wd/hub";
            if (navegador == "firefox")
            {
                FirefoxOptions firefox = new FirefoxOptions();
                _driver = new RemoteWebDriver(new Uri(nodeURL), firefox.ToCapabilities());
            }
            else if (navegador == "chrome")
            {
                 
                ChromeOptions chrome = new ChromeOptions();
                _driver = new RemoteWebDriver(new Uri(nodeURL), chrome.ToCapabilities());
            }
            else if (navegador == "ie")
            {
                InternetExplorerOptions ie = new InternetExplorerOptions();
                _driver = new RemoteWebDriver(new Uri(nodeURL), ie.ToCapabilities());

            }


            ///127.0.0.1:4444 local
            ///
            //_driver = new ChromeDriver(SeleniumUteis.SeleniumUteis.getPathSeleniumDriver());
            //ChromeDriver: nativo do selenium, usar path para o driver
            //Criei um método que retorna o path do driver: SeleniumUteis.SeleniumUteis.getPathSeleniumDriver


            //Ação que navega para o site
            _driver.Navigate().GoToUrl("http://mantis-prova.base2.com.br/");

            //Ação que maximiza a tela
            _driver.Manage().Window.Maximize();
        }



        //decoração simbolizando método que serpa executado depois que o teste finalizar
        [TearDown]
        public void TearDown()
        {
            //Método que fecha o driver
            _driver.Quit();
        }
    }

}