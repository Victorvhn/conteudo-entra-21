using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medicamento
    {
        string[] nomesMedicamentos = new string[100];
        string[] marcasMedicamentos = new string[100];
        string[] tiposMedicamentos = new string[100];
        int[] quantidadeMedicamentos = new int[100];
        int atual = 0;

        bool validacaoNomeMedicamento = true;
        bool validacaoMarcaMedicamento = true;
        bool validacaoTipoMedicamento = true;
        bool validacaoQuantidadeMedicamento = true;

        public void CastrarMedicamentos()
        {
            // Inicio cadastro e validação do nome do medicamento
            Console.Clear();
            Console.WriteLine("Passo 1 de 4\n");
            Console.Write("Nome: ");
            nomesMedicamentos[atual] = Console.ReadLine().ToLower();
            while (validacaoNomeMedicamento == true)
            {
                if ((nomesMedicamentos[atual].Length < 3))
                {
                    Console.Clear();
                    Console.WriteLine("Passo 1 de 4\n");
                    Console.WriteLine("Nome inválido");
                    Console.Write("Nome: ");
                    nomesMedicamentos[atual] = Console.ReadLine();
                }
                else
                {
                    validacaoNomeMedicamento = false;
                }
            }
            // Fim da validação
            // Apresenta as informações inseridas
            Console.Clear();
            Console.WriteLine("Passo 2 de 4\n");
            Console.WriteLine("Nome: " + nomesMedicamentos[atual]);
            // Fim do cadastro de nome

            // Inicio do cadastro e validação de marca
            Console.Write("Marca: ");
            marcasMedicamentos[atual] = Console.ReadLine();
            while (validacaoMarcaMedicamento == true)
            {
                if (marcasMedicamentos[atual].Length < 3)
                {
                    Console.Clear();
                    Console.WriteLine("Passo 2 de 4\n");
                    Console.WriteLine("Marca inválida");
                    Console.Write("Marca: ");
                    marcasMedicamentos[atual] = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    validacaoMarcaMedicamento = false;
                }
            }
            // Fim da validação
            // Apresenta as informações inseridas
            Console.Clear();
            Console.WriteLine("Passo 3 de 4\n");
            Console.WriteLine(String.Format("Nome: {0} \nMarca: {1}", nomesMedicamentos[atual], marcasMedicamentos[atual]));
            // Fim do cadastro de marca

            // Inicio do cadastro e validação de tipo
            Console.Write("Tipo: ");
            tiposMedicamentos[atual] = Console.ReadLine();
            while (validacaoTipoMedicamento == true)
            {
                if (tiposMedicamentos[atual].Length < 5)
                {
                    Console.Clear();
                    Console.WriteLine("Passo 3 de 4\n");
                    Console.WriteLine("Tipo inválida");
                    Console.Write("Tipo: ");
                    tiposMedicamentos[atual] = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    validacaoTipoMedicamento = false;
                }
            }
            // Fim validação tipo
            // Apresente as informações inseridas
            Console.Clear();
            Console.WriteLine("Passo 4 de 4\n");
            Console.WriteLine(String.Format("Nome: {0}\nMarca: {1} \nTipo: {2}", nomesMedicamentos[atual], marcasMedicamentos[atual], tiposMedicamentos[atual]));
            // Fim do cadastro de medicamento

            // Inicio do cadastro e validação da quantidade
            validacaoQuantidadeMedicamento = true;
            while (validacaoQuantidadeMedicamento == true)
            {
                try
                {
                    Console.Write("Quantidade: ");
                    quantidadeMedicamentos[atual] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    validacaoQuantidadeMedicamento = false;
                    if (quantidadeMedicamentos[atual] <= 0)
                    {
                        Console.WriteLine("Passo 4 de 4\n");
                        Console.WriteLine("Por favor, insira uma quantidade maior que 0");
                        validacaoQuantidadeMedicamento = true;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Passo 4 de 4\n");
                    Console.WriteLine("Deve conter apenas números em \"Quantidade\"");
                }
            }
            // Fim da validação de quantidade
            // Apresenta as informações inseridas
            Console.Clear();
            Console.WriteLine("Essas foram as informações cadastradas, qualquer erro arrumar no menu editar.\n");
            Console.WriteLine(String.Format("Nome: {0}\nMarca: {1} \nTipo: {2} \nQuantidade: {3}", nomesMedicamentos[atual], marcasMedicamentos[atual], tiposMedicamentos[atual], quantidadeMedicamentos[atual]));
            Console.ReadKey();
            // Fim do cadastro de medicamento
            atual++;
        }

        public void EditarMedicamento()
        {
            Console.Clear();
            Console.Write("Digite o nome do medicamento que você quer editar.\nNome: ");
            string nomeEditar = Console.ReadLine().ToLower();

            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomeEditar == nomesMedicamentos[i])
                {
                    posicao = i;
                }
            }
            // Fim do buscar nome
            if (posicao != -1)
            {
                // Zerar vetores
                validacaoNomeMedicamento = true;
                validacaoMarcaMedicamento = true;
                validacaoTipoMedicamento = true;
                validacaoQuantidadeMedicamento = true;

                // Encontrou o registro procurado
                {
                    // Inicio cadastro e validação do nome do medicamento
                    Console.Clear();
                    Console.WriteLine("Registro encontrado!\n");
                    Console.WriteLine("Passo 1 de 4\n");
                    Console.Write("Nome: ");
                    nomesMedicamentos[posicao] = Console.ReadLine();
                    while (validacaoNomeMedicamento == true)
                    {
                        if (nomesMedicamentos[posicao].Length <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Passo 1 de 4\n");
                            Console.WriteLine("Nome inválido");
                            Console.Write("Nome: ");
                            nomesMedicamentos[posicao] = Console.ReadLine();
                        }
                        else
                        {
                            validacaoNomeMedicamento = false;
                        }
                    }
                    // Fim da validação
                    // Apresenta as informações inseridas
                    Console.Clear();
                    Console.WriteLine("Passo 2 de 4\n");
                    Console.WriteLine("Nome: " + nomesMedicamentos[posicao]);
                    // Fim do cadastro de nome

                    // Inicio do cadastro e validação de marca
                    Console.Write("Marca: ");
                    marcasMedicamentos[posicao] = Console.ReadLine();
                    while (validacaoMarcaMedicamento == true)
                    {
                        if (marcasMedicamentos[posicao].Length < 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Passo 2 de 4\n");
                            Console.WriteLine("Marca inválida");
                            Console.Write("Marca: ");
                            marcasMedicamentos[posicao] = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            validacaoMarcaMedicamento = false;
                        }
                    }
                    // Fim da validação
                    // Apresenta as informações inseridas
                    Console.Clear();
                    Console.WriteLine("Passo 3 de 4\n");
                    Console.WriteLine(String.Format("Nome: {0} \nMarca: {1}", nomesMedicamentos[posicao], marcasMedicamentos[posicao]));
                    // Fim do cadastro de marca

                    // Inicio do cadastro e validação de tipo
                    Console.Write("Tipo: ");
                    tiposMedicamentos[posicao] = Console.ReadLine();
                    while (validacaoTipoMedicamento == true)
                    {
                        if (tiposMedicamentos[posicao].Length < 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Passo 3 de 4\n");
                            Console.WriteLine("Tipo inválida");
                            Console.Write("Tipo: ");
                            tiposMedicamentos[posicao] = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            validacaoTipoMedicamento = false;
                        }
                    }
                    // Fim validação tipo
                    // Apresente as informações inseridas
                    Console.Clear();
                    Console.WriteLine("Passo 4 de 4\n");
                    Console.WriteLine(String.Format("Nome: {0}\nMarca: {1} \nTipo: {2}", nomesMedicamentos[posicao], marcasMedicamentos[posicao], tiposMedicamentos[posicao]));
                    // Fim do cadastro de medicamento

                    // Inicio do cadastro e validação da quantidade
                    while (validacaoQuantidadeMedicamento == true)
                    {
                        try
                        {
                            Console.Write("Quantidade: ");
                            quantidadeMedicamentos[posicao] = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            validacaoQuantidadeMedicamento = false;
                            if (quantidadeMedicamentos[posicao] < 5)
                            {
                                Console.WriteLine("Passo 4 de 4\n");
                                Console.WriteLine("Por favor, insira uma quantidade maior que 0");
                                validacaoQuantidadeMedicamento = true;

                            }
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Passo 4 de 4\n");
                            Console.WriteLine("Deve conter apenas números em \"Quantidade\"");
                        }
                    }
                    // Fim da validação de quantidade
                    // Apresenta as informações inseridas
                    Console.Clear();
                    Console.WriteLine("Essas foram as informações cadastradas, qualquer erro arrumar no menu editar.\n");
                    Console.WriteLine(String.Format("Nome: {0}\nMarca: {1} \nTipo: {2} \nQuantidade: {3}", nomesMedicamentos[posicao], marcasMedicamentos[posicao], tiposMedicamentos[posicao], quantidadeMedicamentos[posicao]));
                    // Fim do cadastro de medicamento
                }
            }
            else
            {
                // Se não encontrou o nome registrado
                Console.WriteLine("Registro não encontrado!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void ListarEquipamentos()
        {
            // Lista medicamentos
            Console.Clear();
            Console.WriteLine("Lista de todos os medicamentos do hospital: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(String.Format("\nNome : {0} \nMarca: {1} \nTipo: {2} \nQuantidade em estoque: {3}",nomesMedicamentos[i],marcasMedicamentos[i],tiposMedicamentos[i],quantidadeMedicamentos[i]));
            }
            Console.ReadKey();
        }

        public void BuscarEquipamentos()
        {
            // Busca o medicamento pelo nome, igual o da parte de editar, so que aqui voce nao edita, apenas visualiza
            Console.Clear();
            Console.Write("Digite um nome para visualizar os dados do medicamento.\nNome: ");
            string nomeBuscado = Console.ReadLine().ToLower();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBuscado == nomesMedicamentos[i])
                {
                    Console.WriteLine(String.Format("\nNome : {0} \nMarca: {1} \nTipo: {2} \nQuantidade em estoque: {3}", nomesMedicamentos[i], marcasMedicamentos[i], tiposMedicamentos[i], quantidadeMedicamentos[i]));
                    Console.ReadKey();
                    achou = true;
                    break;
                }
            }
            if (!achou)
            {
                Console.WriteLine("Medicamento não encontrado!");
                Console.ReadKey();
                BuscarEquipamentos();
            }
        }
    }
}
