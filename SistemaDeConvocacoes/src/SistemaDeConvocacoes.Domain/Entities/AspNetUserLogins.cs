using System;
using SistemaDeConvocacoes.Domain.Interfaces;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class AspNetUserLogins 
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
       
    }
}
