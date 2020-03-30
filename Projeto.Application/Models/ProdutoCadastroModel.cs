﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models
{
    public class ProdutoCadastroModel
    {
        [Required(ErrorMessage = "O nome do produto é obrigatório!")]
        [MinLength(1, ErrorMessage = "O nome do produto deve conter no mínimo {0} caracter!")]
        [MaxLength(150, ErrorMessage = "O nome do produto deve conter no máximo {0} caracter!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório!")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "A quantidade de estoque do produto é obrigatório!")]
        public int Quantidade { get; set; }
    }
}