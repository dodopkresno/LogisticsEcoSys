using FluentValidation;
using Inventory.Application.Requests.Uom;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Requests.Validators
{
    public class EditUomValidator : AbstractValidator<EditUom>
    {
        public EditUomValidator()
        {
            RuleFor(u => u.UID).NotEmpty();
            RuleFor(u => u.name).NotEmpty().MaximumLength(15);
            RuleFor(u => u.description).NotEmpty().MaximumLength(200);
            RuleFor(u => u.ratio).NotEmpty();
            RuleFor(u => u.UomCategoryId).NotEmpty();
            RuleFor(u => u.Id).NotEmpty();
        }
    }
}
