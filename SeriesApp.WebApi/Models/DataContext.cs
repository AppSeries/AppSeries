using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace SeriesApp.WebApi.Models
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext> Options) : base (Options) 
        {

        }

        public DbSet<tb_usuarios> tb_usuarios { get;set; }
    }
}