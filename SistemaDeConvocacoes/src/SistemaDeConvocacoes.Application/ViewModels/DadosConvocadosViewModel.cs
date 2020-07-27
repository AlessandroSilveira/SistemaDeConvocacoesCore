﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeConvocacoes.Application.ViewModels
{
    public class DadosConvocadosViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Arquivo")]
        public string File { get; set; }
    }
}