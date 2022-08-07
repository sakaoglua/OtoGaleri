using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SubeValidator : AbstractValidator<Subeler>
    {
        public SubeValidator()
        {
            RuleFor(x => x.S_Name).NotEmpty().WithMessage("Şube Adı Boş Olamaz.");
            RuleFor(x => x.S_Name).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.");
        }
    }
}
