using System;
using System.ComponentModel.DataAnnotations;

namespace MiMascota.Web.Data.Entities
{
    public class HistoriaMedica     
    {
        public int Id { get; set; }


        [Display(Name = "Descripcion*")]
        [MaxLength(100, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        public string Descripcion { get; set; } 

        [Display(Name = "Fecha*")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        public string Comentarios { get; set; } 
    }
}

