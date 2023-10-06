using SEDataManager.Library.Models;

namespace SEDataManager.Library.DataAccess
{
    public interface IProductData
    {
        List<ProductModel> GetProducts();
    }
}