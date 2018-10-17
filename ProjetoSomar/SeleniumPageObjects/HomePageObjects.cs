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
            SeleniumUteis Uteis = new SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
                Uteis.CBClick(cbProjeto, "", ConfigurationManager.AppSettings["Projeto"].ToString());
             

            
           

        }

        public void EscolherProjeto(String projeto)
        {
            SeleniumUteis Uteis = new SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
                Uteis.CBClick(cbProjeto, "project_id", projeto);
                
           

        }

        public void AcessarAbaReportIssue()
        {
            SeleniumUteis Uteis = new SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
                Uteis.ClicarBotao(ltIssue, "Report Issue");
               
            

        }

        public void AcessarAbaSummary()
        {
            SeleniumUteis Uteis = new SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
                Uteis.ClicarBotao(ltSummary, "Summary");

            
        }

        public void VerificarAcessaLogin()
        {
            SeleniumUteis Uteis = new SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
           
                Uteis.VerificarItem(ltMyView, "My View", "");
           
            
            

        }

        public void AcessarAbaViewIssue()
        {
            SeleniumUteis Uteis = new SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            
                Uteis.ClicarBotao(ltViewIssues, "View Issue");


        }


        public void AcessarAbaManage()
        {
            SeleniumUteis Uteis = new SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
                Uteis.ClicarBotao(ltManage, "Manage");

           

        }





        public void AcessarAbaMyView()
            {
                SeleniumUteis Uteis = new SeleniumUteis();
               
                  Uteis.ClicarBotao(ltMyView, "My View");

                
            }

        public void AcessarAbaMyAccount()
        {
            SeleniumUteis Uteis = new SeleniumUteis();
            
                Uteis.ClicarBotao(ltMyAccount, "My Account");

           
        }

        public void ProcurarIssue_Vazia()
        {
            SeleniumUteis Uteis = new SeleniumUteis();
            
                Uteis.LimparCampo(tfBugId);
                Uteis.ClicarBotao(btJump);
          
           
        }

        public void Verifica_IssueVazia()
        {
            SeleniumUteis Uteis = new SeleniumUteis();
          
          

                Uteis.VerificarItem(tfErro, "A number was expected for bug_id.", "");
               
           
        }


        public void ProcurarIssue(string ID)
        {
            SeleniumUteis Uteis = new SeleniumUteis();
           

                Uteis.PreencherCampo(tfBugId, "", ID);
                Uteis.ClicarBotao(btJump);
              
           
        }

        public void ValidacaoIssueInexiste(string ID)
        {
            SeleniumUteis Uteis = new SeleniumUteis();
           
                
                String texto = "Issue " + ID + " not found.";
                Uteis.VerificarItem(tfErro, texto, "");
                
           
        }
        public void Logout()
        {
            SeleniumUteis Uteis = new SeleniumUteis();
          
                Uteis.ClicarBotao(ltLogout, "");

           
        }

        


    }



    




}

