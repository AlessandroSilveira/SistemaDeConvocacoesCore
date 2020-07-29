using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeConvocacoes.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            ClienteId = Guid.NewGuid();
        }

        [Key] 
        public Guid ClienteId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nome do Cliente")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "CNPJ do Cliente")]
        public string Cnpj { get; set; }

        [Required(AllowEmptyStrings = false)]
        [EmailAddress]
        [Display(Name = "E-mail do Cliente")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Telefone do Cliente")]
        public string Telefone { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação de senha não conferem")]
        public string ConfirmPassword { get; set; }

        [Required] 
        [Display(Name = "Ativo")] 
        public bool Ativo { get; set; }

        //[Required] 
        [Display(Name = "Logotipo do Cliente")] 
        public string Imagem { get; set; }
    }
}