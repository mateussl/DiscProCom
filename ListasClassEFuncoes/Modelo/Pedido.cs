using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasClassEFuncoes.Modelo
{
    public class Pedido
    {
        public Pedido(string produto, float preco, int quantidade)
        {
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
            Total =preco*quantidade;
        }

        public string Produto { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public  float Total { get;private set; }
    }
}
