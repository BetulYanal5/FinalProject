using Core.DataAccess;
using Entities.Concrete;//Entities katmanındaki Product ı kullandığım için referans verdim
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }
}
//Code Refactoring - kodun iyileştirilmesi