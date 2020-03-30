using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class ProdutoEntity
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        #region Associações

        public int IdFornecedor { get; set; }

        public FornecedorEntity Fornecedor { get; set; }

        #endregion
    }
}
