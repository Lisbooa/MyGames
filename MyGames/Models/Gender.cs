using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGames.Models
{
    [Table("Genders")]
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome do gênero")]
        [Display(Name = "Nome")]
        public string GenderName { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição do gênero")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        public List<Game> Games { get; set; }
    }
}
