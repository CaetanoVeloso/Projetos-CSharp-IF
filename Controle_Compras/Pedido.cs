using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace viuvo_supermercado
{
    internal class Pedido
    {
        public static Int64 Serial { get; set; }
        public Int64 NotaFiscal { get; set; }
        public BindingList<Item> Itens { get; set; }

        public Pedido()
        {
            Itens = new BindingList<Item>();
            Serial++;
        }
        static Pedido()
        {
            Serial = DateTime.Now.Year;
            while (Serial > 1000)
            {
                Serial = Serial % 100;
                Serial = Serial * 1000000000;
            }

        }
        public Decimal CalcularTotal()
        {
            Decimal total = 0;
            foreach (Item item in Itens)
            {
                total = total + item.CalcularTotal();
            }
            return total;
        }
        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public override string ToString()
        {
            return NotaFiscal + " R$ " + CalcularTotal();

        }
    }
}
