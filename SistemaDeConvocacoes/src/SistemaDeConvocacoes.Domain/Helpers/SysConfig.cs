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

            return ret;
        }
    }
}