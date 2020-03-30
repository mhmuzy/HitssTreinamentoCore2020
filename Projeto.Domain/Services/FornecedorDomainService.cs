using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class FornecedorDomainService
        : BaseDomainService<FornecedorEntity>, IFornecedorDomainService
    {
        private readonly IFornecedorRepository repository;

        public FornecedorDomainService(IFornecedorRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
