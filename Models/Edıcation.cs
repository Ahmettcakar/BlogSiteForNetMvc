﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Edıcation:ModelBase
	{
		public string name { get; set; }
		public string description { get; set; }
		public DateTime startDate { get; set; }
		public DateTime endDate { get; set; }
	}
}
