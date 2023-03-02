using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.ValidationRules
{
    public class AboutValidator: AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(a => a.Description1).NotEmpty();
            RuleFor(a => a.Image).NotEmpty();
            RuleFor(a => a.Description1).MinimumLength(50);
            RuleFor(a => a.Description1).MaximumLength(1500);
        }
    }
}
