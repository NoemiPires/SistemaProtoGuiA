using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaProtoGuiA
{
    public class Repository : DbContext
    {
        private static readonly string _connectionParams = @"server=127.0.0.1
;port=3307;uid=root;pwd=;database=sistemaprotoagui";

        public DbSet<Usuario> Usuarios { get; set; }

        public Repository() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySQL(_connectionParams);
        }

    }
}
