using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using SeleniumWebDriver.Basics.SeleniumUteis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumMantis.SeleniumComum
{
    class DriverFactory
    {
        public static IWebDriver INSTANCE { get; set; } = null;

        public static void CreateInstance()
        {

            //criado um appconfig com a configuração desejada
            string navegador = ConfigurationManager.AppSettings["NavegadorDefault"].ToString();
            string nodeURL = ConfigurationManager.AppSettings["IpHub"].ToString();
            string local = ConfigurationManager.AppSettings["Local"].ToString();

        if (INSTANCE == null) {
                switch (local)
                {
                    case ("true"): //rodar local
                        INSTANCE = new ChromeDriver(SeleniumUteis.getPathSeleniumDriver());
                        //Criei um método que retorna o path do driver: SeleniumUteis.SeleniumUteis.getPathSeleniumDriver

                        break;

                    case ("false"): //rodar grid
                        switch (navegador)
                        {
                            case ("firefox"):
                                FirefoxOptions firefox = new FirefoxOptions();
                                INSTANCE = new RemoteWebDriver(new Uri(nodeURL), firefox.ToCapabilities());
                                INSTANCE.Manage().Window.Maximize();
                                break;

                            case ("chrome"):
                                ChromeOptions chrome = new ChromeOptions();
                                INSTANCE = new RemoteWebDriver(new Uri(nodeURL), chrome.ToCapabilities());
                                INSTANCE.Manage().Window.Maximize();
                                break;

                            case ("opera"):
                                OperaOptions opera = new OperaOptions();
                                opera.BinaryLocation = "@" + ConfigurationManager.AppSettings["PatchOperaExe"].ToString(); 
                                INSTANCE = new RemoteWebDriver(new Uri(nodeURL), opera.ToCapabilities());
                                INSTANCE.Manage().Window.Maximize();
                                break;

                            default:
                                throw new NotImplementedException();

                        }
                        break;



                }
          

                
            }
        }

        public static void QuitInstace()
        {
            INSTANCE.Quit();
            INSTANCE = null;
        }




    }
}
