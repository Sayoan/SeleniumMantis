using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoSomar.SeleniumComum;
using ProjetoSomar.SeleniumUteis;
using SeleniumMantis.SeleniumComum;
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
            PageFactory.InitElements(DriverFactory.INSTANCE, this);
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

        [FindsBy(How = How.Id, Using = "show_priority_filter_target")]
        public IWebElement txtFiltroPriority { get; set; }

        [FindsBy(How = How.Id, Using = "show_severity_filter_target")]
        public IWebElement txtFiltroSeverity { get; set; }

        [FindsBy(How = How.Name, Using = "show_severity[]")]
        public IWebElement cbSeverity { get; set; }

        [FindsBy(How = How.LinkText, Using = "Create Short Link")]
        public IWebElement txtPermalink2 { get; set; }

        [FindsBy(How = How.Name, Using = "bug_arr[]")]
        public IWebElement checkboxIssue { get; set; }

        [FindsBy(How = How.LinkText, Using = "sayoan.oliveira")]
        public IWebElement txtVerificaAssignSayoan { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='buglist']/tbody/tr/td/span")]
        public IWebElement txtQuantidadeIssues { get; set; }

        [FindsBy(How = How.Id, Using = "show_priority_filter")]
        public IWebElement ltFiltroPriority { get; set; }

        [FindsBy(How = How.Id, Using = "show_severity_filter")]
        public IWebElement ltFiltroSeverity { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='app_14'])[1]/following::td[1]")]
        public IWebElement txtFiltroSeverityTabela { get; set; }
        



        public void FiltrarIssue_Prioridade(String prioridade)
        {

            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            Uteis.ClicarBotao(ltFiltroPriority, "");
            Uteis.CBClick(cbPriority, prioridade, prioridade);
            Uteis.ClicarBotao(btFilterPageFilter, ""); 



        }

        public void FiltrarIssue_Severity(String severity)
        {

            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            Uteis.ClicarBotao(ltFiltroSeverity, "");
            Uteis.CBClick(cbSeverity, "", severity);
            Uteis.ClicarBotao(btFilterPageFilter, "");



        }

        public void ValidarFiltroSeverity(String severity)
        {

            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            Uteis.VerificarItem(txtFiltroSeverityTabela, severity, "");



        }

        public void ValidacaoFiltroTarefa_Priority (String prioridade)
        {

            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();

            Uteis.VerificarItem(txtFiltroPriority, prioridade, "");



        }

        public void ValidacaoFiltroTarefa_Severity(String severity)
        {

            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();

            Uteis.VerificarItem(txtFiltroSeverity, severity, "");



        }


        public void AcessoFiltrar()
        {

            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            Uteis.ClicarBotao(btFilterPage);
        }

        public void VerificarAcessoFiltrar()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            Uteis.VerificarItem(btFilterPageFilter,"", "");

        }


        public void VerificarInsercao_Issue()
        {

            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            HomePageObjects homePageObjects = new HomePageObjects();
            
           
            

            //método try catch para validar se foi possível acessar a tela inicial
          

        }

        public void VerificaAcessoViewIssues()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
              //método try catch para validar se foi possível acessar a tela inicial
           

                    Uteis.VerificarItem(ltReporter, "Reporter:", "");
           

        }

        public void SelecionarTudo()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            //método try catch para validar se foi possível acessar a tela inicial
            int indice = 2;

            //Numero de Issues
            //Pega o campo da tela e joga numa string

            //****DAQUI PRA BAIXO EXISTE ALTO RISCO DE ENCONTRAR UMA GAMBIRA****
            String tamanho = txtQuantidadeIssues.Text;
            //sintaxe (0 - 0 / 0)  
            String[] parts = tamanho.Split('/'); //separar em relação ao '/'
            String[] parts2 = parts[0].Split('-'); //pega a direita do '-'
                  
            int NIssues = Convert.ToInt32(parts2[1]); //Casting explicito
            


            try
            {
             
                if (NIssues == 1) //quando tiver só um
                {
                    //primeira linha é diferente 
                    Uteis.ClicarBotao(checkboxIssue);
                }
                else if (NIssues > 1)
                { //quando tiver mais que um

                    //primeira linha sempre é diferente 
                    Uteis.ClicarBotao(checkboxIssue);

                    NIssues++;//necessário para escolher o ultimo

                    //percorre procurando um a um
                    while (indice < NIssues)
                    {
                        DriverFactory.INSTANCE.FindElement(By.XPath("(//input[@name='bug_arr[]'])[" + indice + "]")).Click();
                        indice++;
                    }
                    
                }
            }
            catch (Exception e)
            {
                //NÃO EXISTEM TAREFAS PARA ATRIBUIR
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void VerificaZero()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            String tamanho = txtQuantidadeIssues.Text;
            String[] parts = tamanho.Split('/'); //separar em relação ao '/'
            String[] parts2 = parts[0].Split('-'); //pega a direita do '-'

            int NIssues = Convert.ToInt32(parts2[1]); //Casting explicito

            if (NIssues == 0)
            {
                NUnit.Framework.Assert.IsTrue(true);

            }
            else
            {
                NUnit.Framework.Assert.Fail();
            }

        }



        public void Excluir()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));


            Uteis.CBClick(cbActionsIssues, "action", "Delete");
            Uteis.ClicarBotao(btOk);
            Uteis.ClicarBotao(btConfirmDelete);
        }

        public void VerificaAtribuicaoSayoan()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));


            Uteis.VerificarItem(txtVerificaAssignSayoan, "sayoan.oliveira", "");
        }

        public void AtribuirSayoan()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));


            Uteis.CBClick(cbActionsIssues, "action", "Assign");
            Uteis.ClicarBotao(btOk);

         
            Uteis.CBClick(cbAssign, "assign", "sayoan.oliveira");
            Uteis.ClicarBotao(btConfirmAssign);
        }


        public void VerificaPermalink()
    {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
        WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

        //método try catch para validar se foi possível acessar a tela inicial
          
                //trocar de aba
                var browserTabs = DriverFactory.INSTANCE.WindowHandles;
                DriverFactory.INSTANCE.SwitchTo().Window(browserTabs[1]);
                Uteis.VerificarItem(txtPermalink2, "Create Short Link", "");



    }

        public void AcessarPermalink()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
                //_driver.FindElement(By.LinkText("Create Permalink")).Click();
                Uteis.ClicarBotao(ltPermalink,"Create Permalink"); 


           

        }

        
        

        public void FiltrarSemRetorno()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
          
                Uteis.PreencherCampo(tfSearch, "*", "*");
                Uteis.ClicarBotao(btFilter,"");
                
                Uteis.VerificarItem(bugList, "Viewing Issues (0 - 0 / 0)", "");

           

        }


    }
}
