using ApiLoja.Models.Data;
using System;

namespace ApiLoja.Models
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Fornecedor { get; set; }
        public decimal Preco { get; set; }
        public Categoria Categoria { get; set; }
    }
}
