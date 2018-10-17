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
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
          
                Uteis.VerificarItem(ltManageVerifica,"Manage Projects","");



        }
        public void InserirSenha()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
                Uteis.PreencherCampo(tfPassword, "", LoginPageObjects.username);
                Uteis.ClicarBotao(btConfirmPassword);
          


        }
        public void AcessarManageProjects()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            
                Uteis.ClicarBotao(ltManageVerifica);
            


        }

        public void InserirCategoriaVazia(String categoria)
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
                Uteis.PreencherCampo(tfCategory, "", categoria);
                Uteis.ClicarBotao(btAddCategory);
                Uteis.VerificarItem(txtErroCategory, "A necessary field \"Category\" was empty. Please recheck your inputs.", "");
                
          


        }

        public void InserirCategoriaDuplicada(String categoria)
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
          
                Uteis.PreencherCampo(tfCategory, "", categoria);
                Uteis.ClicarBotao(btAddCategory);


                Uteis.PreencherCampo(tfCategory, "", categoria); //inserindo a recem inserida
                Uteis.ClicarBotao(btAddCategory);



                Uteis.VerificarItem(txtErroCategory, "A category with that name already exists.", "");

         


        }


        public void InserirCategoria_Duplicada(String categoria)
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            
                Uteis.PreencherCampo(tfCategory, "", categoria);
                Uteis.ClicarBotao(btAddCategory);
                Uteis.VerificarItem(txtErroDuplicado, "A category with that name already exists.", "");
           


        }


    }
}

