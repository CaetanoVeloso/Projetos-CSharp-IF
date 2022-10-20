using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace viuvo_supermercado
{
    internal class Banco_Pedidos
    {
        public static BindingList<Pedido> Pedidos { get; set; }
        public static List<Produto> Produtos { get; set; }

        static Banco_Pedidos()
        {
            Produto p0 = new Produto(0,"Abacaxi_0",10.00m);
            Produto p1 = new Produto(1,"Abacaxi_1",20.00m);
            Produto p2 = new Produto(2,"Abacaxi_2",30.00m);
            Produto p3 = new Produto(3,"Abacaxi_3",40.00m);
            Produto p4 = new Produto(4,"Abacaxi_4",50.00m);
            Produto p5 = new Produto(5,"Abacaxi_5",60.00m);
            Produto p6 = new Produto(6,"Abacaxi_6",70.00m);
            Produto p7 = new Produto(7,"Abacaxi_7",80.00m);
            Produto p8 = new Produto(8,"Abacaxi_8",90.00m);
            Produto p9 = new Produto(9, "Abacaxi_9", 100.00m);
            Produto p10 = new Produto(10, "Abacaxi_10", 110.00m);
            Produtos = new List<Produto>();
            Produtos.Add(p0);
            Produtos.Add(p1);
            Produtos.Add(p2);
            Produtos.Add(p3);
            Produtos.Add(p4);
            Produtos.Add(p5);
            Produtos.Add(p6);
            Produtos.Add(p7);
            Produtos.Add(p8);
            Pedidos = new BindingList<Pedido>();
        }

        public static List<Produto> LocalizarProdutoPorCodigo(Int32 codigo)
        {
            List<Produto> produtos = new List<Produto>();

            foreach (Produto p in Produtos)
            {
                if (codigo == p.Codigo)
                {
                    produtos.Add(p);
                }
            }
            return produtos;

        }

        public static List<Produto> LocalizarProdutoPorParteNome(String input)
        {
            List<Produto> produtos = new List<Produto>();

            foreach (Produto produto in Produtos)
            {
                if (produto.Nome.ToLower().Contains(input.ToLower()))
                {
                    produtos.Add(produto);
                }
            }
            return produtos;
        }
    }
}
