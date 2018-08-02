using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebDriver.Basics.SeleniumUteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Basics
{
    //Modificar de acesso public
  
    public class Tests : WebDriver
    {
        [Test]
        public void Somar()
        {

            // pega os dos valores na tela e guarda em uma variável
            string valor1 = driver.FindElement(By.Id("number1")).Text;
            string valor2 = driver.FindElement(By.Id("number2")).Text;

            // transforma os resultados em um número inteiro para a soma
            int resultadoInt = Int32.Parse(valor1) + Int32.Parse(valor2);

            // envia o número somado, transformando em string
            driver.FindElement(By.Name("soma")).SendKeys(Convert.ToString(resultadoInt));
            driver.FindElement(By.Name("submit")).Click();


            NUnit.Framework.Assert.AreEqual("CORRETO", driver.FindElement(By.Id("resultado")).Text);
        }
      
    }

}

       

