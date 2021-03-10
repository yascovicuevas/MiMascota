using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiMascota.web.Data.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        [MaxLength(12, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        [Display(Name = "Cedula")]
        public string Cedula { get; set; }
        
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        [Display(Name = "Primer Nombre")]
        public string PrimerNombre { get; set; }
        
        [MaxLength(50, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        [Display(Name = "Segundo Nombre (Opcional)")]
        public string SegundoNombre { get; set; }
        
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        [MaxLength(20, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        [Display(Name = "Telefono Fijo (Opcional)")]
        public string TelefonoFijo { get; set; }
        
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        [Display(Name = "Celular")]
        public string TelefonoCelular { get; set; }
       
        [MaxLength(100, ErrorMessage = "El Campo {0} no permite mas de {1} caracteres.")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Display(Name = "Cliente")]
        public string NombreCompleto => $"{PrimerNombre} {SegundoNombre} {Apellidos}";
        [Display(Name = "Cliente")]
        public string NombreCompletoConCedula => $"{PrimerNombre} {SegundoNombre} {Apellidos} - {Cedula}";
    }





}

