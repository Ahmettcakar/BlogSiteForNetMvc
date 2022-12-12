using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	[Table("Education")]
	public class Education:ModelBase
	{
		
		public string name { get; set; }
		public string description { get; set; }
		public DateTime startDate { get; set; }
		public DateTime endDate { get; set; }

		public Guid? ProfileId { get; set; }
		public virtual Profile profile { get; set; }

	}
}
