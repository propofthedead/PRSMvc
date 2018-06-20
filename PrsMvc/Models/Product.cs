using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrsMvc.Models
{
	public class Product
	{
		public int Id { get; set; }
		public int VendorId { get; set; }
		public string Name { get; set; }
		public string PartNumber { get; set; }
		public string Description { get; set; }
		public string Unit { get; set; }
		public string PhotoPath { get; set; }
		public bool Active { get; set; }

		public Product() { }
	}
}