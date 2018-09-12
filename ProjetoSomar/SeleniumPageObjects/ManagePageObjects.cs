using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoSomar.SeleniumUteis;
using SeleniumMantis.SeleniumComum;
using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ProjetoSomar.SeleniumPageObjects
{
    class ManagePageObjects : WebDriver
    {
        public ManagePageObjects()
        {
            PageFactory.InitElements(DriverFactory.INSTANCE, this);
        }

        [FindsBy(How = How.LinkText, Using = "Manage")]
        public IWebElement ltManage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Manage Projects")]
        public IWebElement ltManageVerifica { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement tfPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='Password'])[1]/following::input[2]")]
        public IWebElement btConfirmPassword { get; set; }

         [FindsBy(How = How.Name, Using = "name")]
        public IWebElement tfCategory { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Add Category']")]
        public IWebElement btAddCategory { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='APPLICATION ERROR #1500'])[1]/following::p[1]")]
        public IWebElement txtErroDuplicado { get; set; }

        [FindsBy(How = How.XPath, Using = "//p")]
        public IWebElement txtErroCategory { get; set; }

        
        public void VerificarAccessoAbaManage()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.VerificarItem(ltManageVerifica,"Manage Projects","");

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }
        public void InserirSenha()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.PreencherCampo(tfPassword, "", LoginPageObjects.username);
                Maps.ClicarBotao(btConfirmPassword);
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }
        public void AcessarManageProjects()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.ClicarBotao(ltManageVerifica);
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void InserirCategoriaVazia(String categoria)
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.PreencherCampo(tfCategory, "", categoria);
                Maps.ClicarBotao(btAddCategory);
                Maps.VerificarItem(txtErroCategory, "A necessary field \"Category\" was empty. Please recheck your inputs.", "");
                
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void InserirCategoriaDuplicada(String categoria)
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.PreencherCampo(tfCategory, "", categoria);
                Maps.ClicarBotao(btAddCategory);


                Maps.PreencherCampo(tfCategory, "", categoria); //inserindo a recem inserida
                Maps.ClicarBotao(btAddCategory);



                Maps.VerificarItem(txtErroCategory, "A category with that name already exists.", "");

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }


        public void InserirCategoria_Duplicada(String categoria)
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.PreencherCampo(tfCategory, "", categoria);
                Maps.ClicarBotao(btAddCategory);
                Maps.VerificarItem(txtErroDuplicado, "A category with that name already exists.", "");
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }


    }
}

