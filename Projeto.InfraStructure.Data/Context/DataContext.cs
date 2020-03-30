using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entities;
using Projeto.InfraStructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.InfraStructure.Data.Context
{
    //REGRA 1) Herdar DbContext
    public class DataContext : DbContext
    {
        //REGRA 2) Sobrescrita do método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de mapeamento (ORM)
            modelBuilder.ApplyConfiguration(new FuncaoConfiguration());
            //modelBuilder.ApplyConfiguration(new SetorConfiguration());
            //modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
        }

        //REGRA 3) Declarar um DbSet para cada entidade (LAMBDA)
        public DbSet<FuncaoEntity> Funcao { get; set; }
        public DbSet<ProdutoEntity> Setor { get; set; }
        public DbSet<FornecedorEntity> Funcionario { get; set; }
    }
}
