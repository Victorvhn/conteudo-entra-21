using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista01
{
    class Exercicio12
    {
        public Exercicio12()
        {
            /*12. Solicite o nome, valor, quantidade enquanto a quantidade de produtos for menor que
5. Ao final deve-se aplicar um desconto de R$ 150,00.*/
            int quantidade = 0;
            double valorFinal = 0;
            
            while(quantidade < 5)
            {
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("\nValor do produto: ");
                double valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nQuantidade de produtos: ");
                int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

                valorFinal = valorFinal + valorProduto * quantidadeProdutos;
                Console.Clear();
                quantidade++;
            }
            valorFinal = valorFinal - 150;

            if(valorFinal > 0)
            {
                Console.WriteLine(String.Format("O valor final com um desconto de R$ 150,00 é: R$ {0:n}",valorFinal));
            }
            else
            {
                Console.WriteLine("A compra fica de graça.");
            }
        }
    }
}
