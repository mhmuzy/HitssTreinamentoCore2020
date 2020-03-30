using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models
{
    public class FornecedorConsultaModel
    {
        public int IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }


        public int IdProduto { get; set; }

    }
}
