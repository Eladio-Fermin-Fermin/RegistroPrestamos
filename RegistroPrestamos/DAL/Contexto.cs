using Microsoft.EntityFrameworkCore;
using RegistroPrestamos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamos.DAL
{
    public class Contexto :DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
