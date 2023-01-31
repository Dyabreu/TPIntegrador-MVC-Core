using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaWebEmpleado.Validations;

namespace SistemaWebEmpleado.Models
{
    public class Empleado
    { 
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar (50)")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar (50)")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar (50)")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [RegularExpression("^A{1}?[0-9]{4}$", ErrorMessage = "Código de legajo inválido")]
        public string Legajo { get; set; }

        [AdelanteDe2000]
        public DateTime FechaNacimiento { get; set; }

    }
}
