using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class ValidationLogin : AbstractValidator<ValidationLogin>
    {
        public ValidationLogin()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            
        }
    }
}
