using System;
using System.Collections.Generic;
using System.Text;


using System.Threading.Tasks;

namespace AheraTaera_CMS
{
    public class Utility
    {
        public Utility()
        {
        }


        public int GetDiscount(int age, string city, bool weekenddelivery)
        {


            /*
            b. If age is above 60, you get a 10% senior discount.
            c. If products are brought on weekends, you get a 2% discount.
            d. Customers from Auckland and Wellington will get a 1% discount.
            4] There are different delivery mechanisms of products to customer:
            a. Home delivery through Courier (Needs to be billed $10 extra to the total).

             */

            int discountPercentage = 0;

            if (age >= 60) discountPercentage += 10;
            if (weekenddelivery) discountPercentage += 2;
            if(city=="Auckland" || city =="Wellington") discountPercentage += 1;

            return discountPercentage;
        }


        public float GetShipmentCharge(bool homedelivery)
        {
            if (homedelivery) return 10;
            else return 0;

        }
    }



}



