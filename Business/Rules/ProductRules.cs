using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Rules
{
    public class ProductRules
    {
        private readonly IProductRepository _productDal;

        public ProductRules(IProductRepository productDal)
        {
            _productDal = productDal;
        }

        public IResult CategoryCount(Category category)
        {
            var result = _productDal.CountAsync(c=>c.CategoryId == category.Id).Result;
            if (result == 15)
            {
                return new ErrorResult("En fazla 10 marka olabilir");
            }

            return new SuccessResult();
        }
    }
}