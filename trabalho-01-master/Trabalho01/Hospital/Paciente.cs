using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Paciente
    {
        string[] nomesPacientes = new string[100];
        int[] idadesPacientes = new int[100];
        char[] sexosPacientes = new char[100];
        string[] cpfsPacientes = new string[100];
        string[] nomesMedicosDaConsulta = new string[100];
        string[] sexosPacientesString = new string[100];
        int atual = 0;
        int quantidadeSexoMasculino = 0;
        int quantidadeSexoFeminino = 0;

        bool validacaoDeNomePaciente = true;
        bool validacaoDeIdadePaciente = true;
        bool validacaoDeIdadePacienteNumeros = true;
        bool validacaoDeSexo = true;
        bool validacaoDeMedicoDaConsulta = true;

        string cpfPesquisado = "";

        string maiorNome = "";
        string menorNome = "";
        string nomeMenorIdade = "";
        string nomeMaiorIdade = "";
        int maiorIdade = int.MinValue;
        int menorIdade = int.MaxValue;

        public void CadastrarPaciente()
        {
            validacaoDeSexo = true;
            validacaoDeNomePaciente = true;
            validacaoDeIdadePaciente = true;
            validacaoDeMedicoDaConsulta = true;
            validacaoDeIdadePacienteNumeros = true;
            // Inicio do cadastro de nome
            // Nome do paciente
            Console.Clear();
            Console.WriteLine("Passo 1 de 5\n");
            Console.Write("Nome Completo: ");
            nomesPacientes[atual] = Console.ReadLine();
            // Faz a validação do nome do paciente
            while (validacaoDeNomePaciente == true)
            {
                if (nomesPacientes[atual].Length >= 5)
                {
                    validacaoDeNomePaciente = false;
                    if (nomesPacientes[atual].Length > maiorNome.Length)
                    {
                        maiorNome = nomesPacientes[atual];
                    }
                    if ((nomesPacientes[atual].Length < menorNome.Length) || (menorNome.Length == 0))
                    {
                        menorNome = nomesPacientes[atual];
                    }
                }
                if (nomesPacientes[atual].Length < 5)
                {
                    Console.Clear();
                    Console.WriteLine("Passo 1 de 5\n");
                    Console.WriteLine("Digite o nome completo do paciente, por favor. (O nome deve ter pelo menos 5 caractes).");
                    Console.Write("Nome Completo: ");
                    nomesPacientes[atual] = Console.ReadLine();
                }
            }
            // Fim da validação do nome do paciente
            // Apresenta os dados digitados
            Console.Clear();
            Console.WriteLine("Passo 2 de 5\n");
            Console.WriteLine("Nome: " + nomesPacientes[atual]);
            // Fim do cadastro de nome 

            // Inicio do cadastro de idade
            // Cadastro e Validação da idade
            while (validacaoDeIdadePaciente == true)
            {
                try
                {
                    Console.Write("Idade: ");
                    idadesPacientes[atual] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    while (validacaoDeIdadePacienteNumeros == true)
                    {
                        if ((idadesPacientes[atual] >= 0) && (idadesPacientes[atual] <= 130))
                        {
                            validacaoDeIdadePacienteNumeros = false;
                            validacaoDeIdadePaciente = false;
                            if (idadesPacientes[atual] > maiorIdade)
                            {
                                maiorIdade = idadesPacientes[atual];
                                nomeMaiorIdade = nomesPacientes[atual];
                            }
                            else if (idadesPacientes[atual] < menorIdade)
                            {
                                menorIdade = idadesPacientes[atual];
                                nomeMenorIdade = nomesPacientes[atual];
                            }
                        }
                        if ((idadesPacientes[atual] < 0) || (idadesPacientes[atual] > 130))
                        {
                            Console.Clear();
                            Console.WriteLine("Passo 2 de 5\n");
                            Console.WriteLine("Favor digite uma idade válida.");
                            Console.Write("Idade: ");
                            idadesPacientes[atual] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Passo 2 de 5\n");
                    Console.WriteLine("Deve conter apenas números em \"Idade\"");
                }
            }
            // Fim da validação de idade
            // Apresenta os dados informados
            Console.Clear();
            Console.WriteLine("Passo 3 de 5\n");
            Console.WriteLine("Nome: " + nomesPacientes[atual]);
            Console.WriteLine("Idade: " + idadesPacientes[atual]);
            // Fim do cadastro de idade

            // Inicio do cadastro de sexo
            // Cadastro e Validação do sexo 
            while (validacaoDeSexo == true)
            {
                try
                {
                    Console.WriteLine("(M para masculino, F para feminino)");
                    Console.Write("Sexo: ");
                    sexosPacientes[atual] = Convert.ToChar(Console.ReadLine().ToLower().Trim());

                    if ((sexosPacientes[atual] == 'm') || (sexosPacientes[atual] == 'f'))
                    {
                        validacaoDeSexo = false;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Passo 3 de 5\n");
                    Console.WriteLine("Deve conter apenas 1 caracter em \"sexo\"");
                }
                if (sexosPacientes[atual] == 'm')
                {
                    sexosPacientesString[atual] = "Masculino";
                    quantidadeSexoMasculino++;
                }
                else
                {
                    sexosPacientesString[atual] = "Feminino";
                    quantidadeSexoFeminino++;
                }
                Console.Clear();
                Console.WriteLine("Passo 3 de 5\n");
                Console.WriteLine(String.Format("Nome: {0}\nIdade: {1}", nomesPacientes[atual], idadesPacientes[atual]));
            }
            // Fim da validação
            // Apresenta os dados informados
            Console.Clear();
            Console.WriteLine("Passo 4 de 5\n");
            Console.WriteLine(String.Format("Nome: {0}\nIdade: {1}\nSexo: {2}", nomesPacientes[atual], idadesPacientes[atual], sexosPacientesString[atual]));
            // Fim do cadastro de sexo

            // Inicio do cadastro de CPF
            // Cadastrar e validação CPF
            Console.Write("CPF: ");
            cpfsPacientes[atual] = Console.ReadLine();

            while (!ValidaCPF(cpfsPacientes[atual]))
            {
                Console.Clear();
                Console.WriteLine("Passo 4 de 5\n");
                Console.WriteLine("Inválido");
                Console.Write("CPF: ");
                cpfsPacientes[atual] = Console.ReadLine();
            }
            // Fim da validação CPF
            // Apresenta os dados informados
            Console.Clear();
            Console.WriteLine("Passo 5 de 5\n");
            Console.WriteLine("Nome: " + nomesPacientes[atual]);
            Console.WriteLine("Idade: " + idadesPacientes[atual]);
            Console.WriteLine("Sexo: " + sexosPacientesString[atual]);
            Console.WriteLine("CPF: " + cpfsPacientes[atual]);

            // Inicio cadastro medico da consulta
            // Cadastro e validação do medico da consulta
            Console.Write("Médico da consulta: ");
            nomesMedicosDaConsulta[atual] = Console.ReadLine();
            while (validacaoDeMedicoDaConsulta == true)
            {
                if (nomesMedicosDaConsulta[atual].Length >= 5)
                {
                    validacaoDeMedicoDaConsulta = false;
                }
                if (nomesMedicosDaConsulta[atual].Length < 5)
                {
                    Console.Clear();
                    Console.WriteLine("Passo 5 de 5\n");
                    Console.WriteLine("Por favor, digite o nome completo do médico. (O nome deve ter pelo menos 5 caractes).");
                    Console.Write("Nome Completo: ");
                    nomesMedicosDaConsulta[atual] = Console.ReadLine();
                }
            }
            // Fim da validação do medico da consulta
            // Apresenta os dados informados
            Console.Clear();
            Console.WriteLine("Esses foram os dados cadastrados, qualquer erro você consegue arrumar na aba editar: \n");
            Console.WriteLine("Nome: " + nomesPacientes[atual]);
            Console.WriteLine("Idade: " + idadesPacientes[atual]);
            Console.WriteLine("Sexo: " + sexosPacientesString[atual]);
            Console.WriteLine("CPF: " + cpfsPacientes[atual]);
            Console.WriteLine("Médico da consulta: " + nomesMedicosDaConsulta[atual]);
            Console.WriteLine("\nAguarde, você será redirecionado");
            System.Threading.Thread.Sleep(7000);

            // Fim do cadastro do medico da consulta
            atual++;
        }

        // Inicio do método utilizado para validar CPF
        public bool ValidaCPF(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }
        // Fim do método de validar CPF

        public void EditarPaciente()
        {
            // Pesquisador e validador de CPF cadastrado
            Console.Clear();
            Console.Write("Digite um CPF para editar os dados do paciente.\nCPF: ");
            cpfPesquisado = Console.ReadLine();

            while (!ValidaCPF(cpfPesquisado))
            {
                Console.Clear();
                Console.WriteLine("Inválido");
                Console.Write("CPF: ");
                cpfPesquisado = Console.ReadLine();
            }
            // Fim da validação
            // Inicio da busca do CPF
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (cpfPesquisado == cpfsPacientes[i])
                {
                    posicao = i;
                }
            }
            // Fim da busca do CPF
            if (posicao != -1)
            {
                // Zerar vetores
                validacaoDeNomePaciente = true;
                validacaoDeIdadePaciente = true;
                validacaoDeIdadePacienteNumeros = true;
                validacaoDeSexo = true;
                validacaoDeMedicoDaConsulta = true;

                // Encontrou o registro procurado
                // A partir desse ponto o codigo faz a mesma coisa que a parte do cadastro, so que edita o paciente buscado pelo CPF
                Console.Clear();
                Console.WriteLine("Paciente encontrado, edite os dados dele: ");
                Console.WriteLine("Passo 1 de 4\n");
                Console.Write("Nome Completo: ");
                nomesPacientes[posicao] = Console.ReadLine();
                while (validacaoDeNomePaciente == true)
                {
                    if (nomesPacientes[posicao].Length >= 5)
                    {
                        validacaoDeNomePaciente = false;
                    }
                    if (nomesPacientes[posicao].Length < 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Passo 1 de 4\n");
                        Console.WriteLine("Digite o nome completo do paciente, por favor. (O nome deve ter pelo menos 5 caractes).");
                        Console.Write("Nome Completo: ");
                        nomesPacientes[posicao] = Console.ReadLine();
                    }
                }
                Console.Clear();
                Console.WriteLine("Passo 2 de 4\n");
                Console.WriteLine("Nome: " + nomesPacientes[posicao]);

                while (validacaoDeIdadePaciente == true)
                {
                    try
                    {
                        Console.Write("Idade: ");
                        idadesPacientes[posicao] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        while (validacaoDeIdadePacienteNumeros == true)
                        {
                            if ((idadesPacientes[posicao] >= 0) && (idadesPacientes[posicao] <= 130))
                            {
                                validacaoDeIdadePacienteNumeros = false;
                                validacaoDeIdadePaciente = false;
                            }
                            if ((idadesPacientes[posicao] < 0) || (idadesPacientes[posicao] > 130))
                            {
                                Console.Clear();
                                Console.WriteLine("Passo 2 de 4\n");
                                Console.WriteLine("Favor digite uma idade válida.");
                                Console.Write("Idade: ");
                                idadesPacientes[posicao] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Passo 2 de 4\n");
                        Console.WriteLine("Deve conter apenas números em \"Idade\"");
                    }
                }
                Console.Clear();
                Console.WriteLine("Passo 3 de 4\n");
                Console.WriteLine("Nome: " + nomesPacientes[posicao]);
                Console.WriteLine("Idade: " + idadesPacientes[posicao]);

                if (sexosPacientes[posicao] == 'm')
                {
                    quantidadeSexoMasculino--;
                }
                else
                {
                    quantidadeSexoFeminino--;
                }

                while (validacaoDeSexo == true)
                {
                    try
                    {
                        Console.WriteLine("(M para masculino, F para feminino)");
                        Console.Write("Sexo: ");
                        sexosPacientes[posicao] = Convert.ToChar(Console.ReadLine().ToLower().Trim());

                        if ((sexosPacientes[posicao] == 'm') || (sexosPacientes[posicao] == 'f'))
                        {
                            validacaoDeSexo = false;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Deve conter apenas 1 caracter em \"sexo\"");
                    }
                    if (sexosPacientes[posicao] == 'm')
                    {
                        sexosPacientesString[posicao] = "Masculino";
                        quantidadeSexoMasculino++;
                    }
                    else
                    {
                        sexosPacientesString[posicao] = "Feminino";
                        quantidadeSexoFeminino++;
                    }
                    Console.Clear();
                    Console.WriteLine("Passo 3 de 4\n");
                    Console.WriteLine(String.Format("Nome: {0}\nIdade: {1}", nomesPacientes[posicao], idadesPacientes[posicao]));
                }

                Console.Clear();
                Console.WriteLine("Passo 4 de 4\n");
                Console.WriteLine(String.Format("Nome: {0}\nIdade: {1}\nSexo: {2}", nomesPacientes[posicao], idadesPacientes[posicao], sexosPacientesString[posicao]));


                Console.Write("Médico da consulta: ");
                nomesMedicosDaConsulta[posicao] = Console.ReadLine();
                while (validacaoDeMedicoDaConsulta == true)
                {
                    if (nomesMedicosDaConsulta[posicao].Length >= 5)
                    {
                        validacaoDeMedicoDaConsulta = false;
                    }
                    if (nomesMedicosDaConsulta[posicao].Length < 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Passo 4 de 4\n");
                        Console.WriteLine("Por favor, digite o nome completo do médico. (O nome deve ter pelo menos 5 caractes).");
                        Console.Write("Nome Completo: ");
                        nomesMedicosDaConsulta[posicao] = Console.ReadLine();
                    }
                }
                Console.Clear();
                Console.WriteLine("Essas são as informações atuais do paciente: ");
                Console.WriteLine("Nome: " + nomesPacientes[posicao]);
                Console.WriteLine("Idade: " + idadesPacientes[posicao]);
                Console.WriteLine("Sexo: " + sexosPacientesString[posicao]);
                Console.WriteLine("CPF: " + cpfsPacientes[posicao]);
                Console.WriteLine("Médico da consulta: " + nomesMedicosDaConsulta[posicao]);
                Console.WriteLine("\nAguarde, você será redirecionado");
                System.Threading.Thread.Sleep(7000);
                // Fim do Editor de Paciente
            }
            else
            {
                // Se não encontrou o CPF registrado
                Console.WriteLine("Registro não encontrado!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void ListarPacientes()
        {
            // Lista todos os pacientes cadastrados no hospital
            Console.Clear();
            Console.WriteLine("Lista de pacientes cadastrados no hospital: \n\n");
            Console.WriteLine(String.Format(
                "O paciente com o maior nome se chama {0}.\n" +
                "O paciente com o menor nome se chama {1}.\n" +
                "O paciente mais velho é {2} com {3} anos.\n" +
                "O paciente mais novo é {4} com {5} anos.\n" +
                "Foram registrados {6} pacientes, {7} do sexo masculino e {8} do sexo feminino.", maiorNome,menorNome,nomeMaiorIdade,maiorIdade,nomeMenorIdade,menorIdade,atual,quantidadeSexoMasculino,quantidadeSexoFeminino));

            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(String.Format("\nNome Completo: {0} \nIdade: {1} \nSexo: {2} \nCPF: {3} \nMédico da Consulta: {4}", nomesPacientes[i], idadesPacientes[i], sexosPacientesString[i], cpfsPacientes[i], nomesMedicosDaConsulta[i]));
            }
            Console.ReadKey();
        }

        public void BuscarPacientes()
        {
            // Busca o paciente pelo CPF, igual o da parte de editar, so que aqui voce nao edita, apenas visualiza
            Console.Clear();
            Console.Write("Digite um CPF para visualizar os dados do paciente.\nCPF: ");
            string cpsBuscado = Console.ReadLine();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (cpsBuscado == cpfsPacientes[i])
                {
                    Console.WriteLine(String.Format("\nNome Completo: {0} \nIdade: {1} \nSexo: {2} \nCPF: {3} \nMédico da Consulta: {4}", nomesPacientes[i], idadesPacientes[i], sexosPacientesString[i], cpfsPacientes[i], nomesMedicosDaConsulta[i]));
                    Console.ReadKey();
                    achou = true;
                    break;
                }
            }
            if (!achou)
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
                BuscarPacientes();
            }
        }
    }
}
