using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoSomar.SeleniumComum;
using ProjetoSomar.SeleniumUteis;
using SeleniumWebDriver.Basics;
using System;
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
            PageFactory.InitElements(WebDriver._driver, this);
        }

       


        public void VerificarAcessaReportIssue()
        {

            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
            SeleniumMaps Maps = new SeleniumMaps();
            HomePageObjects homePageObjects = new HomePageObjects();
            //veriricar espera

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                //NUnit.Framework.Assert.AreEqual("Report Issue", _driver.FindElement(By.LinkText("Report Issue")).Text);
                Maps.VerificarItem(homePageObjects.ltReportIssue, "Report Issue", "");
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }
        public void VerificarDefaultProfile(String conteudo)
        {

            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
            SeleniumMaps Maps = new SeleniumMaps();
            HomePageObjects homePageObjects = new HomePageObjects();
            //veriricar espera

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                
                Maps.CBClick(cbProfile, "", conteudo);
                Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void VerificarCampoObrigatorio()
        {

            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
            SeleniumMaps Maps = new SeleniumMaps();
            //veriricar espera

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                btSubmit.Click();
                Maps.VerificarItem(txtError, "APPLICATION ERROR #11", "");
                Maps.VerificarItem(ltReportIssue, "Report Issue", "");
                


            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }







        public void InserirTarefa()
        {
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();


            Maps.CBClick(cbCategory, "category_id", "[All Projects] app_14");
            Maps.CBClick(cbReproducibility, "reproducibility", "always");
            Maps.CBClick(cbSeverity, "severity", "feature");
            Maps.CBClick(cbSeverity, "priority", "none");
            Maps.CBClick(cbSeverity, "profile_id", "Desktop Windows 10");
            Maps.PreencherCampo(tfPlatform, "platform", "teste1");
            Maps.PreencherCampo(tfOs, "os", "teste2");
            Maps.PreencherCampo(tfOs_Build, "os_build", "teste3");
            Maps.CBClick(cbHandler, "handler_id", "administrator");
            Maps.PreencherCampo(tfSummary, "summary", "TESTE_SUMMARY");
            Maps.PreencherCampo(tfdDescription, "description", "teste4");
            Maps.PreencherCampo(tfSteps, "steps_to_reproduce", "teste4");
            Maps.PreencherCampo(tfAdditional, "additional_info", "teste4");




            _driver.FindElement(By.XPath("(//input[@name='view_state'])[2]")).Click();
            _driver.FindElement(By.Name("view_state")).Click();
            _driver.FindElement(By.XPath("//input[@value='Submit Report']")).Click();


        }

        public String InserirTarefa_RetornoSummary()
        {
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            GerarRandom gerarRandom = new GerarRandom();
            String summary = gerarRandom.RandomString();


            Maps.CBClick(cbCategory, "category_id", "[All Projects] app_14");
            Maps.CBClick(cbReproducibility, "reproducibility", "N/A");
            Maps.CBClick(cbPriority, "priority", "none");

            Maps.PreencherCampo(tfPlatform, "platform", "teste1");
            Maps.PreencherCampo(tfOs, "os", "teste2");
            Maps.PreencherCampo(tfOs_Build, "os_build", "teste3");
            Maps.CBClick(cbHandler, "handler_id", "administrator");
            Maps.PreencherCampo(tfSummary, "summary", summary);
            Maps.PreencherCampo(tfdDescription, "description", "teste4");
            Maps.PreencherCampo(tfSteps, "steps_to_reproduce", "teste4");
            Maps.PreencherCampo(tfAdditional, "additional_info", "teste4");
            Maps.ClicarBotao(btSubmit);
            

            return summary;
        }

        public void InserirIssue_Simple(string category, string reproducibility, string severity, string priority, string summary, string description)
        {
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            

            //dinamico
            Maps.CBClick(cbCategory, "category_id", category);
            Maps.CBClick(cbReproducibility, "reproducibility", reproducibility);
            Maps.CBClick(cbSeverity, "severity", severity);
            Maps.CBClick(cbPriority, "priority", priority);
            Maps.PreencherCampo(tfSummary, "summary", summary);
            Maps.PreencherCampo(tfdDescription, "description", description);

            //estático
            
            Maps.CBClick(cbProfile, "profile_id", "Desktop Windows 10");
            Maps.PreencherCampo(tfPlatform, "platform", "teste1");
            Maps.PreencherCampo(tfOs, "os", "teste2");
            Maps.PreencherCampo(tfOs_Build, "os_build", "teste3");
            Maps.CBClick(cbHandler, "handler_id", "administrator");
            Maps.PreencherCampo(tfSteps, "steps_to_reproduce", "teste4");
            Maps.PreencherCampo(tfAdditional, "additional_info", "teste4");


            _driver.FindElement(By.XPath("(//input[@name='view_state'])[2]")).Click();
            _driver.FindElement(By.Name("view_state")).Click();
            _driver.FindElement(By.XPath("//input[@value='Submit Report']")).Click();

            
        }


        public void InserirTarefa(DataDriven dataDriven)
        {
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            string[] dados = dataDriven.filldatafromCsv();


            Maps.CBClick(cbCategory, "category_id", dados[0]);
            Maps.CBClick(cbReproducibility, "reproducibility", dados[1]);
            Maps.CBClick(cbSeverity, "severity", "feature");
            Maps.CBClick(cbSeverity, "priority", "none");
            Maps.CBClick(cbSeverity, "profile_id", "Desktop Windows 10");
            Maps.PreencherCampo(tfPlatform, "platform", "teste1");
            Maps.PreencherCampo(tfOs, "os", "teste2");
            Maps.PreencherCampo(tfOs_Build, "os_build", "teste3");
            Maps.CBClick(cbHandler, "handler_id", "administrator");
            Maps.PreencherCampo(tfSummary, "summary", "TESTE_SUMMARY");
            Maps.PreencherCampo(tfdDescription, "description", "teste4");
            Maps.PreencherCampo(tfSteps, "steps_to_reproduce", "teste4");
            Maps.PreencherCampo(tfAdditional, "additional_info", "teste4");


            //Maps.CBClick(cbCategory, "category_id", "[All Projects] app_14");
            //Maps.CBClick(cbReproducibility, "reproducibility", dados[0]);
            //Maps.CBClick(cbSeverity, "severity", "feature");
            //Maps.CBClick(cbSeverity, "priority", "none");
            //Maps.CBClick(cbSeverity, "profile_id", "Desktop Windows 10");
            //Maps.PreencherCampo(tfPlatform, "platform", "teste1");
            //Maps.PreencherCampo(tfOs, "os", "teste2");
            //Maps.PreencherCampo(tfOs_Build, "os_build", "teste3");
            //Maps.CBClick(cbHandler, "handler_id", "administrator");
            //Maps.PreencherCampo(tfSummary, "summary", "teste4");
            //Maps.PreencherCampo(tfdDescription, "description", "teste4");
            //Maps.PreencherCampo(tfSteps, "steps_to_reproduce", "teste4");
            //Maps.PreencherCampo(tfAdditional, "additional_info", "teste4");

            _driver.FindElement(By.XPath("(//input[@name='view_state'])[2]")).Click();
            _driver.FindElement(By.Name("view_state")).Click();
            _driver.FindElement(By.XPath("//input[@value='Submit Report']")).Click();


        }

        public String PegarIssueInserida(String summary)
        {
            //Após inserir uma issue aparece uma tela rapidamente informando o ID da issue

            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {

                Maps.ClicarBotao(LtViewIssues, "");
                Maps.LimparCampo(tfSearch);
                Maps.PreencherCampo(tfSearch, "", summary);
                Maps.ClicarBotao(btFilter, "");
                Maps.ClicarBotao(btPicFilter, "");


                String URL = _driver.Url; //pegar a URL 
                ID = URL.Substring(URL.Length - 4); //tratamento da URL que contem o ID


            }
            catch (Exception e)
            {




            }







            return ID;
        }

        public void AcessarEdicaoIssue(String summary)
        {
            //Após inserir uma issue aparece uma tela rapidamente informando o ID da issue

            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {

                Maps.ClicarBotao(LtViewIssues, "");
                Maps.LimparCampo(tfSearch);
                Maps.PreencherCampo(tfSearch, "", summary);
                Maps.ClicarBotao(btFilter, "");
                Maps.ClicarBotao(btPicFilter, "");


            }
            catch (Exception e)
            {




            }


        }

        public void AcessarEdicaoIssue_TelaPosBuscarID()
        {
            //Após inserir uma issue aparece uma tela rapidamente informando o ID da issue

            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {

                Maps.ClicarBotao(btEdit,"");


            }
            catch (Exception e)
            {




            }


        }



    }
}
    
