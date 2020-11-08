using System;

namespace StoreApplication
{
	/// <summary>
	/// Summary description for Transaction
	/// </summary>
	public class Transaction
	{
		//Fields
		public decimal Price { get; }

		public DateTime Date { get; }

		public string Product { get; }

		public string ProductID { get; }

		

		//Constructor
		public Transaction(decimal price, string itemName, string itemID, DateTime date)
		{
			// TODO: Add constructor logic here
			this.Price = price;
			this.Date = date;
			this.Product = itemName;
			this.ProductID = itemID;

		}
	}
}
