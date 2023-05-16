using Common.Application;

namespace Shop.Application.Categories.Remove;

public record RemoveCategoryCommand(long CategoryId) : IBaseCommand;