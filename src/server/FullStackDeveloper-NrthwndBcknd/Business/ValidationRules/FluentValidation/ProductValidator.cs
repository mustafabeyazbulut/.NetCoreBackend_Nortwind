using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(expression: p => p.ProductName).NotEmpty();
            RuleFor(expression: p => p.ProductName).Length(2,30);
            RuleFor(expression: p => p.UnitPrice).NotEmpty();
            RuleFor(expression: p => p.UnitPrice).GreaterThan(1);
            RuleFor(expression: p => p.UnitPrice).GreaterThanOrEqualTo(10).When(predicate: p=>p.CategoryId==1);
            //RuleFor(expression: p => p.ProductName).Must(StartWithStartA);
        }

        //private bool StartWithStartA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
