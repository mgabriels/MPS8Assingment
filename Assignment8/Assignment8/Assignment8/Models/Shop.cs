using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8
{
    public class Shop
    {
        public string StoreName { get; set; }
        public string PhoneNumber { get; set; }
        public string StoreLocation{ get; set; }
        

        private List<CustomerInformation> ShoppingCustomers { get; set; }



        public Shop(string storeName, string phoneNumber, string storeLocation)
        {
            StoreName = storeName;
            PhoneNumber = phoneNumber;
            StoreLocation = storeLocation;
        }
    }
}