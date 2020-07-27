﻿using System;
using System.Collections.Generic;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Clientes
    {
        public Clientes()
        {
            Processos = new HashSet<Processos>();
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public virtual ICollection<Processos> Processos { get; set; }
    }
}
