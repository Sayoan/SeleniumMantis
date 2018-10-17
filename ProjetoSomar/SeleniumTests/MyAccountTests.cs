using NUnit.Framework;
using OpenQA.Selenium;
using ProjetoSomar.SeleniumComum;
using ProjetoSomar.SeleniumPageObjects;
using ProjetoSomar.SeleniumUteis;
using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ProjetoSomar.SeleniumTests
{
    class MyAccountTests : WebDriver
    {

        [Test]
        [Category("CT")]
        public void MyAccount_VerificaAcessoPreferences()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();



            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.AcessarPreferences();
            myAccountPageObjects.VerificaAcessoPreferences();
            Assert.Pass();


        }

        [Test]
        [Category("CT")]
        public void MyAccount_VerificaAcessoManage()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();



            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.AcessarManageColumns();
            myAccountPageObjects.VerificaAcessoManageColumns();
            Assert.Pass();


        }

        [Test]
        [Category("CT")]
        public void MyAccount_VerificaAcessoProfiles()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();



            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.AcessarProfiles();
            myAccountPageObjects.VerificaAcessoProfiles();
            Assert.Pass();


        }

        [Test]
        [Category("CT")]
        public void MyAccount_ValidacaoProfiles_ObrigatoriedadeParametros1()
        {
            //PLATFORM VAZIO
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();



            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.AcessarProfiles();
            myAccountPageObjects.VerificaAcessoProfiles();
            myAccountPageObjects.PreencheParametros1();
            myAccountPageObjects.BotaoSubmeter();
            myAccountPageObjects.VerificaCampoObrigatorioPlatform();
            Assert.Pass();





        }

        [Test]
        [Category("CT")]
        public void MyAccount_ValidacaoProfiles_ObrigatoriedadeParametros2()
        {
            //OS VAZIO
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();



            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.AcessarProfiles();
            myAccountPageObjects.VerificaAcessoProfiles();
            myAccountPageObjects.PreencheParametros2();
            myAccountPageObjects.BotaoSubmeter();
            myAccountPageObjects.VerificaCampoObrigatorioOs();
            Assert.Pass();


        }


        [Test]
        [Category("CT")]
        public void MyAccount_ValidacaoProfiles_ObrigatoriedadeParametros3()
        {
            //OSBUILD VAZIO
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();



            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.AcessarProfiles();
            myAccountPageObjects.VerificaAcessoProfiles();
            myAccountPageObjects.PreencheParametros3();
            myAccountPageObjects.BotaoSubmeter();
            myAccountPageObjects.VerificaCampoObrigatorioOsBuild();
            Assert.Pass();


        }

        [Test]
        [Category("CT")]
        public void MyAccount_InserirProfile()
        {
            //OSBUILD VAZIO
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();
            

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.AcessarProfiles();
            myAccountPageObjects.VerificaAcessoProfiles();
            string conteudo = myAccountPageObjects.InserirProfile_Validar();
            myAccountPageObjects.BotaoSubmeter();
            conteudo = conteudo + " " + conteudo + " " + conteudo;
            myAccountPageObjects.VerificarInsercao(conteudo);
            Assert.Pass();



        }

        [Test]
        [Category("CT")]
        public void MyAccount_InserirProfile_Editar()
        {
            //OSBUILD VAZIO
            //Insere um profile
            //edita
            //verifica se foi inserido
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.AcessarProfiles();
            myAccountPageObjects.VerificaAcessoProfiles();
            string conteudo = myAccountPageObjects.InserirProfile_Validar();
            myAccountPageObjects.BotaoSubmeter();
            conteudo = conteudo + " " + conteudo + " " + conteudo;
            myAccountPageObjects.VerificarInsercao(conteudo);

            conteudo = myAccountPageObjects.EditarProfile();
            conteudo = conteudo + " " + conteudo + " " + conteudo;
            myAccountPageObjects.VerificarInsercao(conteudo);
            Assert.Pass();




        }

        [Test]
        [Category("CT")]
        public void MyAccount_InserirProfile_MakeDefault()
        {
            //OSBUILD VAZIO
            //Insere um profile
            //edita
            //verifica se foi inserido
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();

            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.AcessarProfiles();
            myAccountPageObjects.VerificaAcessoProfiles();
            string conteudo = myAccountPageObjects.InserirProfile_Validar();
            myAccountPageObjects.BotaoSubmeter();
            conteudo = conteudo + " " + conteudo + " " + conteudo;
            myAccountPageObjects.VerificarInsercao(conteudo);

            myAccountPageObjects.MakeDefault(); //tornando default

            homePageObjects.AcessarAbaReportIssue(); //validando
            reportIssuesPageObjects.VerificarAcessaReportIssue();

            //vai lá na report e ve se tornou default
            reportIssuesPageObjects.VerificarDefaultProfile(conteudo);
            Assert.Pass();




        }


        [Test]
        [Category("CT")]
        public void MyAccount_InserirProfile_Excluir()
        {
            //OSBUILD VAZIO
            //Insere um profile
            //edita
            //verifica se foi inserido
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ReportIssuesPageObjects reportIssuesPageObjects = new ReportIssuesPageObjects();

            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.AcessarProfiles();
            myAccountPageObjects.VerificaAcessoProfiles();

            string conteudo = myAccountPageObjects.InserirProfile_Validar();
            myAccountPageObjects.BotaoSubmeter();
            conteudo = conteudo + " " + conteudo + " " + conteudo;
            myAccountPageObjects.VerificarInsercao(conteudo);

            myAccountPageObjects.Excluir(); 
            myAccountPageObjects.VerificarExclusao(conteudo);
            Assert.Pass();







        }
    }
}
