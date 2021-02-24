using System;
using System.Collections.Generic;
using System.Text;

using Core.Utilities.Results;

using Entities.Concrete;

namespace Business.Abstact
{
    public interface ICategoryService
    {
        IDataResult <List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
    }
}
