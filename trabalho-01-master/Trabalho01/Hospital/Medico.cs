using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medico
    {
        string[] nomesMedicos = new string[100];
        int[] idadesMedicos = new int[100];
        char[] sexosMedicos = new char[100];
        string[] crmsMedicos = new string[100];
        string[] especialidadesMedicos = new string[100];
        string maiorNome = "";
        string menorNome = "";
        int maiorIdade = 0;
        int menorIdade = 0;
        string nomeMenorIdade = "";
        string nomeMaiorIdade = "";
        int quantidadeSexoMasculino = 0;
        int quantidadeSexoFeminino = 0;

        bool validarNomeMedico = true;
        bool validarIdadeMedico = true;
        bool validarIdadeMedicoNumeros = true;
        bool validarSexoMedicos = true;
        bool validarCrmMedicos = true;
        bool validarEspecialidadeMedicos = true;

        string[] sexosMedicosString = new string[100];

        int atual = 0;

        public void CadastrarMedico()
        {
            validarIdadeMedico = true;
            validarNomeMedico = true;
            validarIdadeMedicoNumeros = true;
            validarSexoMedicos = true;
            validarCrmMedicos = true;

            Console.Clear();
            Console.WriteLine("Passo 1 de 5\n");
            Console.Write("Nome Completo: ");
            nomesMedicos[atual] = Console.ReadLine();

            //Validação do nome do médico
            while (validarNomeMedico == true)
            {
                if (nomesMedicos[atual].Length >= 5)
                {
                    validarNomeMedico = false;
                    if (nomesMedicos[atual].Length > maiorNome.Length)
                    {
                        maiorNome = nomesMedicos[atual];
                    }
                    if ((nomesMedicos[atual].Length < menorNome.Length) || (menorNome.Length == 0))
                    {
                        menorNome = nomesMedicos[atual];
                    }
                }
                if (nomesMedicos[atual].Length < 5)
                {
                    Console.Clear();
                    Console.WriteLine("Passo 1 de 5\n");
                    Console.WriteLine("Digite o nome completo do paciente, por favor. (O nome deve ter pelo menos 5 caractes).");
                    Console.Write("Nome Completo: ");
                    nomesMedicos[atual] = Console.ReadLine();
                    validarNomeMedico = false;
                }

            }
            Console.Clear();
            Console.WriteLine("Passo 1 de 5\n");
            Console.WriteLine("Nome: " + nomesMedicos[atual]);

            //Validação da idade dos médicos
            while (validarIdadeMedicoNumeros == true)
            {
                try
                {
                    Console.Write("Idade do médico: ");
                    idadesMedicos[atual] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    while (validarIdadeMedico == true)
                    {
                        if ((idadesMedicos[atual] >= 23) && (idadesMedicos[atual] <= 130))
                        {
                            validarIdadeMedico = false;
                            validarIdadeMedicoNumeros = false;
                            if (idadesMedicos[atual] > maiorIdade)
                            {
                                maiorIdade = idadesMedicos[atual];
                                nomeMaiorIdade = nomesMedicos[atual];
                            }
                            if (idadesMedicos[atual] < menorIdade)
                            {
                                menorIdade = idadesMedicos[atual];
                                nomeMenorIdade = nomesMedicos[atual];
                            }
                        }
                        if ((idadesMedicos[atual] < 23) || (idadesMedicos[atual] > 130))
                        {
                            Console.Clear();
                            Console.WriteLine("Passo 2 de 5\n");
                            Console.WriteLine("Digite uma idade válida, por favor.");
                            Console.Write("Idade: ");
                            idadesMedicos[atual] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Passo 2 de 5\n");
                    Console.WriteLine("Deve conter apenas números em \"idade\"");
                }

            }
            Console.Clear();
            Console.WriteLine("Passo 3 de 5\n");
            Console.WriteLine("Nome: " + nomesMedicos[atual]);
            Console.WriteLine("Idade: " + idadesMedicos[atual]);


            //Validação do sexo do médico
            while (validarSexoMedicos == true)
            {
                try
                {
                    Console.WriteLine("(M para masculino, F para feminino)");
                    Console.Write("Sexo: ");
                    sexosMedicos[atual] = Convert.ToChar(Console.ReadLine().ToLower().Trim());

                    if ((sexosMedicos[atual] == 'm') || (sexosMedicos[atual] == 'f'))
                    {
                        validarSexoMedicos = false;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Passo 3 de 5\n");
                    Console.WriteLine("Deve conter apenas 1 caracter em \"sexo\"");
                }
                if (sexosMedicos[atual] == 'm')
                {
                    sexosMedicosString[atual] = "Masculino";
                    quantidadeSexoMasculino++;
                }
                else
                {
                    sexosMedicosString[atual] = "Feminino";
                    quantidadeSexoFeminino++;
                }
                Console.Clear();
                Console.WriteLine("Passo 3 de 5\n");
                Console.WriteLine(String.Format("Nome: {0}\nIdade: {1}", nomesMedicos[atual], idadesMedicos[atual]));
            }
            Console.Clear();
            Console.WriteLine("Passo 4 de 5\n");
            Console.WriteLine(String.Format("Nome: {0}\nIdade: {1} \nSexo: {2}", nomesMedicos[atual], idadesMedicos[atual], sexosMedicosString[atual]));



            while (validarCrmMedicos == true)
            {
                try
                {
                    Console.Write("Crm do médico: ");
                    crmsMedicos[atual] = Console.ReadLine();
                    Console.Clear();
                    while (validarCrmMedicos == true)
                    {
                        if ((crmsMedicos[atual].Length >= 4) && (crmsMedicos[atual].Length <= 11))
                        {
                            validarCrmMedicos = false;
                           
                        }
                        if ((crmsMedicos[atual].Length < 4) || (crmsMedicos[atual].Length > 11))
                        {
                            Console.Clear();
                            Console.WriteLine("Essa informação é inválida");
                            Console.Write("Crm do médico: ");
                            crmsMedicos[atual] = Console.ReadLine();
                        }
                    }
                }
                catch
                {
                    Console.Write("Em \"Crm do médico\" deve conter apenas números");
                }
            }
            Console.Clear();
            Console.WriteLine(String.Format("Nome: {0}\nIdade: {1} \nSexo: {2} \nCRM: {3}", nomesMedicos[atual], idadesMedicos[atual], sexosMedicosString[atual], crmsMedicos[atual]));

            // fim da validação do crm

            Console.Write("Especialidade do médico: ");
            especialidadesMedicos[atual] = Console.ReadLine();

            while (validarEspecialidadeMedicos == true)
            {
                if (especialidadesMedicos[atual].Length >= 5)
                {
                    validarEspecialidadeMedicos = false;
                }
                if (especialidadesMedicos[atual].Length < 5)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma especialidade válida, por favor.");
                    Console.Write("Especialidade do médico: ");
                    especialidadesMedicos[atual] = Console.ReadLine();
                }
            }
            atual++;
        }

        public void EditarMedico()
        {
            Console.Clear();
            Console.Write("Pesquise um Crm para a edição: ");
            string crmDaBusca = Console.ReadLine().ToLower().Trim();
            int posicao = -1;

            for (int i = 0; i < atual; i++)
            {
                if (crmDaBusca == crmsMedicos[i])
                {
                    posicao = i;
                }
            }

            if (posicao != -1)
            {
                // aqui o usuário achou o que estava procurando

                //Edição do nome do médico
                Console.Clear();
                Console.Write("Nome completo do médico: ");
                nomesMedicos[posicao] = Console.ReadLine();
                while (validarNomeMedico == true)
                {
                    if (nomesMedicos[atual].Length >= 5)
                    {
                        validarNomeMedico = false;
                        if (nomesMedicos[atual].Length > maiorNome.Length)
                        {
                            maiorNome = nomesMedicos[atual];
                        }
                        if ((nomesMedicos[atual].Length < menorNome.Length) || (menorNome.Length == 0))
                        {
                            menorNome = nomesMedicos[atual];
                        }
                    }
                    if (nomesMedicos[atual].Length < 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Passo 1 de 5\n");
                        Console.WriteLine("Digite o nome completo do paciente, por favor. (O nome deve ter pelo menos 5 caractes).");
                        Console.Write("Nome Completo: ");
                        nomesMedicos[atual] = Console.ReadLine();
                        validarNomeMedico = false;
                    }

                }
                Console.Clear();
                Console.WriteLine("Passo 1 de 5\n");
                Console.WriteLine("Nome: " + nomesMedicos[atual]);
                // fim da segunda validaçao do nome do médico na edição

                //edição da idade do médico
                while (validarIdadeMedicoNumeros == true)
                {
                    try
                    {
                        Console.Write("Idade do médico: ");
                        idadesMedicos[atual] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        while (validarIdadeMedico == true)
                        {
                            if ((idadesMedicos[atual] >= 23) && (idadesMedicos[atual] <= 130))
                            {
                                validarIdadeMedico = false;
                                validarIdadeMedicoNumeros = false;
                                if (idadesMedicos[atual] > maiorIdade)
                                {
                                    maiorIdade = idadesMedicos[atual];
                                    nomeMaiorIdade = nomesMedicos[atual];
                                }
                                if (idadesMedicos[atual] < menorIdade)
                                {
                                    menorIdade = idadesMedicos[atual];
                                    nomeMenorIdade = nomesMedicos[atual];
                                }
                            }
                            if ((idadesMedicos[atual] < 23) || (idadesMedicos[atual] > 130))
                            {
                                Console.Clear();
                                Console.WriteLine("Passo 2 de 5\n");
                                Console.WriteLine("Digite uma idade válida, por favor.");
                                Console.Write("Idade: ");
                                idadesMedicos[atual] = Convert.ToInt32(Console.ReadLine());
                            }
                        }

                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Passo 2 de 5\n");
                        Console.WriteLine("Deve conter apenas números em \"idade\"");
                    }

                }
                Console.Clear();
                Console.WriteLine("Passo 3 de 5\n");
                Console.WriteLine("Nome: " + nomesMedicos[atual]);
                Console.WriteLine("Idade: " + idadesMedicos[atual]);
                // fim da validação da idade do médico na edição 

                //Edição da idade do médico
                while (validarIdadeMedicoNumeros == true)
                {
                    try
                    {
                        Console.Write("Idade do médico: ");
                        idadesMedicos[atual] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        while (validarIdadeMedico == true)
                        {
                            if ((idadesMedicos[atual] >= 23) && (idadesMedicos[atual] <= 130))
                            {
                                validarIdadeMedico = false;
                                validarIdadeMedicoNumeros = false;
                                if (idadesMedicos[atual] > maiorIdade)
                                {
                                    maiorIdade = idadesMedicos[atual];
                                    nomeMaiorIdade = nomesMedicos[atual];
                                }
                                if (idadesMedicos[atual] < menorIdade)
                                {
                                    menorIdade = idadesMedicos[atual];
                                    nomeMenorIdade = nomesMedicos[atual];
                                }
                            }
                            if ((idadesMedicos[atual] < 23) || (idadesMedicos[atual] > 130))
                            {
                                Console.Clear();
                                Console.WriteLine("Passo 2 de 5\n");
                                Console.WriteLine("Digite uma idade válida, por favor.");
                                Console.Write("Idade: ");
                                idadesMedicos[atual] = Convert.ToInt32(Console.ReadLine());
                            }
                        }

                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Passo 2 de 5\n");
                        Console.WriteLine("Deve conter apenas números em \"idade\"");
                    }

                }
                Console.Clear();
                Console.WriteLine("Passo 3 de 5\n");
                Console.WriteLine("Nome: " + nomesMedicos[atual]);
                Console.WriteLine("Idade: " + idadesMedicos[atual]);
                //Fim da validação da idade do médico na edição


                //Edição do sexo do médico
                while (validarSexoMedicos == true)
                {
                    try
                    {
                        Console.WriteLine("(M para masculino, F para feminino)");
                        Console.Write("Sexo: ");
                        sexosMedicos[atual] = Convert.ToChar(Console.ReadLine().ToLower().Trim());

                        if ((sexosMedicos[atual] == 'm') || (sexosMedicos[atual] == 'f'))
                        {
                            validarSexoMedicos = false;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Passo 3 de 5\n");
                        Console.WriteLine("Deve conter apenas 1 caracter em \"sexo\"");
                    }
                    if (sexosMedicos[atual] == 'm')
                    {
                        sexosMedicosString[atual] = "Masculino";
                        quantidadeSexoMasculino++;
                    }
                    else
                    {
                        sexosMedicosString[atual] = "Feminino";
                        quantidadeSexoFeminino++;
                    }
                    Console.Clear();
                    Console.WriteLine("Passo 3 de 5\n");
                    Console.WriteLine(String.Format("Nome: {0}\nIdade: {1}", nomesMedicos[atual], idadesMedicos[atual]));
                }
                Console.Clear();
                Console.WriteLine("Passo 4 de 5\n");
                Console.WriteLine(String.Format("Nome: {0}\nIdade: {1} \nSexo: {2}", nomesMedicos[atual], idadesMedicos[atual], sexosMedicosString[atual])); 
                // fim da validação do sexo do médico na edição

                //Edicão do crm do médico
                while (validarCrmMedicos == true)
                {
                    try
                    {
                        Console.Write("Crm do médico: ");
                        crmsMedicos[atual] = Console.ReadLine();
                        Console.Clear();
                        while (validarCrmMedicos == true)
                        {
                            if ((crmsMedicos[atual].Length >= 4) && (crmsMedicos[atual].Length <= 11))
                            {
                                validarCrmMedicos = false;
                            }
                            if ((crmsMedicos[atual].Length < 4) || (crmsMedicos[atual].Length > 11))
                            {
                                Console.Clear();
                                Console.WriteLine("Essa informação é inválida");
                                Console.Write("Crm do médico: ");
                                crmsMedicos[atual] = Console.ReadLine();
                            }
                        }
                    }
                    catch
                    {
                        Console.Write("Em \"Crm do médico\" deve conter apenas números");
                    }

                }
                Console.WriteLine(String.Format("Nome: {0}\nIdade: {1} \nSexo: {2} \nCRM: {3}", nomesMedicos[atual], idadesMedicos[atual], sexosMedicosString[atual], crmsMedicos[atual])); 
                //Fim da validação do crm do médico na edição

                //Edição da especialidade do médico
                Console.Write("Especialidade do médico: ");
                especialidadesMedicos[posicao] = Console.ReadLine();

                while (validarEspecialidadeMedicos == true)
                {
                    if (especialidadesMedicos[atual].Length >= 5)
                    {
                        validarEspecialidadeMedicos = false;
                    }
                    if (especialidadesMedicos[atual].Length < 5)
                    {
                        Console.Clear();
                        Console.Write("Digite uma especialidade válida, por favor.");
                        Console.Write("Especialidade do médico: ");
                        especialidadesMedicos[atual] = Console.ReadLine();
                    }
                }
                atual++;
                //Fim da validação da especialidade do médico na edição

                Console.Clear();
                Console.WriteLine("Dados do médico editados com sucesso!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Médico não encontrado, Tente novamente");
                Console.ReadKey();
                EditarMedico();
            }

        }

        public void ListarMedico()
        {
            //Aqui mostra todos os médicos cadastrados e suas informações
            Console.Clear();
            Console.Write("Lista de Médicos:");

            Console.WriteLine(String.Format(
                "O paciente com o maior nome se chama {0}.\n" +
                "O paciente com o menor nome se chama {1}.\n" +
                "O paciente mais velho é {2} com {3} anos.\n" +
                "O paciente mais novo é {4} com {5} anos.\n" +
                "Foram registrados {6} pacientes, {7} do sexo masculino e {8} do sexo feminino.", maiorNome, menorNome, nomeMaiorIdade, maiorIdade, nomeMenorIdade, menorIdade, atual, quantidadeSexoMasculino, quantidadeSexoFeminino));

            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                                     @"Nome completo: {0} 
Idade: {1} 
Sexo: {2} 
cRM: {3}
Especialidade: {4}", nomesMedicos[i], idadesMedicos[i],
                     sexosMedicosString[i], crmsMedicos[i], especialidadesMedicos[i]));
                Console.ReadKey();

            }
        }

        public void BuscarMedico()
        {
            Console.Clear();
            Console.Write("Digite o CRM do médico que deseja buscar: ");
            string CrmDaBusca = Console.ReadLine();

            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (CrmDaBusca == crmsMedicos[i])
                {
                    Console.WriteLine(
                        String.Format(
                              @"
Nome completo: {0} 
Idade: {1} 
Sexo: {2} 
CRM: {3} 
Especialidade: {4}", nomesMedicos[i], idadesMedicos[i],
                     sexosMedicosString[i], crmsMedicos[i], especialidadesMedicos[i]));
                    Console.ReadKey();
                    achou = true;
                    break;

                }
                if (!achou)
                {
                    Console.Write("Desculpe, esse médico não foi encontrado =[");
                }
            }
        }

    }
}
