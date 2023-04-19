using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasClassEFuncoes.Modelo
{
    public class Cliente
    {
        public Cliente(string nome, string email)
        {
            Pedidos = new List<Pedido>();
            Nome = nome;
            Email = email;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }

        public float TotalPedido { get; private set; }
        public List<Pedido> Pedidos { get; private set; }

        public void AdicionarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
            TotalPedido = pedido.Total+ TotalPedido;
            // return pedido.count;
        }



    }
}
