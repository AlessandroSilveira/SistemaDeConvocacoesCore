using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IPasswordGeneratorService
    {
        Task<string> GetPassword();
    }
}
