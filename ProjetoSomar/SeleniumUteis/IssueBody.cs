using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSomar.SeleniumUteis
{
    public class IssueBody 
    {
        public IssueBody()
        {

        }
        public string category { get; set; }
        public string priority { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
    }
}
