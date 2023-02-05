using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.ProductCategory
{

    public class Digital : iProduct
    {

        public string GetProductType()
        {
            return "Digital";
        }

        public bool Display()
        {
            return true;
        }
    }
}
