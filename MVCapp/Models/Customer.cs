using MessagePack;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace MVCApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome do cliente precisa ser preenchido")]
        [Display(Name ="Nome do Cliente")]
        public string Name { get; set; }
        [Required(ErrorMessage ="o email do cliente precisa ser preenchido")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|org|net|gov)$", ErrorMessage ="Email Inválido")]
        public string Email { get; set; }

        public string Address { get; set; }

    }
}
