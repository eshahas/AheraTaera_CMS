using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.ProductCategory
{
    public class DigitalFactory : ProductFactory
    {
        protected override iProduct MakeProduct()
        {
            iProduct product = new Digital();
            return product;
        }
    }
}
