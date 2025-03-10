﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyGames.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "O nome deve ser informado")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "O sobrenome deve ser informado")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "O endereço deve ser informado")]
        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string Address1 { get; set; }

        [StringLength(100)]
        [Display(Name = "Complemento")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "O CEP deve ser informado")]
        [StringLength(10, MinimumLength = 8)]
        public string Cep { get; set; }

        [StringLength(10)]
        public string State { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "O telefone de ser informado")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "O e-mail deve ser informado")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "O email não possui um formato correto")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Total do pedido")]
        public decimal OrderTotal { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Itens no pedido")]
        public int TotalOrderItems { get; set; }

        [Display(Name = "Data do pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime OrderSent { get; set; }

        [Display(Name = "Data Envio Pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime? OrderDelivered { get; set; }

        public List<OrderDetail> OrderItems { get; set; }
    }
}
