﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class FornecedorEntity
    {
        public int IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }


        public int IdProduto { get; set; }

        #region Associações

        //public FuncaoEntity Funcao { get; set; }
        //public SetorEntity Setor { get; set; }

        #endregion
    }
}