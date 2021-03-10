using MiMascota.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiMascota.Web.Data.Entities   
{
    public class Mascota     
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        public string Nombre { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [MaxLength(50, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        public string Raza { get; set; }    

        [Display(Name = "Fecha De Nacimiento")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaDeNacimiento { get; set; } 

        public string Comentarios { get; set; } 

        public ICollection<HistoriaMedica> HistoriaMedicas { get; set; }

        //TODO: replace the correct URL for the image
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://TDB.azurewebsites.net{ImageUrl.Substring(1)}";
    }
}

