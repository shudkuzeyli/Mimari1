using Microsoft.EntityFrameworkCore;
using Mimari1.Entities.Concrete.LibraryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari1.Dal.Context
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

		public DbSet<Bolum> Bolum { get; set; }
		public DbSet<BolumOgrenci> BolumOgrenci { get; set; }
		public	DbSet<Ogrenci> Ogrenci { get; set; }
		public DbSet<Fakulte> Fakulte { get; set; }
	}
}
