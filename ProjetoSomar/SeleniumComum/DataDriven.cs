using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumMantis.SeleniumComum
{
    class DataDriven
    {

        public List<TestCaseData> DataDrivenImplement()
        {
            var testCases = new List<TestCaseData>();

            string[] split = { "" };
            ArrayList ItemList = new ArrayList();
           
          
            using (var fs = File.OpenRead(@getPatchCSV()))
            using (var sr = new StreamReader(fs))
            {
                string line = string.Empty;

                while (line != null)
                {

                    line = sr.ReadLine();
                    if (line != null)
                    {
                        split = line.Split(new char[] { ',' }, StringSplitOptions.None);
                        //percorre a entrada utilizando o indice do vetor
                        for(int i = 0; i < split.Length; i++)
                        {
                            ItemList.Add(split[i].Trim()); //add na lista
                        }


                        if (ItemList.Contains("S"))
                        {
                            var testCase = new TestCaseData(ItemList); //criando ct em relação à lista
                            testCases.Add(testCase); //lista de ct
                        }




                    }
                }
            }


            return testCases;
        }

        public string getPatchCSV()
        {
            //qq rola, pegando o patch do projeto vem junto "file:/" + "resto do patch"
            String patch = (Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase))) + @"\input_date.csv");
            //retirando lixo file:\
            patch = patch.Remove(0, 6);
            //arquivo csv tem que estar dentro da pasta raiz do projeto!

            return patch;
        }


    }
}
