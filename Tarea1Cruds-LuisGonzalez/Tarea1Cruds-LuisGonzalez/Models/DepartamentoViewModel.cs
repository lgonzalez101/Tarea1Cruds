using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tarea1Cruds_LuisGonzalez.Models
{
    public class DepartamentoViewModel
    {
        public int Id { get; set; }
        [Required]
        public string NombreDepartamento { get; set; }
    }
}