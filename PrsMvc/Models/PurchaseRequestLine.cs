using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrsMvc.Models
{
	public class PurchaseRequestLine
	{
		public int Id { get; set; }
		public int PurchaseRequestId { get; set; }
		public int ProductId { get; set; }
		public int Quanity { get; set; }
		public decimal Price { get; set; }

		public PurchaseRequestLine() { }
	}
}