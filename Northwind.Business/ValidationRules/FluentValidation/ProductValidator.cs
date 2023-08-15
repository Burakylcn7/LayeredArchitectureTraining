using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        //Fluent Validation
        //.GreaterThan(100).WithMessage(“100 den büyük olmalıdır.”) .LessThan(1000).WithMessage(“1000 den küçük olmalıdır.”)
        public ProductValidator()
        {
            RuleFor(P => P.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Olamaz");
            RuleFor(P => P.CategoryId).NotEmpty();
            RuleFor(P => P.UnitPrice).NotEmpty();
            RuleFor(P => P.UnitsInStock).NotEmpty();
            RuleFor(P => P.QuantityPerUnit).NotEmpty();

            RuleFor(P => P.UnitPrice).GreaterThan(0);
            RuleFor(P => P.UnitPrice).GreaterThan(10).When(P => P.CategoryId == 2);
            RuleFor(P => P.UnitsInStock).GreaterThanOrEqualTo((short)0);

            RuleFor(P => P.ProductName).Must(StartWithA).WithMessage("Ürün A Harfi ile Başlamıyor");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
