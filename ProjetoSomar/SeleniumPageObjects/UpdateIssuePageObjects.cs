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

namespace ProjetoSomar.SeleniumPageObjects
{
    class UpdateIssuePageObjects : WebDriver

    {

        public UpdateIssuePageObjects()
        {
            PageFactory.InitElements(DriverFactory.INSTANCE, this);
        }


        [FindsBy(How = How.Name , Using = "status")]
        public IWebElement cbStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[18]/td/input")]
        public IWebElement btUpdate { get; set; }

        [FindsBy(How = How.Id, Using = "tag_string")]
        public IWebElement tfTag { get; set; }

        [FindsBy(How = How.Id, Using = "//input[@value='Attach']")]
        public IWebElement btTag { get; set; }

        [FindsBy(How = How.Name, Using = "resolution")]
        public IWebElement cbResolution { get; set; }

        [FindsBy(How = How.Name, Using = "priority")]
        public IWebElement cbPriority { get; set; }

        [FindsBy(How = How.Name, Using = "bugnote_text")]
        public IWebElement tfBugNote { get; set; }

        [FindsBy(How = How.Name, Using = "handler_id")]
        public IWebElement cbAssign { get; set; }

        [FindsBy(How = How.Name, Using = "reproducibility")]
        public IWebElement cbReproducibility { get; set; }

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement tfUsername { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@value='Add'])[2]")]
        public IWebElement btAdd { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='Priority'])[1]/following::td[1]")]
        public IWebElement txtPriority { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='Assign'])[1]/following::td[1]")]
        public IWebElement tfAssign { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[8]/td[2]")]
        public IWebElement txtStatus { get; set; }
        

        public void AlterarStatus(String status)
        {
            

            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {
                //Maps.CBClick(cbStatus, "status", status); 
                //revisar funcao do combobox
                Maps.CBClick(cbStatus, "", status); 
               


            }
            catch (Exception e)
            {




            }


        }

        
        
            public void AlterarPriority(String status)
        {


            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {
                //Maps.CBClick(cbStatus, "status", status); 
                //revisar funcao do combobox
                Maps.CBClick(cbPriority, "", status);



            }
            catch (Exception e)
            {




            }


        }



        public void VerificaPriority(String status)
        {


            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {
                //Maps.CBClick(cbStatus, "status", status); 
                //revisar funcao do combobox
                Maps.VerificarItem(txtPriority, status, "");



            }
            catch (Exception e)
            {




            }


        }

        public void VerificaAssign(String status)
        {


            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {
                //Maps.CBClick(cbStatus, "status", status); 
                //revisar funcao do combobox
                Maps.VerificarItem(tfAssign, status, "");



            }
            catch (Exception e)
            {




            }


        }
        public void AlterarResolution(String resolution)
        {


            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {
                //Maps.CBClick(cbStatus, "status", status); 
                //revisar funcao do combobox
                Maps.CBClick(cbResolution, "", resolution);



            }
            catch (Exception e)
            {




            }




        }
        
         public void VerificaPrioridade(String Prioridade)
        {


            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {
                //Maps.CBClick(cbStatus, "status", status); 
                //revisar funcao do combobox
                //Maps.VerificarItem();
                



            }
            catch (Exception e)
            {




            }
        }


        public void AtribuirNota(String nota)
        {


            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {
                //Maps.CBClick(cbStatus, "status", status); 
                //revisar funcao do combobox
                Maps.PreencherCampo(tfBugNote, "", nota);



            }
            catch (Exception e)
            {




            }
        }
            public void AlterarReprodutibilidade(String reprodutibilidade)
            {


                WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
                SeleniumMaps Maps = new SeleniumMaps();
                String ID = "";

                try
                {
                //Maps.CBClick(cbStatus, "status", status); 
                //revisar funcao do combobox
                Maps.CBClick(cbReproducibility, "", reprodutibilidade);



                }
                catch (Exception e)
                {




                }




            }

        public void AtribuirTarefa(String usuario)
        {


            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            String ID = "";

            try
            {
                //Maps.CBClick(cbStatus, "status", status); 
                //revisar funcao do combobox
                Maps.CBClick(cbAssign, "" , usuario);



            }
            catch (Exception e)
            {




            }




        }


        public void Atualizar()
        {


            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            

            try
            {
                Maps.ClicarBotao(btUpdate,"");
               

            }
            catch (Exception e)
            {




            }


        }

        public void VerificaStatus(String status)
        {
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(3));
            SeleniumMaps Maps = new SeleniumMaps();
            
            Maps.VerificarItem(txtStatus, status, "");


        }

    }
}
