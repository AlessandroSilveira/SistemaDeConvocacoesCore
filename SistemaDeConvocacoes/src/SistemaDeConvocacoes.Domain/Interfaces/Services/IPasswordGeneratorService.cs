using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IPasswordGeneratorService
    {
        string GetPassword();
    }
}
