using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjetoSomar.SeleniumComum
{
    class DataDriven : WebDriver
    {
       
        //public DataDriven(){
        //    String[] dados = new String[10];
        //    dados[0] = "[All Projects] app_14";
        //    dados[1] = "always";
        //    dados[2] = "feature";
        //    dados[3] = "none";
        //    dados[4] = "Desktop Windows 10";
        //    dados[5] = "teste1";
        //    dados[6] = "teste1";
        //    dados[7] = "teste1";
        //    dados[8] = "administrator";
        //    dados[9] = "TESTE_SUMMARY";
        //    dados[10] = "teste4";
        //    dados[11] = "teste4";
        //    dados[12] = "teste4";

        //}






        
        
      
        public string[] filldatafromCsv()
        {
            string linha = null;
            //Declaro um array do tipo string que será utilizado para adicionar o conteudo da linha separado 
            string[] linhaseparada = null;

            try
            {
                //Declaro o StreamReader para o caminho onde se encontra o arquivo 
                StreamReader rd = new StreamReader(@"C:/Users/saymon.oliveira/Documents/Automacao Mantis/AutomacaoSomar-master/ProjetoSomar/SeleniumComum/input_date.csv");
                //Declaro uma string que será utilizada para receber a linha completa do arquivo 
              
                //realizo o while para ler o conteudo da linha 
                while ((linha = rd.ReadLine()) != null)
                {
                    //com o split adiciono a string 'quebrada' dentro do array 
                    linhaseparada = linha.Split(';');
              

                }
                rd.Close();
            }
            catch
            {
                Console.WriteLine("Erro ao executar Leitura do Arquivo");
            }
            return linhaseparada;
        }

        public void teste()
        {
            var filePath = @"C:/Users/saymon.oliveira/Documents/Automacao Mantis/AutomacaoSomar-master/ProjetoSomar/SeleniumComum/input_date.csv";
            var data = File.ReadLines(filePath).Select(x => x.Split(',')).ToArray();
            

        }
    }
    }

