using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrsMvc.Models
{
	public class PurchaseRequest
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Justification { get; set; }
		public string Description { get; set; }
		public string DeliveryMode { get; set; }
		public string Status { get; set; }
		public bool Active { get; set; }
		public decimal Total { get; set; }
		public string ReasonForRejection { get; set; }

		public PurchaseRequest() { }
	}
}