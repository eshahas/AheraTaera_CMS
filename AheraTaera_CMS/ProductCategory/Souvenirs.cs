using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.ProductCategory
{

    public class Souvenirs : iProduct
    {

       public string GetProductType()
        {
            return "Souvenirs";
        }

        public bool Display()
        {
            return true;
        }

    }

}
