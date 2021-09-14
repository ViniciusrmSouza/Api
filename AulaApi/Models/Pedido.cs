using System;
using System.Collections.Generic;

namespace AulaApi.Models
{
    public class Pedido
    {
        public int Numero { get; set; }
        public DateTime Dt_Pedido { get; set; }
        public string Tipo { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();

    }
}
