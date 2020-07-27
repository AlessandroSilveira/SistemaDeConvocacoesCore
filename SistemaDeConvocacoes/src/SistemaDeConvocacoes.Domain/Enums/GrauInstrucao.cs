﻿using System.ComponentModel;

namespace SistemaDeConvocacoes.Domain.Enums
{
    public enum GrauInstrucao
    {
        [Description("Ensino Médio Completo")]
        EnsinoMedioCompleto,
        [Description("Ensino Superior Incompleto")]
        EnsinoSuperiorIncompleto,
        [Description("Ensino Superior Completo")]
        EnsinoSuperiorCompleto,
        [Description("Especializado")]
        Especializado,
        [Description("Mestrado")]
        Mestrado,
        [Description("Doutorado")]
        Doutorado,
        [Description("Pós-Doutorado")]
        PosDoutorado
    }
}
