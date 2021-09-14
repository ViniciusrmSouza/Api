using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaApi.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public double Valor { get; set; }
    }
}
