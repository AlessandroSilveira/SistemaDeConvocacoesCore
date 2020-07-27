using System.ComponentModel.DataAnnotations;

namespace SistemaDeConvocacoes.Application.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required] [Display(Name = "Email")] public string Email { get; set; }
    }
}