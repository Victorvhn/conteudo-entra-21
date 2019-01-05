using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    class Exercicio06
    {
        public Exercicio06()
        {
            /*A padaria do joão necessita armazenar os pedidos dos seus clientes, cada cliente
poderá realizar quantos pedidos desejar, porém para que o cliente possa solicitar
estes produtos o cardápio deve ser apresentado para ele.*/

            int pedido = 0;
            double totalCompra = 0;

            int quantidadePedidos = 0;
            int quantidadeBolos = 0;
            int quantidadeDoces = 0;
            int quantidadeSanduiches = 0;
            int quantidadePizzas = 0;
            double mediaProdutos = 0;

            Console.WriteLine("Olá, faça quantos pedidos quiser, no final será apresentado o total dos produtos e a quantidade de produtos pedidos.\n\n");
            while (pedido != 16)
            {

                Console.WriteLine(" _________________________________________________________________________________________"+
                                  "\n| Código   | Tipos            | Nome                                         | Valor      |"+
                                  "\n|----------|------------------|----------------------------------------------|------------|"+
                                  "\n| 1        | Bolos            | Bolo Brigadeiro                              | R$ 29,50   |"+
                                  "\n| 2        | Bolos            | Bolo Floresta Negra                          | R$ 2,00    |"+
                                  "\n| 3        | Bolos            | Bolo Leite com Nutella                       | R$ 29,23   |"+
                                  "\n| 4        | Bolos            | Bolo Mousse de Chocolate                     | R$ 7,10    |"+
                                  "\n| 5        | Bolos            | Bolo Nega Maluca                             | R$ 19,33   |"+
                                  "\n| 6        | Doces            | Bomba de Creme                               | R$ 17,71   |"+
                                  "\n| 7        | Doces            | Bomba de Morango                             | R$ 4,82    |"+
                                  "\n| 8        | Sanduíches       | Filé-Mignon com fritas e cheddar             | R$ 21,16   |"+
                                  "\n| 9        | Sanduíches       | Hambúrguer com queijos, champignon e rúcula  | R$ 12,70   |"+
                                  "\n| 10       | Sanduíches       | Provolone com salame                         | R$ 19,70   |"+
                                  "\n| 11       | Sanduíches       | Vegetariano de berinjela                     | R$ 28,22   |"+
                                  "\n| 12       | Pizzas           | Calabresa                                    | R$ 8,98    |"+
                                  "\n| 13       | Pizzas           | Napolitana                                   | R$ 0,42    |"+
                                  "\n| 14       | Pizzas           | Peruana                                      | R$ 18,36   |"+
                                  "\n| 15       | Pizzas           | Portuguesa                                   | R$ 27,50   |"+
                                  "\n|----------|------------------|----------------------------------------------|------------|"+
                                  "\n| 16                          | Sair                                                      |"+
                                  "\n|_____________________________|___________________________________________________________|");

                Console.Write("\n\nFaça pedido: ");
                pedido = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (pedido != 16)
                {
                    if (pedido == 1)
                    {
                        totalCompra = totalCompra + 29.50;
                    }
                    if (pedido == 2)
                    {
                        totalCompra = totalCompra + 2;
                    }
                    if (pedido == 3)
                    {
                        totalCompra = totalCompra + 29.23;
                    }
                    if (pedido == 4)
                    {
                        totalCompra = totalCompra + 7.10;
                    }
                    if (pedido == 5)
                    {
                        totalCompra = totalCompra + 19.33;
                    }
                    if (pedido == 6)
                    {
                        totalCompra = totalCompra + 17.71;
                    }
                    if (pedido == 7)
                    {
                        totalCompra = totalCompra + 4.82;
                    }
                    if (pedido == 8)
                    {
                        totalCompra = totalCompra + 21.16;
                    }
                    if (pedido == 9)
                    {
                        totalCompra = totalCompra + 12.70;
                    }
                    if (pedido == 10)
                    {
                        totalCompra = totalCompra + 19.70;
                    }
                    if (pedido == 11)
                    {
                        totalCompra = totalCompra + 28.22;
                    }
                    if (pedido == 12)
                    {
                        totalCompra = totalCompra + 8.98;
                    }
                    if (pedido == 13)
                    {
                        totalCompra = totalCompra + 0.42;
                    }
                    if (pedido == 14)
                    {
                        totalCompra = totalCompra + 18.36;
                    }
                    if (pedido == 15)
                    {
                        totalCompra = totalCompra + 27.50;
                    }

                    if ((pedido >= 1) && (pedido <= 5))
                    {
                        quantidadeBolos = quantidadeBolos + 1;
                    }
                    else if ((pedido >= 6) && (pedido <= 7))
                    {
                        quantidadeDoces = quantidadeDoces + 1;
                    }
                    else if ((pedido >= 8) && (pedido <= 11))
                    {
                        quantidadeSanduiches = quantidadeSanduiches + 1;
                    }
                    else
                    {
                        quantidadePizzas = quantidadePizzas + 1;
                    }

                    quantidadePedidos = quantidadePedidos + 1;
                }
                else
                {
                    Console.WriteLine("Obrigado, volte sempre!\n");
                }
            }
            mediaProdutos = totalCompra / quantidadePedidos;

            Console.WriteLine(String.Format("Você fez {0} pedidos e deve pagar um total de R$ {1}\n\n", quantidadePedidos, totalCompra));
            Console.WriteLine(String.Format("Você pediu {0} bolos.", quantidadeBolos));
            Console.WriteLine(String.Format("Você pediu {0} doces.", quantidadeDoces));
            Console.WriteLine(String.Format("Você pediu {0} sanduíches.", quantidadeSanduiches));
            Console.WriteLine(String.Format("Você pediu {0} pizzas.", quantidadePizzas));
            Console.WriteLine(String.Format("Média: R$ {0:n}", mediaProdutos));
            Console.ReadKey();
        }
    }
}
