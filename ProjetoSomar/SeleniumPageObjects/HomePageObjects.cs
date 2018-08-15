using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjetoSomar.SeleniumUteis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoSomar.SeleniumComum;

namespace Test
{
    class HomePageObjects : WebDriver
    {
        public HomePageObjects()
        {
            PageFactory.InitElements(WebDriver._driver, this);
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
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.CBClick(cbProjeto, "", Credentials.Projeto);
                //NUnit.Framework.Assert.AreEqual("Sayoan Oliveira's", _driver.FindElement(By.Name("project_id")).Text);

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void EscolherProjeto(String projeto)
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.CBClick(cbProjeto, "project_id", projeto);
                //NUnit.Framework.Assert.AreEqual("Sayoan Oliveira's", _driver.FindElement(By.Name("project_id")).Text);
                //PROJETO ESCOLHIDO COM SUCESSO
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void AcessarAbaReportIssue()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

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
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

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
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                //NUnit.Framework.Assert.AreEqual("My View", ltMyView.Text);
                Maps.VerificarItem(ltMyView, "My View", "");
               // NUnit.Framework.Assert.AreEqual("My View", _driver.FindElement(By.LinkText("My View")).Text);
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void AcessarAbaViewIssue()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

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
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

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
          
                //Assert.AreEqual("A number was expected for bug_id.", _driver.FindElement(By.XPath("//p")).Text);

            }
            catch (Exception e)
            {

            }
        }

        public void Verifica_IssueVazia()
        {
            SeleniumMaps Maps = new SeleniumMaps();
          
          

                Maps.VerificarItem(tfErro, "A number was expected for bug_id.", "");
                //Assert.AreEqual("A number was expected for bug_id.", _driver.FindElement(By.XPath("//p")).Text);

           
        }


        public void ProcurarIssue(string ID)
        {
            SeleniumMaps Maps = new SeleniumMaps();
            try
            {

                Maps.PreencherCampo(tfBugId, "", ID);
                Maps.ClicarBotao(btJump);
                //Assert.AreEqual("A number was expected for bug_id.", _driver.FindElement(By.XPath("//p")).Text);

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
                //Assert.AreEqual("A number was expected for bug_id.", _driver.FindElement(By.XPath("//p")).Text);

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

