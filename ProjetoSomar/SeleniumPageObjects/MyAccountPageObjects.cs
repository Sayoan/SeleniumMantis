using Microsoft.VisualStudio.TestTools.UnitTesting;
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
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoSomar.SeleniumPageObjects{
    class MyAccountPageObjects : WebDriver
{
        public MyAccountPageObjects()
        {
            PageFactory.InitElements(DriverFactory.INSTANCE, this);
        }

        [FindsBy(How = How.LinkText, Using = "My Account")]
        public IWebElement ltAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/table/tbody/tr/td")]
        public IWebElement editAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "Preferences")]
        public IWebElement ltPreferences { get; set; }

        [FindsBy(How = How.LinkText, Using = "Manage Columns")]
        public IWebElement ltManage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Profiles")]
        public IWebElement ltProfiles { get; set; }

        [FindsBy(How = How.Name, Using = "default_project")]
        public IWebElement cbProject { get; set; }

        [FindsBy(How = How.Name, Using = "update_columns_for_current_project")]
        public IWebElement btUpdate { get; set; }

        [FindsBy(How = How.Name, Using = "platform")]
        public IWebElement tfPlataform { get; set; }

        [FindsBy(How = How.Name, Using = "os")]
        public IWebElement tfOs { get; set; }

        [FindsBy(How = How.Name, Using = "os_build")]
        public IWebElement tfOsBuild { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='APPLICATION ERROR #11'])[1]/following::p[1]")]
        public IWebElement txtFalhaPlatform { get; set; }

        [FindsBy(How = How.Name, Using = "os_build")]
        public IWebElement txtFalhaOs { get; set; }

        [FindsBy(How = How.Name, Using = "os_build")]
        public IWebElement txtFalhaOsBuild { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Add Profile']")]
        public IWebElement btUpdateProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Update Profile']")]
        public IWebElement btUpdateProfileEdicao { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//form/table/tbody/tr/td")]
        public IWebElement txtAddProfile { get; set; }

        [FindsBy(How = How.Name, Using = "profile_id")]
        public IWebElement cbProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='Edit or Delete Profiles'])[1]/following::input[1]")]
        public IWebElement rBEdit { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='action'])[3]")]
        public IWebElement rBMakeDefault { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='Edit or Delete Profiles'])[1]/following::input[3]")]
        public IWebElement rBDelete { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Submit']")]
        public IWebElement btSubmit { get; set; }
        

        public string InserirProfile_Validar()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            GerarRandom gerarRandom = new GerarRandom();
            String conteudo = gerarRandom.RandomString();
            //método try catch para validar se foi possível acessar a tela inicial
           
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                Uteis.PreencherCampo(tfPlataform, "", conteudo);
                Uteis.PreencherCampo(tfOs, "", conteudo);
                Uteis.PreencherCampo(tfOsBuild, "", conteudo); 
                


            return conteudo;
        }

        public String EditarProfile()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            GerarRandom gerarRandom = new GerarRandom();
            String conteudo = gerarRandom.RandomString();
            //método try catch para validar se foi possível acessar a tela inicial
           
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                Uteis.ClicarBotao(rBEdit);
                Uteis.ClicarBotao(btSubmit);

                Uteis.PreencherCampo(tfPlataform, "", conteudo);
                Uteis.PreencherCampo(tfOs, "", conteudo);
                Uteis.PreencherCampo(tfOsBuild, "", conteudo);

                Uteis.ClicarBotao(btUpdateProfileEdicao);

           

            return conteudo;
          
        }

        public String MakeDefault()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            GerarRandom gerarRandom = new GerarRandom();
            String conteudo = gerarRandom.RandomString();
            //método try catch para validar se foi possível acessar a tela inicial
           
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                //Uteis.ClicarBotao(rBMakeDefault);
                DriverFactory.INSTANCE.FindElement(By.XPath("(//input[@name='action'])[3]")).Click();
                
                Uteis.ClicarBotao(btSubmit);



            return conteudo;

        }

        public void VerificarInsercao(String conteudo)
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

          
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                Uteis.CBClick(cbProfile, "", conteudo);



        }

        public void Excluir()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
          
                Uteis.ClicarBotao(rBDelete);
                Uteis.ClicarBotao(btSubmit);



        }

        public void VerificarExclusao(String conteudo)
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
             Uteis.CBClick_ElementoAusente(cbProfile, "", conteudo);

           


        }

        public void VerificarAcessoAbaMyAccount()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial

            Uteis.VerificarItem(editAccount, "Edit Account", "");
                
         


        }

        public void AcessarPreferences()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
               Uteis.ClicarBotao(ltPreferences);
           


        }

        public void VerificaAcessoPreferences()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
              Uteis.ClicarBotao(cbProject);
            
            


        }


        public void AcessarManageColumns()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
          
               Uteis.ClicarBotao(ltManage);
           


        }

        public void VerificaAcessoManageColumns()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            
               Uteis.ClicarBotao(btUpdate);
           


        }



        public void AcessarProfiles()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                Uteis.ClicarBotao(ltProfiles);
           


        }

        public void VerificaAcessoProfiles()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
                Uteis.VerificarItem(txtAddProfile, "Add Profile", "");
                
            

                      
        }


        public void VerificaCampoObrigatorioPlatform()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
          
                Uteis.VerificarItem(txtFalhaPlatform, "A necessary field \"Platform\" was empty. Please recheck your inputs.", "");
           

            
        }

        public void VerificaCampoObrigatorioOs()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           
                Uteis.VerificarItem(txtFalhaPlatform, "A necessary field \"Operating System\" was empty. Please recheck your inputs.", "");
          


        }

        public void VerificaCampoObrigatorioOsBuild()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
          
                Uteis.VerificarItem(txtFalhaPlatform, "A necessary field \"Version\" was empty. Please recheck your inputs.", "");
           


        }

        public void BotaoSubmeter()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
           

                Uteis.ClicarBotao(btUpdateProfile);
           

            //"A necessary field \"Platform\" was empty. Please recheck your inputs."
        }

        public void PreencheParametros1()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
          

                Uteis.PreencherCampo(tfPlataform, "", "");
                Uteis.PreencherCampo(tfOs, "", "");
                Uteis.PreencherCampo(tfOsBuild, "", "");
           

            //"A necessary field \"Platform\" was empty. Please recheck your inputs."
        }



        public void PreencheParametros2()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            

                Uteis.PreencherCampo(tfPlataform, "", "A");
                Uteis.PreencherCampo(tfOs, "", "");
                Uteis.PreencherCampo(tfOsBuild, "", "");
            

            //"A necessary field \"Platform\" was empty. Please recheck your inputs."
        }
        public void PreencheParametros3()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            

                Uteis.PreencherCampo(tfPlataform, "", "A");
                Uteis.PreencherCampo(tfOs, "", "A");
                Uteis.PreencherCampo(tfOsBuild, "", "");
          

            //"A necessary field \"Platform\" was empty. Please recheck your inputs."
        }


    }
}