using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using ProjetoSomar.SeleniumComum;
using ProjetoSomar.SeleniumPageObjects;
using ProjetoSomar.SeleniumUteis;
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
       // [Category("Producao"), TestCaseSource("ConfiguracaoInstituicoes")]
         // [Test]
        public void Issue_InsertIssuee()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            //DataDriven dataDriven = new DataDriven();

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            reportIssuesPageObjects.InserirTarefa();
           
        }
        
        [Test]
        [Category("Revisados")]
        public void Issue_InsertIssuee_AlterarStatus()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            //DataDriven dataDriven = new DataDriven();

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
            updateIssuePageObjects.AlterarStatus("confirmed");
            updateIssuePageObjects.Atualizar();
            //Assert.AreEqual("confirmed", _driver.FindElement(By.XPath("//tr[8]/td[2]")).Text);
           
        }

        [Test]
        [Category("Doing")]
        public void Issue_InsertIssuee_AtribuirTarefa()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            //DataDriven dataDriven = new DataDriven();

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
            //Assert.AreEqual("confirmed", _driver.FindElement(By.XPath("//tr[8]/td[2]")).Text);

        }

        [Test]
        [Category("Revisados")]
        public void Issue_InsertIssuee_AlterarResolution()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            //DataDriven dataDriven = new DataDriven();

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
            updateIssuePageObjects.AlterarResolution("no change required");
            updateIssuePageObjects.Atualizar();
        }

        [Test]
        [Category("Doing")]
        public void Issue_InsertIssuee_FecharTarefaDuplicada()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            //DataDriven dataDriven = new DataDriven();

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
            updateIssuePageObjects.AlterarResolution("duplicate");
            updateIssuePageObjects.AlterarStatus("close");
            updateIssuePageObjects.Atualizar();
        }

        [Test]
        [Category("Doing")]
        public void Issue_InsertIssuee_FecharTarefa()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            //DataDriven dataDriven = new DataDriven();

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
            updateIssuePageObjects.AlterarStatus("close");
            updateIssuePageObjects.Atualizar();
        }


        [Test]
        [Category("Doing")]
        public void Issue_InsertIssuee_AlterarStatusFeedback()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            //DataDriven dataDriven = new DataDriven();

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
            updateIssuePageObjects.AlterarStatus("feedback");
            updateIssuePageObjects.Atualizar();
        }

        [Test]
        [Category("Doing")]
        public void Issue_InsertIssuee_AlterarPriority()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            //DataDriven dataDriven = new DataDriven();

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
            updateIssuePageObjects.AlterarPriority("urgent");
            updateIssuePageObjects.Atualizar();
        }

        [Test]
        [Category("Doing")]
        public void Issue_InsertIssuee_AnotarPrioridade()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            //DataDriven dataDriven = new DataDriven();

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

            updateIssuePageObjects.AlterarPriority("immediate");
            updateIssuePageObjects.AtribuirNota("Deverá ser priorizado.");
            updateIssuePageObjects.Atualizar();
        }



        [Test]
        [Category("Bugado")]
        public void Issue_IssueExistente_AlterarCategoria()
        {
            //teste pra quando já se tem o ID
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            UpdateIssuePageObjects updateIssuePageObjects = new UpdateIssuePageObjects();
            String ID = "0001489";
            //DataDriven dataDriven = new DataDriven();

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();
            homePageObjects.VerificaProjeto();
            homePageObjects.ProcurarIssue(ID);

            reportIssuesPageObjects.AcessarEdicaoIssue_TelaPosBuscarID();
            /*
            * feedback acknowledged confirmed assigned resolved closed
            * 
            */
            updateIssuePageObjects.AlterarStatus("confirmed");
            updateIssuePageObjects.Atualizar();



        }

        [Test]
        [Category("Revisados")]
        public void Issue_InsertIssuee_VerificaID()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            //DataDriven dataDriven = new DataDriven();

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            String summary = reportIssuesPageObjects.InserirTarefa_RetornoSummary();//Aqui você o sumário inserido
            //neste momento é inserido uma tarefa com uma summary random e ela é retornada para ser utilizada na busca
            String ID = reportIssuesPageObjects.PegarIssueInserida(summary); //Aqui consegue o ID com o sumário



        }



        //[Test]
        public void Issue_InsertIssue_VerificarInsert()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();
            DataDriven dataDriven = new DataDriven();


            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            reportIssuesPageObjects.InserirTarefa();


            viewIssuesPageObjects.VerificarInsercao_Issue();


        }

        [Test]
        [Category("Revisados")]
        public void Issue_VerificaAcessoReportIssue()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();
            DataDriven dataDriven = new DataDriven();


            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
        }

        [Test]
        [Category("Revisados")]
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
        }

       



 

        //[Test]
        public void Issue_InsertIssueeTesteCSV()
        {
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            DataDriven dataDriven = new DataDriven();

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            reportIssuesPageObjects.InserirTarefa(dataDriven);
        }



        /// <summary>
        /// TESTES ENVOLVENDO DD
        /// Inserir uma tarefa com 4 parâmetros dinamicos e o restante estático
        /// </summary>
        /// 

        [Category("DataDriven"), TestCaseSource("InsercaoIssues")]
        public void Issue_DD_InsertSimple(string category, string reproducibility, string severity, string priority, string summary, string description)
        {

            //receber 4 parâmetros pelo DD e gerar os CT
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.VerificaProjeto();
            homePageObjects.AcessarAbaReportIssue();

            reportIssuesPageObjects.VerificarAcessaReportIssue();
            reportIssuesPageObjects.InserirIssue_Simple(category, reproducibility, severity, priority, summary, description);

            //VERIFICAR SUMMARY AO INSERIR CADA TAREFA COMO?EDITANDO ELA E VERIFICANDO O SUMARIO
        }


        [Test]
        [Category("Detalhes")]
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



        }

        [Test]
        [Category("Revisados")]
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






        }


        [Test]
        [Category("Bugado")]
        public void Issue_ExclusaoTotal()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.AcessarAbaViewIssue();

            viewIssuesPageObjects.VerificaAcessoViewIssues();
            viewIssuesPageObjects.SelecionarTudo();

            viewIssuesPageObjects.Excluir();





        }


        [Test]
        [Category("Bugado")]
        public void Issue_AtribuirSayoan()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.AcessarAbaViewIssue();

            viewIssuesPageObjects.VerificaAcessoViewIssues();

            //Aplicar filtro
            viewIssuesPageObjects.SelecionarTudo();
            viewIssuesPageObjects.AtribuirSayoan();





        }


        // [Test]
        public void testDD()
        {
            DataDriven dt = new DataDriven();
            dt.filldatafromCsv();
        }


        public static List<TestCaseData> InsercaoIssues
        {
           
            get
            {
                //IssueBody issueBody = new IssueBody(); //corpo da issue(tarefa)
                var testCases = new List<TestCaseData>();

                string[] split = { "" };
                ArrayList ItemList = new ArrayList();

                using (var fs = File.OpenRead(@"C:\Users\saymon.oliveira\Documents\Automacao Mantis\AutomacaoSomar-master\input_date.csv"))
                using (var sr = new StreamReader(fs))
                {
                    string line = string.Empty;

                    while (line != null)
                    {
                        
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            split = line.Split(new char[] { ',' }, StringSplitOptions.None);
                            Console.WriteLine(split);
                             string category = split[0].Trim(); //category
                             string reproducibility = split[1].Trim(); //reproducibility
                             string severity = split[2].Trim(); //severity
                             string priority = split[3].Trim(); //priority
                             string summary = split[4].Trim(); //summary
                             string description = split[5].Trim(); //description
                             
                             string ind_inserir  = split[6].Trim(); //ind_inserir 

                            if (ind_inserir.Equals("S"))
                            {
                                var testCase = new TestCaseData(category, reproducibility, severity, priority, summary, description);
                                testCases.Add(testCase);
                            }



                        
                        }
                    }
                }
                return testCases;
            }
        }

      
    }
}





