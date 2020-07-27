﻿using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Cargos
    {
        public Guid CargoId { get; set; }
        public Guid ProcessoId { get; set; }
        public string Nome { get; set; }
        public string CodigoCargo { get; set; }
        public bool Ativo { get; set; }

        public virtual Processos Processo { get; set; }
    }
}
