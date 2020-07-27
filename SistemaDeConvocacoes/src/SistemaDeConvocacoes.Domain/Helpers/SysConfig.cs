using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;
using SistemaDeConvocacoes.Domain.Interfaces.Helper;

namespace SistemaDeConvocacoes.Domain.Helpers
{
    public class SysConfig : ISysConfig
    {
        public string GetHelpFile(string page)
        {
            var ret = "";

            //if (page.Equals("")) return ret;
            //var helpfile = HttpContext.Request.Body + @"public\" + page + ".pt.htm";
            //if (!File.Exists(helpfile)) return ret;
            //var sr = new StreamReader(helpfile, Encoding.Default);
            //ret = sr.ReadToEnd();
            //sr.Close();
            //sr.Dispose();
            return ret;
        }
    }
}