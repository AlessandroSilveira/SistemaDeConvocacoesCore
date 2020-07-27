﻿using System;
using System.Collections.Generic;
using SistemaDeConvocacoes.Domain.Enums;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SisConv.Domain.Core.Services
{
    public class MontaListaComEnum : IMontaListaComEnum
    {
        private readonly IEnumDescription _enumDescription;

        public MontaListaComEnum(IEnumDescription enumDescription)
        {
            _enumDescription = enumDescription;
        }

		public Dictionary<Estados, string> MontarListaEstado()
		{
			var estados = new Dictionary<Estados, string>();

			foreach (Estados val in Enum.GetValues(typeof(Estados)))
				estados.Add(val, _enumDescription.GetEnumDescription(val));
			return estados;
		}

	    public Dictionary<EstadoCivil, string> MontarListaEstadoCivil()
	    {
		    throw new NotImplementedException();
	    }

	    public Dictionary<TEnum, string> MontarListaOpoes<TEnum>()
	    {
			var opcoes = new Dictionary<TEnum, string>();

		    foreach (TEnum val in Enum.GetValues(typeof(TEnum)))
			    opcoes.Add(val, _enumDescription.GetEnumDescription((Enum)(object)((TEnum)val)));
		    return opcoes;
		}

	    public Dictionary<StatusConvocacao, string> MontarListaOpcoesComparecimento()
		{
			var opcoesComp = new Dictionary<StatusConvocacao, string>();

			foreach (StatusConvocacao val in Enum.GetValues(typeof(StatusConvocacao)))
				opcoesComp.Add(val, _enumDescription.GetEnumDescription(val));
			return opcoesComp;
		}

		public Dictionary<StatusConvocacao, string> MontarListaOpcoesContratacao()
		{
			var opcoesContratacao = new Dictionary<StatusConvocacao, string>();

			foreach (StatusConvocacao val in Enum.GetValues(typeof(StatusConvocacao)))
				opcoesContratacao.Add(val, _enumDescription.GetEnumDescription(val));
			return opcoesContratacao;
		}
	}
}