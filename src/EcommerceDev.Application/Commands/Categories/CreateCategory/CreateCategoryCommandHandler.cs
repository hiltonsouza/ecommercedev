using EcommerceDev.Application.Common;

namespace EcommerceDev.Application.Commands.Categories.CreateCategory;

public class CreateCategoryCommandHandler : 
    IHandler<CreateCategoryCommand, ResultViewModel<Guid>>
{
    public Task<ResultViewModel<Guid>> HandleAsync(CreateCategoryCommand request)
    {
        throw new NotImplementedException();
    }
}