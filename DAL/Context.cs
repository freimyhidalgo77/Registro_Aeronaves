using Microsoft.EntityFrameworkCore;
using RegistroAeronaves.Models;

namespace RegistroAeronaves.DAL
{
	public class Context : DbContext
	{

		public Context(DbContextOptions<Context> options) : base(options)
		{
		}

		public DbSet<Aeronaves> Aeronaves { get; set; }

	}

}
