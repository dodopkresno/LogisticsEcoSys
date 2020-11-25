using FluentValidation;
using Inventory.Application.Interface;
using Inventory.Application.Requests.UomCategory;
using System.Linq;

namespace Inventory.Application.Requests.Validators
{
    public class EditUomCategoryValidator : AbstractValidator<EditUomCategory>
    {
        //private readonly IUomCategoryService _uomCategoryService;
        public EditUomCategoryValidator()
        {
            //_uomCategoryService = uomCategoryService;
            RuleFor(uc => uc.UCID).NotEmpty();
            RuleFor(uc => uc.name).NotEmpty().MaximumLength(15);
            RuleFor(uc => uc.description).NotEmpty().MaximumLength(200);
            RuleFor(uc => uc.Id).NotEmpty();
            //RuleFor(uc => uc.Id).NotEmpty().Must(MeasureTypeExists).WithMessage("Measure Type doesn't exists"); 
        }
        //private bool MeasureTypeExists(int id)
        //{
        //    if (string.IsNullOrEmpty(id.ToString())) return false;

        //    var data = _uomCategoryService.GetMeasureType();
        //    var dataMeasureType = data.Where(dt => dt.Id.Equals(id)).FirstOrDefault();
        //    return dataMeasureType != null;
        //}
    }
}
