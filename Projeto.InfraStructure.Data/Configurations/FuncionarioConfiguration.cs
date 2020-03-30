using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.InfraStructure.Data.Configurations
{
    public class FuncionarioConfiguration
        //: IEntityTypeConfiguration<FornecedorEntity>
    {
        //public void Configure(EntityTypeBuilder<FornecedorEntity> builder)
        //{
        //    builder.HasKey(f => f.Id);

        //    #region Relacionamentos

        //    builder.HasOne(f => f.Setor)
        //        .WithMany(s => s.Funcionarios)
        //        .HasForeignKey(f => f.IdSetor)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    builder.HasOne(f => f.Funcao)
        //        .WithMany(f => f.Funcionarios)
        //        .HasForeignKey(f => f.IdFuncao)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    #endregion
        //}
    }
}
