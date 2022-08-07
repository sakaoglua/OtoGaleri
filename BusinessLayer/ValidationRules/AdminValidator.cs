using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{


    public class AdminValidator : AbstractValidator<Adminler>
    {
        public AdminValidator()
        {
            RuleFor(x => x.Admin_Name).NotEmpty().WithMessage("Admin Adı Boş Olamaz.");
            RuleFor(x => x.Admin_Surname).NotEmpty().WithMessage("Admin Soyadı boş olamaz.");
            RuleFor(x => x.Admin_Name).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.");
            RuleFor(x => x.Admin_Surname).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın.");

        }
    }

}
