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

                        string category = split[0].Trim(); //category
                        string reproducibility = split[1].Trim(); //reproducibility
                        string severity = split[2].Trim(); //severity
                        string priority = split[3].Trim(); //priority
                        string summary = split[4].Trim(); //summary
                        string description = split[5].Trim(); //description

                        string ind_inserir = split[6].Trim(); //ind_inserir 
                        if (ind_inserir.Equals("S"))
                        {
                            var testCase = new TestCaseData(category, reproducibility, severity, priority, summary, description);
                            testCases.Add(testCase);
                        }




                    }
                }
            }


            return testCases;
        }

        public static string getPatchCSV()
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
