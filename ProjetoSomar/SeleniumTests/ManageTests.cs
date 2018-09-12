using NUnit.Framework;
using OpenQA.Selenium;
using ProjetoSomar.SeleniumComum;
using ProjetoSomar.SeleniumPageObjects;
using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test;

namespace ProjetoSomar.SeleniumTests
{
    class ManageTests : WebDriver
    {
        [Test]
        [Category("Revisados")]
        public void Manage_CriarCategoria_Vazia()
        {
            //falta assert
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            ManagePageObjects managePageObjects = new ManagePageObjects();
            GerarRandom gerarRandom = new GerarRandom();
            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.AcessarAbaManage();
            managePageObjects.VerificarAccessoAbaManage();
            managePageObjects.AcessarManageProjects();
            managePageObjects.InserirCategoriaVazia("");
            Assert.Pass();




        }

        [Test]
        [Category("Revisados")]
        public void Manage_CriarCategoriaDuplicada()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            ManagePageObjects managePageObjects = new ManagePageObjects();
            GerarRandom gerarRandom = new GerarRandom();
            String categoria = gerarRandom.RandomString();

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();

            homePageObjects.AcessarAbaManage();
            managePageObjects.VerificarAccessoAbaManage();
            managePageObjects.AcessarManageProjects();
            managePageObjects.InserirCategoriaDuplicada(categoria);
            Assert.Pass();




        }

        



    }
}
