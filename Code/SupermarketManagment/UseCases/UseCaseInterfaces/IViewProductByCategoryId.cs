using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewProductByCategoryId
    {
        IEnumerable<Product> Execute(int categoryId);
    }
}