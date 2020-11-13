using FluentValidation;
using Inventory.Application.Requests.UomCategory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Requests.Validators
{
    public class AddUoMCategoryValidator : AbstractValidator<AddUoMCategory>
    {
        public AddUoMCategoryValidator()
        {
            RuleFor(uc => uc.name).NotEmpty().MaximumLength(15);
            RuleFor(uc => uc.description).NotEmpty().MaximumLength(200);
            RuleFor(uc => uc.Id).NotEmpty();
        }
    }
}
