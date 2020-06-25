using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Produto()
        {
        }

        public Produto(int id, string nome, string descricao, double valor)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }
    }
}
