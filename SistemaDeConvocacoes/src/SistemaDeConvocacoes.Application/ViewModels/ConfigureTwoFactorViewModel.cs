using System.Collections.Generic;

namespace SistemaDeConvocacoes.Application.ViewModels
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<string> Providers { get; set; }
    }
}