﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Bırakamazsınız");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklamasını Boş Bırakamazsınız");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori Adını En Fazla 50 karakter yapabilirsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adını En Az 3 karakter yapabilirsiniz");
        }
    }
}
