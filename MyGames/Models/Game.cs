using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGames.Models
{
    [Table("Games")]
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required(ErrorMessage = "O nome do jogo deve ser informado")]
        [Display(Name = "Nome do jogo")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string Name { get; set; }


        [Required(ErrorMessage = "A descrição do jogo deve ser informada")]
        [Display(Name = "Descrição do jogo")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} caracteres")]
        public string ShortDescription { get; set; }


        [Required(ErrorMessage = "A descrição detalhada do jogo deve ser informada")]
        [Display(Name = "Descrição detalhada do jogo")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada não pode exceder {1} caracteres")]
        public string DetailedDescription { get; set; }


        [Required(ErrorMessage = "Informe o preço do jogo")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Price { get; set; }


        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImageUrl { get; set; }


        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImageThumbnailUrl { get; set; }


        [Display(Name = "Estoque")]
        public bool Available { get; set; }

        public int GenderId { get; set; }
        public virtual Genre Gender { get; set; }
    }
}
