using System.ComponentModel.DataAnnotations;

namespace SistemaDeConvocacoes.Application.ViewModels
{
    public class ForgotViewModel
    {
        [Required] [Display(Name = "Email")] public string Email { get; set; }
    }
}