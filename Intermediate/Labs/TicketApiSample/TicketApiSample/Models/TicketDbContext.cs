using Microsoft.EntityFrameworkCore;

namespace TicketApiSample.Models
{
	public class TicketDbContext : DbContext
	{
		public DbSet<TicketItem> TicketItems { get; set; }
	}
}
