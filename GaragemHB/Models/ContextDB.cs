using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GaragemHB.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
        public DbSet<Cores> Cor { get; set; }
        public DbSet<RegistroPeriodo> RegistroPeriodo { get; set; }
        public DbSet<Valor> Valor { get; set; }
        public DbSet<TermoDeUso> TermoDeUso { get; set; }
        
        
    }
}