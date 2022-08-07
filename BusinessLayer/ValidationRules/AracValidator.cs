using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AracValidator : AbstractValidator<Araclar>
    {
        public AracValidator()
        {
            RuleFor(x => x.A_Marka).NotEmpty().WithMessage("Admin Adı Boş Olamaz.");
            RuleFor(x => x.A_Plaka).NotEmpty().WithMessage("Admin Soyadı boş olamaz.");
            RuleFor(x => x.A_Marka).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.");
            RuleFor(x => x.A_Plaka).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.");

        }
    }
}
