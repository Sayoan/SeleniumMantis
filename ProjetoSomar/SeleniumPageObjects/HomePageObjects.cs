using SeleniumWebDriver.Basics;
using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjetoSomar.SeleniumUteis;
using ProjetoSomar.SeleniumComum;
using System.Configuration;
using SeleniumMantis.SeleniumComum;

namespace Test
{
    class HomePageObjects : WebDriver
    {
        public HomePageObjects()
        {
            PageFactory.InitElements(DriverFactory.INSTANCE, this);
        }


        [FindsBy(How = How.Name, Using = "project_id")]
        public IWebElement  cbProjeto { get; set; }

        [FindsBy(How = How.LinkText, Using = "Report Issue")]
        public IWebElement ltIssue { get; set; }

        internal void EscolherProjeto(object projeto)
        {
            throw new NotImplementedException();
        }

        [FindsBy(How = How.LinkText, Using = "My View")]
        public IWebElement ltMyView { get; set; }

        [FindsBy(How = How.LinkText, Using = "View Issues")]
        public IWebElement ltViewIssues { get; set; }

        [FindsBy(How = How.LinkText, Using = "Report Issue")]
        public IWebElement ltReportIssue { get; set; }
    
        [FindsBy(How = How.LinkText, Using = "Change Log")]
        public IWebElement ltChangeLog { get; set; }

        [FindsBy(How = How.LinkText, Using = "Roadmap")]
        public IWebElement ltRoadmap { get; set; }

        [FindsBy(How = How.LinkText, Using = "Summary")]
        public IWebElement ltSummary { get; set; }

        [FindsBy(How = How.LinkText, Using = "Manage")]
        public IWebElement ltManage { get; set; }

        [FindsBy(How = How.LinkText, Using = "My Account")]
        public IWebElement ltMyAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "Logout")]
        public IWebElement ltLogout { get; set; }

        [FindsBy(How = How.Name, Using = "bug_id")]
        public IWebElement tfBugId { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Jump']")]
        public IWebElement btJump { get; set; }

        [FindsBy(How = How.XPath, Using = "//p")]
        public IWebElement tfErro { get; set; }

        public String Projeto = "SayoanOliveira";



        public void VerificaProjeto()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.CBClick(cbProjeto, "", ConfigurationManager.AppSettings["Projeto"].ToString());
             

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void EscolherProjeto(String projeto)
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.CBClick(cbProjeto, "project_id", projeto);
                
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void AcessarAbaReportIssue()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.ClicarBotao(ltIssue, "Report Issue");
               
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void AcessarAbaSummary()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.ClicarBotao(ltSummary, "Summary");

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void VerificarAcessaLogin()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
           
                Maps.VerificarItem(ltMyView, "My View", "");
           
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void AcessarAbaViewIssue()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.ClicarBotao(ltViewIssues, "View Issue");

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }


        public void AcessarAbaManage()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.ClicarBotao(ltManage, "Manage");

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }





        public void AcessarAbaMyView()
            {
                SeleniumMaps Maps = new SeleniumMaps();
                try
                {
                  Maps.ClicarBotao(ltMyView, "My View");

                }
                catch (Exception e)
                {

                }
            }

        public void AcessarAbaMyAccount()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            try
            {
                Maps.ClicarBotao(ltMyAccount, "My Account");

            }
            catch (Exception e)
            {

            }
        }

        public void ProcurarIssue_Vazia()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            try
            {
                
                Maps.LimparCampo(tfBugId);
                Maps.ClicarBotao(btJump);
          
            }
            catch (Exception e)
            {

            }
        }

        public void Verifica_IssueVazia()
        {
            SeleniumMaps Maps = new SeleniumMaps();
          
          

                Maps.VerificarItem(tfErro, "A number was expected for bug_id.", "");
               
           
        }


        public void ProcurarIssue(string ID)
        {
            SeleniumMaps Maps = new SeleniumMaps();
            try
            {

                Maps.PreencherCampo(tfBugId, "", ID);
                Maps.ClicarBotao(btJump);
              
            }
            catch (Exception e)
            {

            }
        }

        public void ValidacaoIssueInexiste(string ID)
        {
            SeleniumMaps Maps = new SeleniumMaps();
            try
            {
                
                String texto = "Issue " + ID + " not found.";
                Maps.VerificarItem(tfErro, texto, "");
                
            }
            catch (Exception e)
            {

            }
        }
        public void Logout()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            try
            {
                Maps.ClicarBotao(ltLogout, "");

            }
            catch (Exception e)
            {

            }
        }

        


    }



    




}

