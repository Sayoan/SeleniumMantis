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
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            GerarRandom gerarRandom = new GerarRandom();
            String conteudo = gerarRandom.RandomString();
            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                Maps.PreencherCampo(tfPlataform, "", conteudo);
                Maps.PreencherCampo(tfOs, "", conteudo);
                Maps.PreencherCampo(tfOsBuild, "", conteudo); 
                

             }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

            return conteudo;
        }

        public String EditarProfile()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            GerarRandom gerarRandom = new GerarRandom();
            String conteudo = gerarRandom.RandomString();
            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                Maps.ClicarBotao(rBEdit);
                Maps.ClicarBotao(btSubmit);

                Maps.PreencherCampo(tfPlataform, "", conteudo);
                Maps.PreencherCampo(tfOs, "", conteudo);
                Maps.PreencherCampo(tfOsBuild, "", conteudo);

                Maps.ClicarBotao(btUpdateProfileEdicao);

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

            return conteudo;
          
        }

        public String MakeDefault()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            GerarRandom gerarRandom = new GerarRandom();
            String conteudo = gerarRandom.RandomString();
            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                //Maps.ClicarBotao(rBMakeDefault);
                DriverFactory.INSTANCE.FindElement(By.XPath("(//input[@name='action'])[3]")).Click();
                
                Maps.ClicarBotao(btSubmit);


            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

            return conteudo;

        }

        public void VerificarInsercao(String conteudo)
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                Maps.CBClick(cbProfile, "", conteudo);

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void Excluir()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.ClicarBotao(rBDelete);
                Maps.ClicarBotao(btSubmit);

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void VerificarExclusao(String conteudo)
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
             Maps.CBClick_ElementoAusente(cbProfile, "", conteudo);

           


        }

        public void VerificarAcessoAbaMyAccount()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
               Maps.VerificarItem(editAccount, "Edit Account", "");
                
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void AcessarPreferences()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
               Maps.ClicarBotao(ltPreferences);
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void VerificaAcessoPreferences()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
              Maps.ClicarBotao(cbProject);
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }


        public void AcessarManageColumns()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
               Maps.ClicarBotao(ltManage);
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void VerificaAcessoManageColumns()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
               Maps.ClicarBotao(btUpdate);
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }



        public void AcessarProfiles()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                Maps.ClicarBotao(ltProfiles);
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void VerificaAcessoProfiles()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.VerificarItem(txtAddProfile, "Add Profile", "");
                
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

                      
        }


        public void VerificaCampoObrigatorioPlatform()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.VerificarItem(txtFalhaPlatform, "A necessary field \"Platform\" was empty. Please recheck your inputs.", "");
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

            
        }

        public void VerificaCampoObrigatorioOs()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.VerificarItem(txtFalhaPlatform, "A necessary field \"Operating System\" was empty. Please recheck your inputs.", "");
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void VerificaCampoObrigatorioOsBuild()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.VerificarItem(txtFalhaPlatform, "A necessary field \"Version\" was empty. Please recheck your inputs.", "");
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

        public void BotaoSubmeter()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {

                Maps.ClicarBotao(btUpdateProfile);
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

            //"A necessary field \"Platform\" was empty. Please recheck your inputs."
        }

        public void PreencheParametros1()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {

                Maps.PreencherCampo(tfPlataform, "", "");
                Maps.PreencherCampo(tfOs, "", "");
                Maps.PreencherCampo(tfOsBuild, "", "");
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

            //"A necessary field \"Platform\" was empty. Please recheck your inputs."
        }



        public void PreencheParametros2()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {

                Maps.PreencherCampo(tfPlataform, "", "A");
                Maps.PreencherCampo(tfOs, "", "");
                Maps.PreencherCampo(tfOsBuild, "", "");
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

            //"A necessary field \"Platform\" was empty. Please recheck your inputs."
        }
        public void PreencheParametros3()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {

                Maps.PreencherCampo(tfPlataform, "", "A");
                Maps.PreencherCampo(tfOs, "", "A");
                Maps.PreencherCampo(tfOsBuild, "", "");
            }


            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

            //"A necessary field \"Platform\" was empty. Please recheck your inputs."
        }


    }
}