using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaApi.Models
{
    public class PedidoItem
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public Produto Produto { get; set; }
    }
}
