using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista01
{
    class Exercicio11
    {
        public Exercicio11()
        {
            /*11. Solicite o nome, valor e a quantidade de produtos, enquanto o nome for diferente de
sair, ao final deve-se aplicar ao valor total da compra um desconto de 5%.*/
            
            string nome = "";
            double valorProduto = 0;
            int quantidadeProdutos = 0;

            double valorTotal = 0;
            
            while(nome != "sair")
            {
                Console.Write("Nome do produto, se quiser sair digite 'sair': ");
                nome = Console.ReadLine();
                nome = nome.ToLower();
                if(nome != "sair")
                {
                    Console.Write("\nValor do produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nQuantidade de produtos: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

                    valorTotal = (valorTotal) + (valorProduto * quantidadeProdutos);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar.");
                }
                
            }
            valorTotal = valorTotal / 0.05;
            Console.WriteLine("\nValor final da compra com um desconto de 5% é: R$ " + valorTotal);
        }
    }
}
