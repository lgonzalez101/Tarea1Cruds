using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tarea1Cruds_LuisGonzalez.Models
{
    public class EmpleadoViewModel
    {

        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public decimal? Sueldo { get; set; }
        [Required]
        public int? IdDepto { get; set; }

        public string NombreDepartameto { get; set; }
    }
}