using System;
using Microsoft.EntityFrameworkCore;
using SalesWeb.Modelos;

namespace SalesWeb.Dados
{
    public class AplicacaoContexto : DbContext
    {
        public AplicacaoContexto(DbContextOptions<AplicacaoContexto> options)
            : base(options)
        { }
        
        public DbSet<Department> Department { get; set; }
    }
}
