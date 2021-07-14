using Microsoft.EntityFrameworkCore;
using Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Config
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public DbSet<ProdutoViewModel> ProdutoViewModel { get; set; }

        private string GetStringConectionConfig()
        {
            string strCon = "Server=TI02\\SQLEXPRESS;Database=api;Trusted_connection=true;MultipleActiveResultSets=true";
            return strCon;
        }
    }
}
