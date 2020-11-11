using System;
using System.Collections.Generic;
using System.Text;

namespace StoreLibrary
{
    public class Items
    {
        internal decimal Price { get; }

        internal string ItemName { get; }

        internal string ItemID { get; }

        private static int itemID = 1;
        

        public Items(string itemName)
        {
             
            this.ItemName = itemName;
            this.ItemID = itemID.ToString();
            itemID++;

        }

       
    }

    public class Order
    {
        private int numberOfOrders = 0;
        private Dictionary<Items, int> contents;
        private readonly int orderID;

        private string orderCustomer;
        private string orderLocation;


        internal Dictionary<Items, int> Contents { get => contents; set => contents = value; }


        public string OrderCustomer => orderCustomer;
        public string OrderLocation => orderLocation;
        public int OrderID => orderID;

        
        public Order (List<Items> items, StoreLocation location, Customer customer)
        {
            this.orderID = numberOfOrders++;
            this.orderLocation = location.StoreID;
            this.orderCustomer = customer.ID;

            var dictionary1 = new Dictionary<Items, int>();
            foreach (Items item in items)
            {
                if (dictionary1.ContainsKey(item)) dictionary1[item]++;
                else dictionary1.Add(item, 1);
            }
            this.contents = dictionary1;
        }

    }

    
}
