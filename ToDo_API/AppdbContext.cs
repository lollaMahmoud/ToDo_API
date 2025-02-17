using Microsoft.EntityFrameworkCore;
using ToDo_API.Models;

namespace ToDo_API
{
	public class AppdbContext : DbContext
	{
		public AppdbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<_Task> Tasks { get; set; }
	}
}
