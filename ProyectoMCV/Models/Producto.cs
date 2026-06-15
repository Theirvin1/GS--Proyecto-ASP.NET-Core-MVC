using System.ComponentModel.DataAnnotations;

namespace ProyectoMCV.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(150, ErrorMessage = "Máximo 150 caracteres")]
        [Display(Name = "Título")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Autor")]
        public string? Autor { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.01, 500, ErrorMessage = "El precio debe ser entre 0.01 y 500")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El número de páginas es obligatorio")]
        [Range(1, 5000, ErrorMessage = "Debe tener entre 1 y 5000 páginas")]
        [Display(Name = "Páginas")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "El ISBN es obligatorio")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "El ISBN debe tener entre 10 y 13 caracteres")]
        [Display(Name = "ISBN")]
        public string? ISBN { get; set; }
    }
}