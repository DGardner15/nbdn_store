using System;

namespace nothinbutdotnetstore.model
{
	public class Product
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }

		public new string ToString()
		{
			return Name + "($" + Price + ")";
		}
	}
}