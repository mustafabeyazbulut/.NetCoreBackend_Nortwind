using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // temel veriye erisim ; insert, delete, update
    public interface IProductDal:IEntityRepository<Product>  
    {
    }
}
