using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwashbuckleOwinHostSample.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Tel { get; set; }

		public IList<Tag> Tags { get; set; }
	}
}
