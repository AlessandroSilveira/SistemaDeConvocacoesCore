using System.Collections.Generic;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IMontaListaComEnum
    {
        Dictionary<TEnum, string> MontarListaOpoes<TEnum>();
    }
}