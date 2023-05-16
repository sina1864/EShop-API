using Common.Application.Validation;
using FluentValidation;

namespace Shop.Application.Categories.Create;

internal partial class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(r => r.Title)
            .NotNull().NotEmpty().WithMessage(ValidationMessages.required("عنوان"));

        RuleFor(r => r.Slug)
            .NotNull().NotEmpty().WithMessage(ValidationMessages.required("اسلاگ"));
    }
}