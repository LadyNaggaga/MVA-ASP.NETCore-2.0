using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApiSample.Models
{
	public class TicketItem
	{

		public long Id { get; set; }

		public string Concert { get; set; }

		public string Artist { get; set; }

		public bool Available { get; set; }

	}
}
