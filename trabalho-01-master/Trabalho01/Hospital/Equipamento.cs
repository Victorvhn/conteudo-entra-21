using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Equipamento
    {
        string[] nomesEquipamentos = new string[100];
        string[] marcasEquipamentos = new string[100];
        string[] tiposEquipamentos = new string[100];
        int[] quantidadeEquipamentos = new int[100];
        int atual = 0;

        bool validacaoNomeEquipamentos = true;
        bool validacaoMarcaEquipamentos = true;
        bool validacaoTipoEquipamentos = true;
        bool validacaoQuantidadeEquipamentos = true;

        public void CastrarEquipamento()
        {
            Console.Clear();
            Console.WriteLine("Passo 1 de 4\n");
            Console.Write("Nome: ");
            nomesEquipamentos[atual] = Console.ReadLine().ToLower();
            while (validacaoNomeEquipamentos == true)
            {
                if (nomesEquipamentos[atual].Length < 3)
                {
                    Console.Clear();
                    Console.WriteLine("Passo 1 de 4\n");
                    Console.WriteLine("Nome inválido");
                    Console.Write("Nome: ");
                    nomesEquipamentos[atual] = Console.ReadLine();
                }
                else
                {
                    validacaoNomeEquipamentos = false;
                }
            }
            Console.Clear();
            Console.WriteLine("Passo 2 de 4\n");
            Console.WriteLine("Nome: " + nomesEquipamentos[atual]);

            Console.Write("Marca: ");
            marcasEquipamentos[atual] = Console.ReadLine();
            while (validacaoMarcaEquipamentos == true)
            {
                if (marcasEquipamentos[atual].Length < 3)
                {
                    Console.Clear();
                    Console.WriteLine("Passo 2 de 4\n");
                    Console.WriteLine("Marca inválida");
                    Console.Write("Marca: ");
                    marcasEquipamentos[atual] = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    validacaoMarcaEquipamentos = false;
                }
            }

            Console.Clear();
            Console.WriteLine("Passo 3 de 4\n");
            Console.WriteLine(String.Format("Nome: {0} \nMarca: {1}", nomesEquipamentos[atual], marcasEquipamentos[atual]));

            Console.Write("Tipo: ");
            tiposEquipamentos[atual] = Console.ReadLine();
            while (validacaoTipoEquipamentos == true)
            {
                if (tiposEquipamentos[atual].Length < 5)
                {
                    Console.Clear();
                    Console.WriteLine("Passo 3 de 4\n");
                    Console.WriteLine("Tipo inválida");
                    Console.Write("Tipo: ");
                    tiposEquipamentos[atual] = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    validacaoTipoEquipamentos = false;
                }
            }

            Console.Clear();
            Console.WriteLine("Passo 4 de 4\n");
            Console.WriteLine(String.Format("Nome: {0}\nMarca: {1} \nTipo: {2}", nomesEquipamentos[atual], marcasEquipamentos[atual], tiposEquipamentos[atual]));

            validacaoQuantidadeEquipamentos = true;
            while (validacaoQuantidadeEquipamentos == true)
            {
                try
                {
                    Console.Write("Quantidade: ");
                    quantidadeEquipamentos[atual] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validacaoQuantidadeEquipamentos = false;
                    if (quantidadeEquipamentos[atual] <= 0)
                    {
                        Console.WriteLine("Por favor, insira uma quantidade maior que 0");
                        validacaoQuantidadeEquipamentos = true;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Passo 4 de 4\n");
                    Console.WriteLine("Deve conter apenas números em \"Quantidade\"");
                }
            }

            Console.Clear();
            Console.WriteLine("Essas foram as informações cadastradas, qualquer erro arrumar no menu editar.\n");
            Console.WriteLine(String.Format("Nome: {0}\nMarca: {1} \nTipo: {2} \nQuantidade: {3}", nomesEquipamentos[atual], marcasEquipamentos[atual], tiposEquipamentos[atual], quantidadeEquipamentos[atual]));

            atual++;

        }

        public void EditarEquipamentos()
        {
            Console.Clear();
            Console.Write("Digite o nome do equipamento que você quer editar.\nNome: ");
            string nomeEditar = Console.ReadLine().ToLower();

            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomeEditar == nomesEquipamentos[i])
                {
                    posicao = i;
                }
            }

            if (posicao != -1)
            {

                validacaoNomeEquipamentos = true;
                validacaoMarcaEquipamentos = true;
                validacaoTipoEquipamentos = true;
                validacaoQuantidadeEquipamentos = true;

                {

                    Console.Clear();
                    Console.WriteLine("Registro encontrado!");
                    Console.Write("Nome: ");
                    nomesEquipamentos[posicao] = Console.ReadLine();
                    while (validacaoNomeEquipamentos == true)
                    {
                        if (nomesEquipamentos[posicao].Length < 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Nome inválido");
                            Console.Write("Nome: ");
                            nomesEquipamentos[posicao] = Console.ReadLine();
                        }
                        else
                        {
                            validacaoNomeEquipamentos = false;
                        }
                    }

                    Console.Clear();
                    Console.WriteLine("Nome: " + nomesEquipamentos[posicao]);

                    Console.Write("Marca: ");
                    marcasEquipamentos[posicao] = Console.ReadLine();
                    while (validacaoMarcaEquipamentos == true)
                    {
                        if (marcasEquipamentos[posicao].Length < 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Marca inválida");
                            Console.Write("Marca: ");
                            marcasEquipamentos[posicao] = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            validacaoMarcaEquipamentos = false;
                        }
                    }

                    Console.Clear();
                    Console.WriteLine(String.Format("Nome: {0} \nMarca: {1}", nomesEquipamentos[posicao], marcasEquipamentos[posicao]));

                    Console.Write("Tipo: ");
                    tiposEquipamentos[posicao] = Console.ReadLine();
                    while (validacaoTipoEquipamentos == true)
                    {
                        if (tiposEquipamentos[posicao].Length < 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Tipo inválida");
                            Console.Write("Tipo: ");
                            tiposEquipamentos[posicao] = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            validacaoTipoEquipamentos = false;
                        }
                    }

                    Console.Clear();
                    Console.WriteLine(String.Format("Nome: {0}\nMarca: {1} \nTipo: {2}", nomesEquipamentos[posicao], marcasEquipamentos[posicao], tiposEquipamentos[posicao]));

                    while (validacaoQuantidadeEquipamentos == true)
                    {
                        try
                        {
                            Console.Write("Quantidade: ");
                            quantidadeEquipamentos[posicao] = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            validacaoQuantidadeEquipamentos = false;
                            if (quantidadeEquipamentos[posicao] <= 0)
                            {
                                Console.WriteLine("Por favor, insira uma quantidade maior que 0");
                                validacaoQuantidadeEquipamentos = true;

                            }
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Deve conter apenas números em \"Quantidade\"");
                        }
                    }

                    Console.Clear();
                    Console.WriteLine(String.Format("Nome: {0}\nMarca: {1} \nTipo: {2} \nQuantidade: {3}", nomesEquipamentos[posicao], marcasEquipamentos[posicao], tiposEquipamentos[posicao], quantidadeEquipamentos[posicao]));




                }
            }
        }

        public void ListarEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("Lista de todos os equipamentos do hospital: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(String.Format("\nNome : {0} \nMarca: {1} \nTipo: {2} \nQuantidade em estoque: {3}", nomesEquipamentos[i], marcasEquipamentos[i], tiposEquipamentos[i], quantidadeEquipamentos[i]));
            }
            Console.ReadKey();
        }

        public void BuscarEquipamentos()
        {

            Console.Clear();
            Console.Write("Digite um nome para visualizar os dados do equipamento.\nNome: ");
            string nomeBuscado = Console.ReadLine().ToLower();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBuscado == nomesEquipamentos[i])
                {
                    Console.WriteLine(String.Format("\nNome : {0} \nMarca: {1} \nTipo: {2} \nQuantidade em estoque: {3}", nomesEquipamentos[i], marcasEquipamentos[i], tiposEquipamentos[i], quantidadeEquipamentos[i]));
                    Console.ReadKey();
                    achou = true;
                    break;
                }
            }
            if (!achou)
            {
                Console.WriteLine("Equipamento não encontrado!");
                Console.ReadKey();
                BuscarEquipamentos();
            }
        }
    }
}
