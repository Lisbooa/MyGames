using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyGames.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="O nome deve ser informado")]
        [DisplayName("Nome:")]
        [MinLength(4, ErrorMessage ="O nome deve conter no mínimo 4 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O e-mail deve ser informado")]
        [DisplayName("E-mail:")]
        [EmailAddress(ErrorMessage ="E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A mensagem deve ser informada")]
        [DisplayName("Informe sua mensagem:")]
        [MinLength(10, ErrorMessage = "A mensagem deve conter no mínimo 10 caracteres")]
        public string Message { get; set; }
    }
}