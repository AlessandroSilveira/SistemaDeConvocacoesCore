using System;
using System.Collections.Generic;
using SistemaDeConvocacoes.Domain.Interfaces;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class AspNetRoles 
    {
        public AspNetRoles()
        {
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
        }

        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }

      
    }
}
