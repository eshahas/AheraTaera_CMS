using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.ProductCategory
{

    public class SouvenirsFactory : ProductFactory
    {
        protected override iProduct MakeProduct()
        {
            iProduct product = new Souvenirs();
            return product;
        }
    }
}
