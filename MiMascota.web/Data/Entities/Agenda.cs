using System;
using System.ComponentModel.DataAnnotations;

namespace MiMascota.Web.Data.Entities
{
    public class Agenda
    {
        public int Id { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }


        public string Comentarios { get; set; }

        [Display(Name = "Esta Disponible?")]
        public bool EstaDisponible { get; set; }
    }
}

