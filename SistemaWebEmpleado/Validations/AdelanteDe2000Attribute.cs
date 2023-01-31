using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Validations
{
    public class AdelanteDe2000Attribute:ValidationAttribute
    {
        public AdelanteDe2000Attribute()
        {
            ErrorMessage = "El año debe ser posterior al 2000";
        }

        public override bool IsValid(object value)
        {
            DateTime fechaEntrada = Convert.ToDateTime(value);
            DateTime fechaBase = new DateTime(2000, 01, 01);
            
            if (fechaEntrada < fechaBase)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
