﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeConvocacoes.Application.ViewModels
{
    public class ProcessoViewModel
    {
        [Key] 
        public Guid ProcessoId { get; set; }

        [Required] 
        public Guid ClienteId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Data de Criação")]
        public DateTime DataCriacao { get; set; }

        [Required]
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Texto de Aceitação da Convocação")]
        [MaxLength(200)]
        public string TextoDeAceitacaoDaConvocacao { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Texto Inicial da tela de convocação")]
        [MaxLength(200)]
        public string TextoInicialTelaConvocado { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Texto para Convocados Desistentes")]
        [MaxLength(200)]
        public string TextoParaDesistentes { get; set; }
    }
}