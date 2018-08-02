using Microsoft.VisualStudio.TestTools.UnitTesting;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Test;

namespace ProjetoSomar.SeleniumPageObjects
{
    class ViewIssuesPageObjects : WebDriver
    {

        public ViewIssuesPageObjects()
         {
            PageFactory.InitElements(WebDriver._driver, this);
        }


        [FindsBy(How = How.ClassName, Using = "left")]
        public IWebElement txtSummary { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='buglist']/tbody/tr[4]/td[11]")]
        public IWebElement ltIssueInserida { get; set; }

        [FindsBy(How = How.Id, Using = "reporter_id_filter")]
        public IWebElement ltReporter { get; set; }

        [FindsBy(How = How.XPath, Using = "//p")]
        public IWebElement txtPermaLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Create Permalink")]
        public IWebElement ltPermalink { get; set; }

        [FindsBy(How = How.Name, Using = "search")]
        public IWebElement tfSearch { get; set; }

        [FindsBy(How = How.Name, Using = "filter")]
        public IWebElement btFilter { get; set; }

        [FindsBy(How = How.Name, Using = "show_priority[]")]
        public IWebElement cbPriority { get; set; }

        [FindsBy(How = How.Name, Using = "filter")]
        public IWebElement btFilterPageFilter { get; set; }

        [FindsBy(How = How.Id, Using = "reporter_id_filter")]
        public IWebElement btFilterPage { get; set; }

        [FindsBy(How = How.Name, Using = "action")]
        public IWebElement cbActionsIssues { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='OK']")]
        public IWebElement btOk { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Delete Issues']")]
        public IWebElement btConfirmDelete { get; set; }

        [FindsBy(How = How.XPath, Using =  "//input[@value='Assign Issues']")]
        public IWebElement btConfirmAssign { get; set; }

        [FindsBy(How = How.Name, Using = "assign")]
        public IWebElement cbAssign { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='buglist']/tbody/tr/td/span")]
        public IWebElement bugList { get; set; }

        [FindsBy(How = How.XPath, Using = "//p")]
        public IWebElement permalink { get; set; }

        //Assert.IsTrue(Regex.IsMatch(_driver.FindElement(By.XPath("//p")).Text, "Following is a permanent link to the currently configured filter:"));
        
        public void FiltrarIssue_Prioridade(String prioridade)
        {

            SeleniumMaps Maps = new SeleniumMaps();

            //Problemas com o CB, ele não está identificando o objeto
            Maps.CBClick(cbPriority, prioridade, prioridade);
            Maps.ClicarBotao(btFilterPageFilter, ""); 



        }

        public void AcessoFiltrar()
        {

            SeleniumMaps Maps = new SeleniumMaps();
            Maps.ClicarBotao(btFilterPage);
        }

        public void VerificarAcessoFiltrar()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            Maps.VerificarItem(btFilterPageFilter,"", "");

        }


        public void VerificarInsercao_Issue()
        {

            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
            SeleniumMaps Maps = new SeleniumMaps();
            HomePageObjects homePageObjects = new HomePageObjects();
            DataDriven data = new DataDriven();
           
            //veriricar espera

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {

                //Maps.VerificarItem(ltIssueInserida, data.);
                //Console.WriteLine(_driver.FindElement(By.LinkText("Report Issue")).Text);
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void VerificaAcessoViewIssues()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
            //espera.Until(ExpectedConditions.ElementToBeClickable(ltCategory));
            //método try catch para validar se foi possível acessar a tela inicial
            try
            {

                //Assert.AreEqual("Reporter:", ltReporter.Text);
                //Assert.AreEqual("Reporter:", _driver.FindElement(By.Id("reporter_id_filter")).Text);
                Maps.VerificarItem(ltReporter, "Reporter:", "");
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        public void SelecionarTudo()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
            //método try catch para validar se foi possível acessar a tela inicial
            int indice = 2;
            
            //Numero de Issues
            //Pega o campo da tela e joga numa string
            
            //****NECESSARIO VALIDAR QUANDO FOR VAZIO
            String tamanho = _driver.FindElement(By.XPath("//table[@id='buglist']/tbody/tr/td/span")).Text;
            tamanho = tamanho.Substring(tamanho.Length - 9); //Pegar até o indice
            tamanho = tamanho.Substring(0,2); //Retira o resto de informações inúteis
            int NIssues = Convert.ToInt32(tamanho); //Casting explicito
            


            try
            {
                if (NIssues == 1) //quando tiver só um
                {
                    //primeira linha é diferente 
                    _driver.FindElement(By.Name("bug_arr[]")).Click();
                }
                else if (NIssues > 1)
                { //quando tiver mais que um

                    //primeira linha sempre é diferente 
                    _driver.FindElement(By.Name("bug_arr[]")).Click();

                    //percorre procurando um a um
                    while (indice < NIssues)
                    {
                        _driver.FindElement(By.XPath("(//input[@name='bug_arr[]'])[" + indice + "]")).Click();
                        indice++;
                    }

                }
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }


        public void Excluir()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));


            Maps.CBClick(cbActionsIssues, "action", "Delete");
            Maps.ClicarBotao(btOk);
            Maps.ClicarBotao(btConfirmDelete);
        }

        public void AtribuirSayoan()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));


            Maps.CBClick(cbActionsIssues, "action", "Assign");
            Maps.ClicarBotao(btOk);

         
            Maps.CBClick(cbAssign, "assign", "sayoan.oliveira");
            Maps.ClicarBotao(btConfirmAssign);
        }


        public void VerificaPermalink()
    {
        SeleniumMaps Maps = new SeleniumMaps();
        WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

        //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                //trocar de aba
                var browserTabs = _driver.WindowHandles;
                _driver.SwitchTo().Window(browserTabs[1]);
                Assert.IsTrue(Regex.IsMatch(_driver.FindElement(By.XPath("//p")).Text, "Following is a permanent link to the currently configured filter:"));
                //Maps.VerificarItem(permalink, "Following is a permanent link to the currently configured filter:", "");

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

    }

        public void AcessarPermalink()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                //_driver.FindElement(By.LinkText("Create Permalink")).Click();
                Maps.ClicarBotao(ltPermalink,"Create Permalink"); 


            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }

        
        

        public void FiltrarSemRetorno()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.PreencherCampo(tfSearch, "*", "*");
                Maps.ClicarBotao(btFilter,"");
                
                Maps.VerificarItem(bugList, "Viewing Issues (0 - 0 / 0)", "");

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }


    }
}
