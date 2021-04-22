using Microsoft.EntityFrameworkCore;
using RhRecrutamento.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhRecrutamento.Data
{
	public class DataContext : DbContext
	{

        public DbSet<Vaga> Vagas { get; set; }
		public DbSet<Candidato> Candidatos { get; set; }
		public DataContext(DbContextOptions<DataContext> options) 
			: base(options)
		{
		}

	}
}
