using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models
{
    public class ProdutoConsultaModel
    {
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }
    }
}
