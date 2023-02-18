using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.Business
{
    public class Order
    {
        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public string Date { get; set; }
        public string Value { get; set; }
        public string GST { get; set; }
        public string Discount { get; set; }
        public string Total { get; set; }
    }
}