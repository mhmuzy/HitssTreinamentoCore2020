using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.InfraStructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.InfraStructure.Data.Repositories
{
    public class ProdutoRepository
        : BaseRepository<ProdutoEntity>, IProdutoRepository
    {
        //atributo
        private readonly DataContext context;

        //construtor para injeção de dependencia
        public ProdutoRepository(DataContext context)
            : base(context)
        {
            this.context = context;
        }
    }
}
