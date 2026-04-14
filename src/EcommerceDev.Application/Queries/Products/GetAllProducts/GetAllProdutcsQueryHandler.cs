using EcommerceDev.Application.Common;

namespace EcommerceDev.Application.Queries.Products.GetAllProducts;

public class GetAllProdutcsQueryHandler : 
    IHandler<GetAllProdutcsQuery, ResultViewModel<List<GetAllProdutcsItemViewModel>>>
{
    public Task<ResultViewModel<List<GetAllProdutcsItemViewModel>>> HandleAsync(GetAllProdutcsQuery request)
    {
        throw new NotImplementedException();
    }
}