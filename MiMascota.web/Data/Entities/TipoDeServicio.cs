using System.ComponentModel.DataAnnotations;

namespace MiMascota.Web.Data.Entities   
{
    public class TipoDeServicio 
    {
        public int Id { get; set; }

        [Display(Name = "Tipo De Servicio")]
        [MaxLength(50, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        public string Nombre { get; set; }  
    }
}

