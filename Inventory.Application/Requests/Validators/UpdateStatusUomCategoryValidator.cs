using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Inventory.Application.Requests.Validators
{
    class UpdateStatusUomCategoryValidator : AbstractValidator<UpdateStatusUomCategory>
    {
        public UpdateStatusUomCategoryValidator()
        {
            RuleFor(uc => uc.ucid).NotEmpty();
            RuleFor(uc => uc.userBy).NotEmpty();
            RuleFor(uc => uc.isActive).NotEmpty();
        }
    }
}
