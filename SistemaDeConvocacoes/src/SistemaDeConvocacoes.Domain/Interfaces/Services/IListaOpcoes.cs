﻿using System;
using System.Collections.Generic;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IListaOpcoes
    {
        string EnumDescription(Enum e);
        Dictionary<TEnum, string> MontarListaOpcoes<TEnum>();
    }
}