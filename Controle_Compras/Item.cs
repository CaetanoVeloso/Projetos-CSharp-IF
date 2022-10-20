using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viuvo_supermercado
{
    internal class Item
    {
        public Int16 Quantidade { get; set; }
        public Produto Produto { get; set; }

        public Item(short quantidade, Produto produto)
        {
            Quantidade = quantidade;
            Produto = produto;
        }

        public Item()
        {
        }

        public Decimal CalcularTotal()
        {
            return Quantidade * Produto.Preco;
        }

        public override string ToString()
        {
            return Quantidade + " x " + Produto + " = R$ " + CalcularTotal();
        }
    }
}
