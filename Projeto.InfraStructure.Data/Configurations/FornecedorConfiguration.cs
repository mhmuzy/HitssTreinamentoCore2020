using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.InfraStructure.Data.Configurations
{
    public class FornecedorConfiguration
        : IEntityTypeConfiguration<FornecedorEntity>
    {
        public void Configure(EntityTypeBuilder<FornecedorEntity> builder)
        {
            builder.HasKey(f => f.IdFornecedor);

            #region Relacionamentos

            builder.HasOne(f => f.Produto);
                //.WithMany(s => s.)
                //.HasForeignKey(f => f.Id)
                //.OnDelete(DeleteBehavior.Restrict);

            
            #endregion
        }
    }
}
