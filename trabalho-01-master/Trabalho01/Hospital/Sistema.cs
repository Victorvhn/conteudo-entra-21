using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    class Sistema
    {
        Medico medico = new Medico();
        Paciente paciente = new Paciente();
        Equipamento equipamento = new Equipamento();
        Medicamento medicamento = new Medicamento();

        int menuPrincipalEscolha = 0;
        int opcaoMenuMedico = 0;
        int opcaoMenuPaciente = 0;
        int opcaoMenuMedicamentos = 0;
        int opcaoMenuEquipamentos = 0;

        public Sistema()
        {
            MensagemInicial();
            MostrarMenu();
        }

        public void MensagemInicial()
        {
            BemVindo();
            Console.WriteLine(" [                                                                 ]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                               loading                              ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            BemVindo();
            Console.WriteLine(" [------                                                           ]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                               loading                              ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(600);
            Console.Clear();
            BemVindo();
            Console.WriteLine(" [-----------                                                      ]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                               loading                              ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            BemVindo();
            Console.WriteLine(" [--------------------------------                                 ]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                               loading                              ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            BemVindo();
            Console.WriteLine(" [---------------------------------------------                    ]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                               loading                              ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(400);
            Console.Clear();
            BemVindo();
            Console.WriteLine(" [-------------------------------------------------------          ]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                               loading                              ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            BemVindo();
            Console.WriteLine(" [---------------------------------------------------------------  ]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                               loading                              ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            BemVindo();
            Console.WriteLine(" [-----------------------------------------------------------------]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                               loading                              ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(350);
            Console.Clear();
            BemVindo();
            Console.WriteLine(" [-----------------------------------------------------------------]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                 Done                               ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("                 Software ainda em desenvolvimento.");
            Console.WriteLine("         Para participar do projeto, saiba mais no menu sobre.");
            Console.WriteLine("               Se ouver algum erro, favor nos avisar. ");
            System.Threading.Thread.Sleep(7000);
        }

        public void BemVindo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                String.Format(
                          "  ____                        __      __  _               _          \n" +
                          " |  _ \\                       \\ \\    / / (_)             | |         \n" +
                          " | |_) |   ___   _ __ ___      \\ \\  / /   _   _ __     __| |   ___   \n" +
                          " |  _ <   / _ \\ | '_ ` _ \\      \\ \\/ /   | | | '_ \\   / _` |  / _ \\  \n" +
                          " | |_) | |  __/ | | | | | |      \\  /    | | | | | | | (_| | | (_) | \n" +
                          " |____/   \\___| |_| |_| |_|       \\/     |_| |_| |_|  \\__,_|  \\___/  \n"
             ));
            Console.ResetColor();
        }

        // Apresentar o menu principal para o usuário
        public void MenuPrincipal()
        {
            bool validacaoOpcao = true;
            while (validacaoOpcao == true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(" Você está no menu Principal, por favor selecione uma opção.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(
        @"
  _________________
 | 1 - Médico      |
 | 2 - Paciente    |
 | 3 - Medicamento |
 | 4 - Equipamento |
 | 5 - Sobre       |
 | 6 - Sair        |
  ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯

 ");
                    Console.ResetColor();
                    Console.Write("Opção desejada: ");
                    menuPrincipalEscolha = Convert.ToInt32(Console.ReadLine());
                    if ((menuPrincipalEscolha < 1) || (menuPrincipalEscolha > 6))
                    {
                        Console.Clear();
                        Console.WriteLine("Parece que você selecionou uma opção incorreta;");
                        Console.WriteLine("Favor tente novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        MenuPrincipal();
                    }
                    validacaoOpcao = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Erro!");
                    Console.WriteLine("Por favor, tente novamente.");
                    Console.ReadKey();
                }
            }
        }

        // Apresenta o menu do médico
        public void MenuMedico()
        {
            bool validacaoOpcao = true;
            while (validacaoOpcao == true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(" Você está no menu Médico, por favor selecione o que você deseja fazer.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(
        @"
  _______________
 | 1 - Cadastrar |
 | 2 - Editar    |
 | 3 - Listar    |
 | 4 - Buscar    |
 | 5 - Voltar    |
  ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯

 ");
                    Console.ResetColor();
                    Console.Write("Opção desejada: ");
                    opcaoMenuMedico = Convert.ToInt32(Console.ReadLine());
                    if ((opcaoMenuMedico < 1) || (opcaoMenuMedico > 5))
                    {
                        Console.Clear();
                        Console.WriteLine("Parece que você selecionou uma opção incorreta;");
                        Console.WriteLine("Favor tente novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        MenuMedico();
                    }
                    validacaoOpcao = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Erro!");
                    Console.WriteLine("Por favor, tente novamente.");
                    Console.ReadKey();
                }
            }
        }

        // Apresenta o menu do paciente
        public void MenuPaciente()
        {
            bool validacaoOpcao = true;
            while (validacaoOpcao)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(" Você está no menu Paciente, por favor selecione o que você deseja fazer.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(
        @"
  _______________
 | 1 - Cadastrar |
 | 2 - Editar    |
 | 3 - Listar    |
 | 4 - Buscar    |
 | 5 - Voltar    |
  ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯

 ");
                    Console.ResetColor();
                    Console.Write("Opção desejada: ");
                    opcaoMenuPaciente = Convert.ToInt32(Console.ReadLine());
                    if ((opcaoMenuPaciente < 1) || (opcaoMenuPaciente > 5))
                    {
                        Console.Clear();
                        Console.WriteLine("Parece que você selecionou uma opção incorreta;");
                        Console.WriteLine("Favor tente novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        MenuPaciente();
                    }
                    validacaoOpcao = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Erro!");
                    Console.WriteLine("Por favor, tente novamente.");
                    Console.ReadKey();
                }
            }
        }

        // Apresenta o menu do medicamento
        public void MenuMedicamento()
        {
            bool validarOpcao = true;
            while (validarOpcao == true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(" Você está no menu Medicamento, por favor selecione o que você deseja fazer.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(
        @"
  _______________
 | 1 - Cadastrar |
 | 2 - Editar    |
 | 3 - Listar    |
 | 4 - Buscar    |
 | 5 - Voltar    |
  ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯

 ");
                    Console.ResetColor();
                    Console.Write("Opção desejada: ");
                    opcaoMenuMedicamentos = Convert.ToInt32(Console.ReadLine());
                    if ((opcaoMenuMedicamentos < 1) || (opcaoMenuMedicamentos > 5))
                    {
                        Console.Clear();
                        Console.WriteLine("Parece que você selecionou uma opção incorreta;");
                        Console.WriteLine("Favor tente novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        MenuMedicamento();
                    }
                    validarOpcao = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Erro!");
                    Console.WriteLine("Por favor, tente novamente.");
                    Console.ReadKey();
                }


            }
        }

        // Apresenta o menu do equipamento
        public void MenuEquipamento()
        {
            bool validacaoOpcao = true;
            while (validacaoOpcao == true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(" Você está no menu Equipamento, por favor selecione o que você deseja fazer.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(
        @"
  _______________
 | 1 - Cadastrar |
 | 2 - Editar    |
 | 3 - Listar    |
 | 4 - Buscar    |
 | 5 - Voltar    |
  ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯

 ");
                    Console.ResetColor();
                    Console.Write("Opção desejada: ");
                    opcaoMenuEquipamentos = Convert.ToInt32(Console.ReadLine());
                    if ((opcaoMenuEquipamentos < 1) || (opcaoMenuEquipamentos > 5))
                    {
                        Console.Clear();
                        Console.WriteLine("Parece que você selecionou uma opção incorreta;");
                        Console.WriteLine("Favor tente novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        MenuEquipamento();
                    }
                    validacaoOpcao = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Erro!");
                    Console.WriteLine("Por favor, tente novamente.");
                    Console.ReadKey();
                }
            }
        }

        // Apresenta o menu sobre
        public void MenuSobre()
        {
            Console.Clear();
            Console.WriteLine(String.Format(
                                     
                "             Medicina+              \n\n " +
                "            Versão 1.0              \n" +
                "          Software Livre            \n" +
                "          Venda Proibida            \n" +
                "          Contribuidores:           \n" +
                "   https://github.com/Viictorvhn    \n" +
                "  https://github.com/VitorMiguelM   "
                ));
            Console.ReadKey();
            MenuPrincipal();
        }

        public void MostrarMenu() // switches para os menus
        {
            // Chamar método para apresentar o menu para o usuário
            MenuPrincipal();

            while (menuPrincipalEscolha != 6)
            {
                switch (menuPrincipalEscolha) // Menu Principal
                {
                    case 1:
                        MenuMedico(); // Menu Medico
                        switch (opcaoMenuMedico)
                        {
                            case 1:
                                medico.CadastrarMedico();
                                // cadastrar medico
                                break;
                            case 2:
                                medico.EditarMedico();
                                // editar medico
                                break;
                            case 3:
                                medico.ListarMedico();
                                // listar medicos
                                break;
                            case 4:
                                medico.BuscarMedico();
                                // buscar medico
                                break;
                            case 5:
                                MenuPrincipal();
                                break;
                        }
                        break;
                    case 2:
                        MenuPaciente(); // Menu Paciente
                        switch (opcaoMenuPaciente)
                        {
                            case 1:
                                // cadastrar paciente
                                paciente.CadastrarPaciente();
                                break;
                            case 2:
                                paciente.EditarPaciente();
                                // editar paciente
                                break;
                            case 3:
                                paciente.ListarPacientes();
                                // listar pacientes
                                break;
                            case 4:
                                paciente.BuscarPacientes();
                                // buscar paciente
                                break;
                            case 5:
                                // voltar para o menu anterior
                                MenuPrincipal();
                                break;
                        }
                        break;
                    case 3:
                        MenuMedicamento(); // Menu Medicamentos
                        switch (opcaoMenuMedicamentos)
                        {
                            case 1:
                                medicamento.CastrarMedicamentos();
                                // cadastrar medicamento
                                break;
                            case 2:
                                medicamento.EditarMedicamento();
                                // editar medicamento
                                break;
                            case 3:
                                medicamento.ListarEquipamentos();
                                // listar medicamentos
                                break;
                            case 4:
                                medicamento.BuscarEquipamentos();
                                // buscar medicamento
                                break;
                            case 5:
                                // voltar para o menu anterios
                                MenuPrincipal();
                                break;
                        }
                        break;
                    case 4:
                        MenuEquipamento(); // Menu Equipamentos
                        switch (opcaoMenuEquipamentos)
                        {
                            case 1:
                                equipamento.CastrarEquipamento();
                                // cadastar equipamento
                                break;
                            case 2:
                                equipamento.EditarEquipamentos();
                                // editar equipamento
                                break;
                            case 3:
                                equipamento.ListarEquipamentos();
                                // listar equipamentos
                                break;
                            case 4:
                                equipamento.BuscarEquipamentos();
                                // buscar equipamentos
                                break;
                            case 5:
                                // voltar para o menu anterios
                                MenuPrincipal();
                                break;
                        }
                        break;
                    case 5:
                        MenuSobre();
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine(" Obrigado por testar nosso software :P");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
