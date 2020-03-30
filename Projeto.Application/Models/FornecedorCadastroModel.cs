using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models
{
    public class FornecedorCadastroModel
    {
        [Required(ErrorMessage = "Nome do(a) fornecedor(a) obrigatório(a)!")]
        [MinLength(1, ErrorMessage = "O nome fornecedor deve conter no mínimo {0} caracter!")]
        [MaxLength(150, ErrorMessage = "O nome do fornecedor deve conter no máximo {0} caracter!")]
        public string Nome { get; set; }

        [MinLength(14, ErrorMessage = "O cnpj do fornecedor deve conter no mínimo {0} caracter!")]
        [MaxLength(14)]
        public string Cnpj { get; set; }
    }
}
