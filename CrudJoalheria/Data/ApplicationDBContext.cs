using CrudJoalheria.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudJoalheria.Data
{
	public class ApplicationDBContext:DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) : base(options)
		{

		}

		public DbSet<JoiaModel> Joia { get; set; }
	}
}
