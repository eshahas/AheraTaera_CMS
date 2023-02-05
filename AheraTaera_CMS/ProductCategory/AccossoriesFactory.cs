using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.ProductCategory
{

    public class AccossoriesFactory : ProductFactory
    {
        protected override iProduct MakeProduct()
        {
            iProduct product = new Accesories();
            return product;
        }
    }
}
