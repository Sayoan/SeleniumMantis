using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoSomar.SeleniumComum;
using ProjetoSomar.SeleniumUteis;
using SeleniumMantis.SeleniumComum;
using SeleniumWebDriver.Basics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class ReportIssuesPageObjects : WebDriver
    {

        [FindsBy(How = How.Name, Using = "category_id")]
        public IWebElement cbCategory { get; set; }

        [FindsBy(How = How.Name, Using = "reproducibility")]
        public IWebElement cbReproducibility { get; set; }

        [FindsBy(How = How.Name, Using = "severity")]
        public IWebElement cbSeverity { get; set; }

        [FindsBy(How = How.Name, Using = "priority")]
        public IWebElement cbPriority { get; set; }

        [FindsBy(How = How.Name, Using = "profile_id")]
        public IWebElement cbProfile { get; set; }

        [FindsBy(How = How.Name, Using = "project_id")]
        public IWebElement cbProjeto { get; set; }

        [FindsBy(How = How.Id, Using = "platform")]
        public IWebElement tfPlatform { get; set; }

        [FindsBy(How = How.Id, Using = "os")]
        public IWebElement tfOs { get; set; }

        [FindsBy(How = How.Id, Using = "os_build")]
        public IWebElement tfOs_Build { get; set; }

        [FindsBy(How = How.Name, Using = "handler_id")]
        public IWebElement cbHandler { get; set; }

        [FindsBy(How = How.Name, Using = "summary")]
        public IWebElement tfSummary { get; set; }

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement tfdDescription { get; set; }

        [FindsBy(How = How.Name, Using = "steps_to_reproduce")]
        public IWebElement tfSteps { get; set; }

        [FindsBy(How = How.Name, Using = "additional_info")]
        public IWebElement tfAdditional { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='view_state'])")]
        public IWebElement rbViewState { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@value='Submit Report']")]
        public IWebElement btSubmit { get; set; }

        [FindsBy(How = How.ClassName, Using = "form-title")]
        public IWebElement txtError { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'View Submitted Issue')]")]
        public IWebElement txtIDIssue { get; set; }

        [FindsBy(How = How.LinkText, Using = "View Issues")]
        public IWebElement LtViewIssues { get; set; }

        [FindsBy(How = How.Name, Using = "search")]
        public IWebElement tfSearch { get; set; }

        [FindsBy(How = How.Name, Using = "filter")]
        public IWebElement btFilter { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@alt='Edit']")]
        public IWebElement btPicFilter { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Edit']")]
        public IWebElement btEdit { get; set; }


        [FindsBy(How = How.LinkText, Using = "Report Issue")]
        public IWebElement ltReportIssue { get; set; }
        


        public ReportIssuesPageObjects()
        {
            PageFactory.InitElements(DriverFactory.INSTANCE, this);
        }

       


        public void VerificarAcessaReportIssue()
        {

            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            SeleniumUteis Uteis = new SeleniumUteis();
            HomePageObjects homePageObjects = new HomePageObjects();
            //veriricar espera

            //método try catch para validar se foi possível acessar a tela inicial
            
                //NUnit.Framework.Assert.AreEqual("Report Issue", _driver.FindElement(By.LinkText("Report Issue")).Text);
                Uteis.VerificarItem(homePageObjects.ltReportIssue, "Report Issue", "");
            

        }
        public void VerificarDefaultProfile(String conteudo)
        {

            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            SeleniumUteis Uteis = new SeleniumUteis();
            HomePageObjects homePageObjects = new HomePageObjects();
            //veriricar espera

            //método try catch para validar se foi possível acessar a tela inicial
            
                
                Uteis.CBClick(cbProfile, "", conteudo);
                Thread.Sleep(3000);
           

        }

        public void VerificarCampoObrigatorio()
        {

            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            SeleniumUteis Uteis = new SeleniumUteis();
            //veriricar espera

            //método try catch para validar se foi possível acessar a tela inicial
           
                btSubmit.Click();
                Uteis.VerificarItem(txtError, "APPLICATION ERROR #11", "");
                Uteis.VerificarItem(ltReportIssue, "Report Issue", "");
                



        }







        public void InserirTarefa()
        {
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumUteis Uteis = new SeleniumUteis();


            Uteis.CBClick(cbCategory, "category_id", "[All Projects] app_14");
            Uteis.CBClick(cbReproducibility, "reproducibility", "always");
            Uteis.CBClick(cbSeverity, "severity", "feature");
            Uteis.CBClick(cbSeverity, "priority", "none");
            Uteis.CBClick(cbSeverity, "profile_id", "Desktop Windows 10");
            Uteis.PreencherCampo(tfPlatform, "platform", "teste1");
            Uteis.PreencherCampo(tfOs, "os", "teste2");
            Uteis.PreencherCampo(tfOs_Build, "os_build", "teste3");
            Uteis.CBClick(cbHandler, "handler_id", "administrator");
            Uteis.PreencherCampo(tfSummary, "summary", "TESTE_SUMMARY");
            Uteis.PreencherCampo(tfdDescription, "description", "teste4");
            Uteis.PreencherCampo(tfSteps, "steps_to_reproduce", "teste4");
            Uteis.PreencherCampo(tfAdditional, "additional_info", "teste4");




            DriverFactory.INSTANCE.FindElement(By.XPath("(//input[@name='view_state'])[2]")).Click();
            DriverFactory.INSTANCE.FindElement(By.Name("view_state")).Click();
            DriverFactory.INSTANCE.FindElement(By.XPath("//input[@value='Submit Report']")).Click();


        }

        public String InserirTarefa_RetornoSummary()
        {
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumUteis Uteis = new SeleniumUteis();
            GerarRandom gerarRandom = new GerarRandom();
            String summary = gerarRandom.RandomString();


            Uteis.CBClick(cbCategory, "category_id", "[All Projects] app_14");
            Uteis.CBClick(cbReproducibility, "reproducibility", "N/A");
            Uteis.CBClick(cbPriority, "priority", "none");

            Uteis.PreencherCampo(tfPlatform, "platform", "teste1");
            Uteis.PreencherCampo(tfOs, "os", "teste2");
            Uteis.PreencherCampo(tfOs_Build, "os_build", "teste3");
            Uteis.CBClick(cbHandler, "handler_id", "administrator");
            Uteis.PreencherCampo(tfSummary, "summary", summary);
            Uteis.PreencherCampo(tfdDescription, "description", "teste4");
            Uteis.PreencherCampo(tfSteps, "steps_to_reproduce", "teste4");
            Uteis.PreencherCampo(tfAdditional, "additional_info", "teste4");
            Uteis.ClicarBotao(btSubmit);
            

            return summary;
        }

        public void InserirIssue_Simple(string category, string reproducibility, string severity, string priority, string summary, string description)
        {
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumUteis Uteis = new SeleniumUteis();

            

            //dinamico
            Uteis.CBClick(cbCategory, "category_id", category);
            Uteis.CBClick(cbReproducibility, "reproducibility", reproducibility);
            Uteis.CBClick(cbSeverity, "severity", severity);
            Uteis.CBClick(cbPriority, "priority", priority);
            Uteis.PreencherCampo(tfSummary, "summary", summary);
            Uteis.PreencherCampo(tfdDescription, "description", description);

            //estático
            
            Uteis.CBClick(cbProfile, "profile_id", "Desktop Windows 10");
            Uteis.PreencherCampo(tfPlatform, "platform", "teste1");
            Uteis.PreencherCampo(tfOs, "os", "teste2");
            Uteis.PreencherCampo(tfOs_Build, "os_build", "teste3");
            Uteis.CBClick(cbHandler, "handler_id", "administrator");
            Uteis.PreencherCampo(tfSteps, "steps_to_reproduce", "teste4");
            Uteis.PreencherCampo(tfAdditional, "additional_info", "teste4");


            DriverFactory.INSTANCE.FindElement(By.XPath("(//input[@name='view_state'])[2]")).Click();
            DriverFactory.INSTANCE.FindElement(By.Name("view_state")).Click();
            DriverFactory.INSTANCE.FindElement(By.XPath("//input[@value='Submit Report']")).Click();

            
        }


        

        public String PegarIssueInserida(String summary)
        {
            //Após inserir uma issue aparece uma tela rapidamente informando o ID da issue

            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumUteis Uteis = new SeleniumUteis();
            String ID = "";


                Uteis.ClicarBotao(LtViewIssues, "");
                Uteis.LimparCampo(tfSearch);
                Uteis.PreencherCampo(tfSearch, "", summary);
                Uteis.ClicarBotao(btFilter, "");
                Uteis.ClicarBotao(btPicFilter, "");


                String URL = DriverFactory.INSTANCE.Url; //pegar a URL 
                ID = URL.Substring(URL.Length - 4); //tratamento da URL que contem o ID









            return ID;
        }

        public void AcessarEdicaoIssue(String summary)
        {
            //Após inserir uma issue aparece uma tela rapidamente informando o ID da issue

            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumUteis Uteis = new SeleniumUteis();
            String ID = "";


                Uteis.ClicarBotao(LtViewIssues, "");
                Uteis.LimparCampo(tfSearch);
                Uteis.PreencherCampo(tfSearch, "", summary);
                Uteis.ClicarBotao(btFilter, "");
                Uteis.ClicarBotao(btPicFilter, "");




        }

        public void AcessarEdicaoIssue_TelaPosBuscarID()
        {
            //Após inserir uma issue aparece uma tela rapidamente informando o ID da issue

            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumUteis Uteis = new SeleniumUteis();
            String ID = "";

            

                Uteis.ClicarBotao(btEdit,"");




        }



    }
}
    
