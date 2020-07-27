using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeConvocacoes.Application.ViewModels
{
    public class ListaDocumentosViewModel
    {
        public Guid ConvocacaoId { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }

        [Display(Name = "Arquivo")]
        public string Path { get; set; }

        [Display(Name = "Tipo de Documento")]
        public string TipoDocumento { get; set; }
        public DateTime DataPostagem { get; set; }

        [Display(Name = "Inscrição")]
        public string Inscricao { get; set; }
        public Guid DocumentoCandidatoId { get; set; }
    }
}