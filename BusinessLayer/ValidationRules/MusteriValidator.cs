using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MusteriValidator : AbstractValidator<Musteriler>
    {
        public MusteriValidator()
        {
            RuleFor(x => x.M_Name).NotEmpty().WithMessage("Müşteri Adı Boş Olamaz.");
            RuleFor(x => x.M_Surname).NotEmpty().WithMessage("Müşteri Soyadı boş olamaz.");
            RuleFor(x => x.M_About).NotEmpty().WithMessage("Müşteri Adı Boş Olamaz.");
            RuleFor(x => x.M_Unvan).NotEmpty().WithMessage("Müşteri Adı Boş Olamaz.");
            RuleFor(x => x.M_Name).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.");
            RuleFor(x => x.M_Surname).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.");
            RuleFor(x => x.M_About).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.");
            RuleFor(x => x.M_Unvan).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.");



        }
    }
}
