using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using CadastroEstudanteApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroEstudanteApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Estudante> Estudantes { get; set; }
    }
}