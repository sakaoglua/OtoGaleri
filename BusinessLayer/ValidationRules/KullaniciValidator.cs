using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class KullaniciValidator:AbstractValidator<Kullanicilar>
    {
        public KullaniciValidator()
        {
            RuleFor(x => x.K_Adi).NotEmpty().WithMessage("Kullanıcı Adı Boş Olamaz.");
            RuleFor(x => x.K_Sifre).NotEmpty().WithMessage("Şifre boş olamaz.");
            RuleFor(x => x.K_Adi).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.");

        }
    }
}
