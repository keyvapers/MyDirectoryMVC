using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyDirectoryMVC.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Nombre(s) es obligatorio")]
        [Display(Name = "Nombre(s)")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Apellidos es obligatorio")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Teléfono es obligatorio")]
        [Display(Name = "Teléfono")]
        public string Telephone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Correo es obligatorio")]
        [Display(Name = "Correo")]
        [EmailAddress(ErrorMessage = "Correo no válido")]
        public string Email { get; set; } = string.Empty;
    }
}
