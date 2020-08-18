using System;
using System.Text;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class PasswordGeneratorService : IPasswordGeneratorService
    {
        private const string ValidCharacters = "abcdefghijklmnopqrstuvwxyz1234567890@#!?";

        public async Task<string> GetPassword()
        {
            const int
                size = 8; 

            var maxValue = ValidCharacters.Length;
            var random = new Random(DateTime.Now.Millisecond);
            var password = new StringBuilder(size);

            for (var i = 0; i < size; i++)
                password.Append(ValidCharacters[random.Next(0, maxValue)]);

            return password.ToString();
        }
    }
}