using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExercicioDaSemana09.Model
{
    public class SemanaContext:DbContext
    {
        public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
        {
        }
        public DbSet<SemanaModel> Semana {get; set;}
    }
}