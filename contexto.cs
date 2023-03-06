using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pim_8.Pages
{
	public class Contexto : DbContext
	{
		public Contexto (DbContextOptions<Contexto> options):base(options)
		{
			Database.EnsureCreated();
		
		}


		public DbSet<Usuario> usuarios {get;set;}
	}
}