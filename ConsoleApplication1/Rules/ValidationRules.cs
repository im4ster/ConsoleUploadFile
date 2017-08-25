using ConsoleApplication1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Rules
{
    public class ValidationRules
    {
        public bool ValidateBeneficiary(BeneficiarioEntity rowBeneficiarioEntity)
        {
            /*Aquí  se realizan todas las validaciones*/
            bool isValid = true;

            if (string.IsNullOrEmpty(rowBeneficiarioEntity.apellidoPat) || string.IsNullOrEmpty(rowBeneficiarioEntity.apellidoMat))
                isValid = false;


           return isValid;
        }
    }
}
