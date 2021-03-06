﻿using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }
        public bool Ativo { get; set; }
    }
}
