using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.ProductCategory
{

    public abstract class ProductFactory
    {
        protected abstract iProduct MakeProduct();
        public iProduct CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
