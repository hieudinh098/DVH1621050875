using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DVH1621050875.Models
{
	public partial class DVH1621050875Db : DbContext
	{
		public DVH1621050875Db()
			: base("name=DVH1621050875")
		{
		}

		public virtual DbSet<Lecture> Lectures { get; set; }
		public virtual DbSet<Person> People { get; set; }
		public virtual DbSet<Student> Students { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Lecture>()
				.Property(e => e.PersonId)
				.IsUnicode(false);

			modelBuilder.Entity<Person>()
				.Property(e => e.PersonId)
				.IsUnicode(false);
			modelBuilder.Entity<Person>()
				.Property(e => e.PersonName)
				.HasColumnName("PersonName");

			modelBuilder.Entity<Student>()
				.Property(e => e.PersonId)
				.IsUnicode(false);
		}
	}
}
