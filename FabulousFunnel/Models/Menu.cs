﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FabulousFunnel.Models {
	public class Menu {
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public decimal Price { get; set; }
		public string Notes { get; set; }

		public Menu() { }
	}
}