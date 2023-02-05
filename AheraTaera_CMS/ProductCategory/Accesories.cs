using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.ProductCategory
{

    public class Accesories : iProduct
    {

        public string GetProductType()
        {
            return "Accesories";
        }

        public bool Display()
        {
            return true;

        }
    }
}
