using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recap.Models;

namespace Recap.Data;

public class AppDbContext : DbContext
{
	public AppDbContext()
	{

	}

	public AppDbContext(DbContextOptions options) : base(options)
	{

	}

	public virtual DbSet<Character> Characters { get; set; }
	public virtual DbSet<Place> Places { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LotrDb;Trusted_Connection=True;");
	}


	// Seeda data till db. När vi seedar kan vi ha med id. Annars aldrig
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{

		modelBuilder.Entity<Place>()
			.HasMany(p => p.Characters)
			.WithOne(c => c.Place)
			.OnDelete(DeleteBehavior.Cascade);

		//modelBuilder.Entity<Character>().HasData(new Character()
		//{
		//	CharacterId = 1,
		//	FirstName = "Boromir",
		//	LastName = "Son of Denethor",
		//	Lineage = "Human",
			
		//}, new Character()
		//{
		//	CharacterId = 2,
		//	FirstName = "Legolas",
		//	LastName = "Greenleaf",
		//	Lineage = "Elf"

		//}, new Character()
		//{
		//	CharacterId = 3,
		//	FirstName = "Frodo",
		//	LastName = "Baggins",
		//	Lineage = "Halfling"
		//}
		//);

		//modelBuilder.Entity<Place>().HasData(new Place()
		//{
		//	Location = "Rivendell",
		//	Description = "Elven otherworld, also known as Imladris in Sindarin. Important place in Middle-earth."
		//});
	}
}
