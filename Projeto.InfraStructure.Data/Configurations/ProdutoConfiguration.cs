using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.InfraStructure.Data.Configurations
{
    public class ProdutoConfiguration
        : IEntityTypeConfiguration<ProdutoEntity>
    {
        public void Configure(EntityTypeBuilder<ProdutoEntity> builder)
        {
            builder.HasKey(s => s.IdProduto);
        }
    }
}
