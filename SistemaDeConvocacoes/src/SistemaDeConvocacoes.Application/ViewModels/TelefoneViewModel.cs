﻿using System;
using System.ComponentModel.DataAnnotations;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Application.ViewModels
{
    public class TelefoneViewModel
    {
        public TelefoneViewModel()
        {
            TelefoneId = Guid.NewGuid();
        }

        [Key] public Guid TelefoneId { get; set; }

        public Pessoa PessoaId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Ddd")]
        public string Ddd { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Número")]
        public string Numero { get; set; }
    }
}