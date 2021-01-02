using System;
using System.Data.Entity;
using System.Linq;


namespace DAL.Model
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext()
			: base("name=DatabaseContext")
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}

		public DbSet<Blood> Bloods { get; set; }

	}
}