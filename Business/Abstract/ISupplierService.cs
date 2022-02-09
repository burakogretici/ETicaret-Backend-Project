﻿using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISupplierService 
    {
        IResult Add(Supplier supplier);
        IResult Update(Supplier supplier);
        IResult Delete(Supplier supplier);

        IDataResult<IEnumerable<Supplier>> GetAll();
        IDataResult<Supplier> GetById(long id);
    }
}
