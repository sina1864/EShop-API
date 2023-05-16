using Common.Application;
using Shop.Domain.CategoryAgg;

namespace Shop.Application.Categories.Remove;

public class RemoveCategoryCommandHandler : IBaseCommandHandler<RemoveCategoryCommand>
{
    private readonly ICategoryRepository _categoryRepository;
    public RemoveCategoryCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<OperationResult> Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
    {
        var result = await _categoryRepository.DeleteCategory(request.CategoryId);

        if (!result) return OperationResult.Error("امکان حذف این دسته بندی وجود ندارد");

        await _categoryRepository.Save();
        return OperationResult.Success();
    }
}