﻿using System;
using System.Collections.Generic;
using System.Text;

using Business.Abstact;

using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {

            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            return _productDal.GetAll();
        }
    }
}
