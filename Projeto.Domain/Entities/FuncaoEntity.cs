using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class FuncaoEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        #region Associações

        public List<FornecedorEntity> Funcionarios { get; set; }

        #endregion
    }
}
