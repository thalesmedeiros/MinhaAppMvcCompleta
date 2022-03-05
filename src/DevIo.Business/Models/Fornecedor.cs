﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasica.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }

        public string Documento  { get; set; }
        
        public TipoFornecedor TipoFornecedor { get; set; }
       
        public Endereco Endereco { get; set; }
       
        [DisplayName("Ativo?")]
        public bool Ativio { get; set; }

        /* ef relations*/

        public IEnumerable<Produto> Produtos { get; set; }
    }
}