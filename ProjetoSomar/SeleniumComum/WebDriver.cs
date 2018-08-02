using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        //decoração simbolizando método que executa antes de iniciar o teste
        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(SeleniumUteis.SeleniumUteis.getPathSeleniumDriver());
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