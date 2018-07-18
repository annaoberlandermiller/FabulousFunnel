using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FabulousFunnel.Models {
	public class Gig {
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }
		public string City { get; set; }
		public string State { get; set; }

		[Required]
		public string Date { get; set; }

		[Required]
		public Menu MenuItems { get; set; }

		[Required]
		public decimal TotalSales { get; set; }

		public string Notes { get; set; }

		public virtual List<Menu> Menus { get; set; }
		public virtual List<Employee> Employees { get; set; }
		
		public Gig() { }

	}
}