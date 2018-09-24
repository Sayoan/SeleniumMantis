using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using ProjetoSomar.SeleniumComum;
using ProjetoSomar.SeleniumPageObjects;
using ProjetoSomar.SeleniumUteis;
using SeleniumMantis.SeleniumComum;
using SeleniumWebDriver.Basics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ProjetoSomar.SeleniumTests
{
    class IssueTests : WebDriver
    {
               
        [Test]
        [Category("CT")]
        public void Issue_InsertIssuee_AlterarStatus()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
           

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();//Aqui você o sumário inserido
            reportIssuesPageObjects.AcessarEdicaoIssue(summary);

            updateIssuePageObjects.AlterarStatus("confirmed");
            updateIssuePageObjects.Atualizar();
            
           
        }

        [Test]
        [Category("CT")]
        public void Issue_InsertIssuee_AtribuirTarefa()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
           

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();//Aqui você o sumário inserido
            reportIssuesPageObjects.AcessarEdicaoIssue(summary);

            /*
             * feedback acknowledged confirmed assigned resolved closed
             * 
             */
            updateIssuePageObjects.AtribuirTarefa("sayoan.oliveira");
            updateIssuePageObjects.Atualizar();
            updateIssuePageObjects.VerificaAssign("sayoan.oliveira");
            Assert.Pass();


        }

        [Test]
        [Category("CT")]
        public void Issue_InsertIssuee_AlterarResolution()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();//Aqui você o sumário inserido
            reportIssuesPageObjects.AcessarEdicaoIssue(summary);

            updateIssuePageObjects.AlterarResolution("no change required");
            updateIssuePageObjects.Atualizar();
            Assert.Pass();
        }

        [Test]
        [Category("CT")]
        public void Issue_InsertIssuee_FecharTarefaDuplicada()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();//Aqui você o sumário inserido
            reportIssuesPageObjects.AcessarEdicaoIssue(summary);

            updateIssuePageObjects.AlterarResolution("duplicate");
            updateIssuePageObjects.AlterarStatus("closed");
            updateIssuePageObjects.AtribuirNota("Tarefa Duplicada");
            updateIssuePageObjects.Atualizar();

            updateIssuePageObjects.VerificaStatus("closed");
            Assert.Pass();
        }

        [Test]
        [Category("CT")]
        public void Issue_InsertIssuee_FecharTarefa()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            
            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();//Aqui você o sumário inserido
            reportIssuesPageObjects.AcessarEdicaoIssue(summary);

            updateIssuePageObjects.AlterarStatus("closed");
            updateIssuePageObjects.Atualizar();

            updateIssuePageObjects.VerificaStatus("closed");
            Assert.Pass();
        }


        [Test]
        [Category("CT")]
        public void Issue_InsertIssuee_AlterarStatusFeedback()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();//Aqui você o sumário inserido
            reportIssuesPageObjects.AcessarEdicaoIssue(summary);

            updateIssuePageObjects.AlterarStatus("acknowledged");
            updateIssuePageObjects.Atualizar();
            updateIssuePageObjects.VerificaStatus("acknowledged");
            Assert.Pass();


        }

        [Test]
        [Category("CT")]
        public void Issue_InsertIssuee_FecharTarefaSemReproducao()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
         
            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();//Aqui você o sumário inserido
            reportIssuesPageObjects.AcessarEdicaoIssue(summary);

            updateIssuePageObjects.AlterarReprodutibilidade("unable to reproduce");
            updateIssuePageObjects.AtribuirNota("Impossível de reproduzir.");
            updateIssuePageObjects.AlterarStatus("closed");
            updateIssuePageObjects.Atualizar();

            updateIssuePageObjects.VerificaStatus("closed");
            Assert.Pass();
        }


       
        

        [Test]
        [Category("CT")]
        public void Issue_InsertIssuee_AlterarPriority()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
         
            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();//Aqui você o sumário inserido
            reportIssuesPageObjects.AcessarEdicaoIssue(summary);

            updateIssuePageObjects.AlterarPriority("urgent");
            updateIssuePageObjects.Atualizar();
            updateIssuePageObjects.VerificaPriority("urgent");
            Assert.Pass();


        }

       

       

        [Test]
        [Category("CT")]
        public void Issue_BuscarIssueInexistente()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            String ID = "9999999";
           

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();
            homePageObjects.VerificaProjeto();
            homePageObjects.ProcurarIssue(ID);
            homePageObjects.ValidacaoIssueInexiste(ID);
            Assert.Pass();



        }


        [Test]
        [Category("CT")]
        public void Issue_InsertIssuee_VerificaID()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            
            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();//Aqui você o sumário inserido
            //neste momento é inserido uma tarefa com uma summary random e ela é retornada para ser utilizada na busca
            String ID = reportIssuesPageObjects.PegarIssueInserida(summary); //Aqui consegue o ID com o sumário
            Assert.Pass();


        }



        //[Test]
        public void Issue_InsertIssue_VerificarInsert()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();
            


            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            reportIssuesPageObjects.InserirTarefa();


            viewIssuesPageObjects.VerificarInsercao_Issue();
            Assert.Pass();

        }

        [Test]
        [Category("CT")]
        public void Issue_VerificaAcessoReportIssue()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();
          
            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            Assert.Pass();
        }

        [Test]
        [Category("CT")]
        public void Issue_VerificarCampoObrigatorio()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            reportIssuesPageObjects.VerificarCampoObrigatorio();
            Assert.Pass();
        }

       



 

       
    


        [Test]
        [Category("CT")]
            public void Issue_GerarPermalink()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.AcessarAbaViewIssue();

            viewIssuesPageObjects.VerificaAcessoViewIssues();
            viewIssuesPageObjects.AcessarPermalink(); //Clicar botão Permalink
            viewIssuesPageObjects.VerificaPermalink(); //Trocar de aba e verificar Tela
            Assert.Pass();


        }

        [Test]
        [Category("CT")]
        public void Issue_FiltrarSemRetorno()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.AcessarAbaViewIssue();

            viewIssuesPageObjects.VerificaAcessoViewIssues();
            viewIssuesPageObjects.FiltrarSemRetorno();
            Assert.Pass();





        }


        [Test]
        [Category("CT")]
        public void Issue_ExclusaoTotal()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.AcessarAbaReportIssue();
            reportIssuesPageObjects.VerificarAcessaReportIssue();
            //Obriga inserir uma tarefa e verifica se foi excluída
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();

            homePageObjects.AcessarAbaViewIssue();

            viewIssuesPageObjects.VerificaAcessoViewIssues();
            viewIssuesPageObjects.SelecionarTudo();
            viewIssuesPageObjects.Excluir();

            viewIssuesPageObjects.VerificaZero();
            Assert.Pass();




        }


        [Test]
        [Category("CT")]
        public void Issue_AtribuirSayoan()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            //Obriga inserir uma tarefa
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();

            homePageObjects.AcessarAbaViewIssue();

            viewIssuesPageObjects.VerificaAcessoViewIssues();

            //Aplicar filtro
            viewIssuesPageObjects.SelecionarTudo();
            viewIssuesPageObjects.AtribuirSayoan();
            viewIssuesPageObjects.VerificaAtribuicaoSayoan();
            Assert.Pass();




        }
        /// <summary>
        /// TESTES ENVOLVENDO DD
        /// Inserir uma tarefa com 6 parâmetros dinâmicos e o restante estático
        /// </summary>
        /// 

        [Category("DataDriven"), TestCaseSource("InsercaoIssues")]
        public void Issue_DD_InsertSimple(ArrayList ItemList)
        {
            //receber 6 parâmetros pelo DD e gerar os CT
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();


            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            reportIssuesPageObjects.InserirIssue_Simple(ItemList);
            Assert.Pass();
        }

        public static List<TestCaseData> InsercaoIssues
        {
           
            get
            {
                DataDriven datadriven = new DataDriven();
                var testCases = datadriven.DataDrivenImplement();
                return testCases;
            }
        }

    

      
    }
}





