using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola
{
    class Popular
    {
        static Popular()
        {
            Random numeroRandomico = new Random();
            string numeroAleatorio = Convert.ToString(numeroRandomico.Next(50, 1000));

            Program.professores.Add(new ListaProfessor()
            {
                Nome = "Vitór Martins Santos",
                Sexo = "Masculino",
                Cpf = "321.503.454-98",
                Rg = "37.689.617-6",
                Turno = "Matutino",
                Nacionalidade = "Brasil",
                DataNascimento = new DateTime(1944, 07, 16),
                Especialidade = "Matemática",
                NumeroContaSalario = 200476,
                NumeroAgenciaContaSalario = 2246,
                CEP = "26063-180",
                UF = "Rio de Janeiro",
                NumeroCasa = 33,
                Email = "vitorMartinsSantos@dayrep.com",
                Complemento = ""
            });
            Program.professores.Add(new ListaProfessor()
            {
                Nome = "Camila Gomes Goncalves",
                Sexo = "Feminino",
                Cpf = "542.195.124-38",
                Rg = "48.807.911-1",
                Turno = "Noturno",
                Nacionalidade = "Brasil",
                DataNascimento = new DateTime(1996, 04, 28),
                Especialidade = "Física",
                NumeroContaSalario = 477852,
                NumeroAgenciaContaSalario = 0305,
                CEP = "66083-497",
                UF = "Pará",
                NumeroCasa = 949,
                Email = "camilaGomesGoncalves@armyspy.com",
                Complemento = ""
            });
            Program.professores.Add(new ListaProfessor()
            {
                Nome = "Fábio Goncalves Gomess",
                Sexo = "Masculino",
                Cpf = "354.699.442-63",
                Rg = "15.787.257-9",
                Turno = "Vespertino",
                Nacionalidade = "Brasil",
                DataNascimento = new DateTime(1964, 05, 24),
                Especialidade = "Física",
                NumeroContaSalario = 620725,
                NumeroAgenciaContaSalario = 5008,
                CEP = "94852-040",
                UF = "RS",
                NumeroCasa = 528,
                Email = "FabioGoncalvesGomes@rhyta.com",
                Complemento = ""
            });
            Program.professores.Add(new ListaProfessor()
            {
                Nome = "Daniel Alves Gomes",
                Sexo = "Masculino",
                Cpf = "474.482.463-30",
                Rg = "33.701.756-6",
                Turno = "Noturno",
                Nacionalidade = "Brasil",
                DataNascimento = new DateTime(1970, 12, 23),
                Especialidade = "Português",
                NumeroContaSalario = 546817,
                NumeroAgenciaContaSalario = 5559,
                CEP = "72140-100",
                UF = "Taguatinga",
                NumeroCasa = 1126,
                Email = "DanielAlvesGomes@jourrapide.com",
                Complemento = ""
            });
            Program.professores.Add(new ListaProfessor()
            {
                Nome = "Thaís Cardoso Barros",
                Sexo = "Feminino",
                Cpf = "114.053.693-10",
                Rg = "24.100.330-1",
                Turno = "Vespertino",
                Nacionalidade = "Brasil",
                DataNascimento = new DateTime(1994, 11, 07),
                Especialidade = "Inglês",
                NumeroContaSalario = 976284,
                NumeroAgenciaContaSalario = 6617,
                CEP = "74356-008",
                UF = "GO",
                NumeroCasa = 1149,
                Email = "ThaisCardosoBarros@teleworm.us",
                Complemento = ""
            });
            Program.funcionarios.Add(new ListaFuncionario()
            {
                Nome = "Luiz Castro Rodrigues",
                Sexo = "Masculino",
                CPF = "474.590.745-19",
                RG = "40.196.290-8",
                Nacionalidade = "Brasil",
                DataNascimento = new DateTime(1980, 01, 21),
                DataAdmissao = new DateTime(2018, 06, 01),
                Turno = "Vespertino",
                ContaSalario = 855331,
                AgenciaContaSalario = 0637,
                Cargo = "Zelador",
                CEP = "09581-630",
                NumeroCasa = numeroRandomico.Next(10, 1000),
                Email = "LuizCastroRodrigues@jourrapide.com"
            });

            Program.funcionarios.Add(new ListaFuncionario()
            {
                Nome = "Mateus Dias Rodrigues",
                Sexo = "Masculino",
                CPF = "384.422.069-06",
                RG = "13.428.677-7",
                Nacionalidade = "Brasil",
                DataNascimento = new DateTime(1935, 02, 27),
                DataAdmissao = new DateTime(2018, 06, 01),
                Turno = "Matutino",
                ContaSalario = 462590,
                AgenciaContaSalario = 1491,
                Cargo = "Porteiro",
                CEP = "05790-130",
                NumeroCasa = numeroRandomico.Next(10, 1000),
                Email = "MateusDiasRodrigues@dayrep.com"
            });

            Program.funcionarios.Add(new ListaFuncionario()
            {
                Nome = "Julia Gomes Azevedo",
                Sexo = "Feminino",
                CPF = "615.890.232-26",
                RG = "35.813.417-1",
                Nacionalidade = "Brasil",
                DataNascimento = new DateTime(1947, 05, 08),
                DataAdmissao = new DateTime(2018, 06, 01),
                Turno = "Noturno",
                ContaSalario = 003671,
                AgenciaContaSalario = 9976,
                Cargo = "Cozinheira",
                CEP = "89036-238",
                NumeroCasa = numeroRandomico.Next(10, 1000),
                Email = "JuliaGomesAzevedo@armyspy.com"
            });

            Program.funcionarios.Add(new ListaFuncionario()
            {
                Nome = "Luiz Silva Araujo",
                Sexo = "Masculino",
                CPF = "774.306.366-67",
                RG = "18.747.269-5",
                Nacionalidade = "Brasil",
                DataNascimento = new DateTime(1971, 09, 30),
                DataAdmissao = new DateTime(2018, 06, 01),
                Turno = "Vespertino",
                ContaSalario = 066687,
                AgenciaContaSalario = 2542,
                Cargo = "Serviços Gerais",
                CEP = "09780-140",
                NumeroCasa = numeroRandomico.Next(10, 1000),
                Email = "LuizSilvaAraujo@armyspy.com"
            });

            Program.funcionarios.Add(new ListaFuncionario()
            {
                Nome = "Lavinia Oliveira Castro",
                Sexo = "Feminino",
                CPF = "151.222.176-70",
                RG = "23.177.944-6",
                Nacionalidade = "Brasil",
                DataNascimento = new DateTime(1933, 11, 12),
                DataAdmissao = new DateTime(2018, 06, 01),
                Turno = "Matutino",
                ContaSalario = 689270,
                AgenciaContaSalario = 2654,
                Cargo = "Diretora",
                CEP = "66920-350",
                NumeroCasa = numeroRandomico.Next(10, 1000),
                Email = "LaviniaOliveiraCastro@dayrep.com"
            });

            Program.alimentos.Add(new ListaAlimento()
            {
                Nome = "Arroz",
                GrupoAlimentar = "Cereais",
                DataFabricacao = new DateTime(2018, 06, 01),
                DataValidade = new DateTime(2018, 06, 01),
                Quantidade = 50,
                ValorUnitario = 35.80,
                CodigoBarra = numeroRandomico.Next(500, 9999),
                Calorias = 26,
                FornecedorNome = "César e Vanessa Entregas Expressas Ltda",
                FornecedorCodigo = numeroAleatorio,
                FornecedorCnpj = "57.772.661/0001-52",
                FornecedorCep = "06714-190"
            });

            Program.alimentos.Add(new ListaAlimento()
            {
                Nome = "Feijão",
                GrupoAlimentar = "Cereais",
                DataFabricacao = new DateTime(2018, 06, 01),
                DataValidade = new DateTime(2018, 06, 01),
                Quantidade = 10,
                ValorUnitario = 15.99,
                CodigoBarra = numeroRandomico.Next(500, 9999),
                Calorias = 67,
                FornecedorNome = "Stefany e Raul Comercio de Bebidas ME",
                FornecedorCodigo = numeroAleatorio,
                FornecedorCnpj = "14.150.015/0001-40",
                FornecedorCep = "13848-671"
            });

            Program.alimentos.Add(new ListaAlimento()
            {
                Nome = "Coxinha",
                GrupoAlimentar = "Carne",
                DataFabricacao = new DateTime(2018, 06, 01),
                DataValidade = new DateTime(2018, 06, 01),
                Quantidade = 22,
                ValorUnitario = 14.80,
                CodigoBarra = numeroRandomico.Next(500, 9999),
                Calorias = 49,
                FornecedorNome = "Manoel e Helena Doces & Salgados ME",
                FornecedorCodigo = numeroAleatorio,
                FornecedorCnpj = "75.712.144/0001-70",
                FornecedorCep = "06806-030"
            });

            Program.alimentos.Add(new ListaAlimento()
            {
                Nome = "Maçã",
                GrupoAlimentar = "Frutas",
                DataFabricacao = new DateTime(2018, 06, 01),
                DataValidade = new DateTime(2018, 06, 01),
                Quantidade = 15,
                ValorUnitario = 1.50,
                CodigoBarra = numeroRandomico.Next(500, 9999),
                Calorias = 10,
                FornecedorNome = "Jéssica e Lara Restaurante ME",
                FornecedorCodigo = numeroAleatorio,
                FornecedorCnpj = "03.730.469/0001-74",
                FornecedorCep = "14800-022"
            });

            Program.alimentos.Add(new ListaAlimento()
            {
                Nome = "Cenoura",
                GrupoAlimentar = "Legumes",
                DataFabricacao = new DateTime(2018, 06, 01),
                DataValidade = new DateTime(2018, 06, 01),
                Quantidade = 36,
                ValorUnitario = 2.99,
                CodigoBarra = numeroRandomico.Next(500, 9999),
                Calorias = 90,
                FornecedorNome = "Kauê e Miguel Pizzaria Ltda",
                FornecedorCodigo = numeroAleatorio,
                FornecedorCnpj = "86.589.678/0001-77",
                FornecedorCep = "03814-005"
            });

            Program.alunos.Add(new ListaAluno()
            {
                Nome = "Tomás Gomes Fernandes",
                Nacionalidade = "Brasil",
                CPF = "956.673.520-01",
                RG = "45.840.636-3",
                Cursando = true,
                Nascimento = new DateTime(2004, 03, 08),
                DataMatricula = new DateTime(2018, 06, 01),
                NumeroMatricula = numeroAleatorio,
                Sexo = "Masculino",
                Turno = "Vespertino",
                Turma = "1• EM - Turma 3.2",
                Cep = "02223-030",
                NumeroCasa = 444,
                Complemento = "São Paulo",
                NomeResponsavel = "Aline Carvalho Goncalves",
                SexoResponsavel = "Feminino",
                DataNascimentoResponsavel = new DateTime(1969, 04, 01),
                CPFResponsavel = "322.524.452-03",
                TelefoneResponsavel = "(31) 8294-5394",
                EmailResponsavel = "AlineCarvalhoGoncalves@dayrep.com",
                RGResponsavel = "20.209.715-8"
            });

            Program.alunos.Add(new ListaAluno()
            {
                Nome = "Antônio Cardoso Carvalho",
                Nacionalidade = "Brasil",
                CPF = "952.684.283-90",
                RG = "23.590.969-5",
                Cursando = true,
                Nascimento = new DateTime(2003, 08, 03),
                DataMatricula = new DateTime(2018, 06, 01),
                NumeroMatricula = numeroAleatorio,
                Sexo = "Masculino",
                Turno = "Matutino",
                Turma = "3• EF - Turma 3.0",
                Cep = "89066-691",
                NumeroCasa = 1244,
                Complemento = "Gravatá",
                NomeResponsavel = "Martim Carvalho Goncalves",
                SexoResponsavel = "Masculino",
                DataNascimentoResponsavel = new DateTime(1981, 12, 28),
                CPFResponsavel = "57061-335",
                TelefoneResponsavel = "(82) 9093-3214",
                EmailResponsavel = "MartimCarvalhoGoncalves@dayrep.com",
                RGResponsavel = "32.584.753-8"
            });

            Program.alunos.Add(new ListaAluno()
            {
                Nome = "Kauan Lima Dias",
                Nacionalidade = "Brasil",
                CPF = "315.490.703-39",
                RG = "46.736.059-5",
                Cursando = true,
                Nascimento = new DateTime(2010, 07, 07),
                DataMatricula = new DateTime(2018, 06, 01),
                NumeroMatricula = numeroAleatorio,
                Sexo = "Masculino",
                Turno = "Noturno",
                Turma = "5• EM - Turma 1.2",
                Cep = "16201-317",
                NumeroCasa = 1378,
                Complemento = "Birigüi",
                NomeResponsavel = "Marcos Costa Ribeiro",
                SexoResponsavel = "Masculino",
                DataNascimentoResponsavel = new DateTime(1973, 06, 22),
                CPFResponsavel = "431.746.225-73",
                TelefoneResponsavel = "(71) 4369-6699",
                EmailResponsavel = "MarcosCostaRibeiro@teleworm.us",
                RGResponsavel = "45.340.050-4"

            });

            Program.alunos.Add(new ListaAluno()
            {
                Nome = "Tânia Cavalcanti Oliveira",
                Nacionalidade = "Brasil",
                CPF = "493.429.312-43",
                RG = "20.955.850-7",
                Cursando = true,
                Nascimento = new DateTime(2003, 07, 08),
                DataMatricula = new DateTime(2018, 06, 01),
                NumeroMatricula = numeroAleatorio,
                Sexo = "Feminino",
                Turno = "Matutino",
                Turma = "8• EM - Turma 2.2",
                Cep = "05344-070",
                NumeroCasa = 836,
                Complemento = "São Paulo",
                NomeResponsavel = "André Azevedo Souza",
                SexoResponsavel = "Masculino",
                DataNascimentoResponsavel = new DateTime(1983, 04, 29),
                CPFResponsavel = "704.101.042-21",
                TelefoneResponsavel = "(67) 7488-8801",
                EmailResponsavel = "AndreAzevedoSouza@dayrep.com",
                RGResponsavel = "36.042.910-5"

            });

            Program.alunos.Add(new ListaAluno()
            {
                Nome = "Raissa Araujo Rodrigues",
                Nacionalidade = "Brasil",
                CPF = "259.288.998-15",
                RG = "37.232.237-2",
                Cursando = true,
                Nascimento = new DateTime(2008, 05, 20),
                DataMatricula = new DateTime(2018, 06, 01),
                NumeroMatricula = numeroAleatorio,
                Sexo = "Feminino",
                Turno = "Noturno",
                Turma = "4• EM - Turma 0.3",
                Cep = "18055-440",
                NumeroCasa = 636,
                Complemento = "Sorocaba",
                NomeResponsavel = "Clara Pinto Silva",
                SexoResponsavel = "Feminino",
                DataNascimentoResponsavel = new DateTime(1978, 08, 07),
                CPFResponsavel = "128.298.320-27",
                TelefoneResponsavel = "(61) 8127-8953",
                EmailResponsavel = "ClaraPintoSilva@armyspy.com",
                RGResponsavel = "30.190.923-4"

            });

            Program.usuarios.Add(new ListaUsuarios()
            {
                Nome = "Rafael Carvalho Ribeiro",
                Login = "Muche1981",
                Senha = "iephoh1Ie",
                Setor = "Secretaria",
                Previlegio = "Usuario",
                Email = "AnaPereiraSousa@rhyta.com"

            });

            Program.usuarios.Add(new ListaUsuarios()
            {
                Nome = "Ana Pereira Sousa",
                Login = "Shors1984",
                Senha = "quoughoh4Ch",
                Setor = "Financeiro",
                Previlegio = "Usuario",
                Email = "labissoni@gmail.com"
            });

            Program.usuarios.Add(new ListaUsuarios()
            {
                Nome = "Marina Rodrigues Azevedo",
                Login = "Ablencesee1976",
                Senha = "chawuR3su",
                Setor = "Biblioteca",
                Previlegio = "Usuario",
                Email = "MarinaRodriguesAzevedo@teleworm.us"
            });

            Program.usuarios.Add(new ListaUsuarios()
            {
                Nome = "Julia Costa Pinto",
                Login = "Lattlyined",
                Senha = "aeZiem3ohN",
                Setor = "Refeitorio",
                Previlegio = "Usuario",
                Email = "JuliaCostaPinto@rhyta.com"
            });
            Program.usuarios.Add(new ListaUsuarios()
            {
                Nome = "Clara Souza Pereira",
                Login = "Jakess",
                Senha = "zeeL9iet",
                Setor = "Diretoria",
                Previlegio = "Usuario",
                Email = "ClaraSouzaPereira@jourrapide.com"
            });

            Program.equipamentos.Add(new ListaEquipamento()
            {
                Nome = "Televisor",
                Marca = "Bombastik",
                Quantidade = 5,
                Setor = "Sala de Aula",
                DataEntrada = new DateTime(2018, 06, 01)

            });

            Program.equipamentos.Add(new ListaEquipamento()
            {
                Nome = "Fax",
                Marca = "Colorado",
                Quantidade = 15,
                Setor = "Diretoria",
                DataEntrada = new DateTime(2018, 06, 01)

            });
            Program.equipamentos.Add(new ListaEquipamento()
            {
                Nome = "Panela",
                Marca = "AluminioBrilha",
                Quantidade = 8,
                Setor = "Refeitório",
                DataEntrada = new DateTime(2018, 06, 01)

            });
            Program.equipamentos.Add(new ListaEquipamento()
            {
                Nome = "Projetor",
                Marca = "Epsozisk",
                Quantidade = 19,
                Setor = "Biblioteca",
                DataEntrada = new DateTime(2018, 06, 01)

            });
            Program.equipamentos.Add(new ListaEquipamento()
            {
                Nome = "Vassoura",
                Marca = "Feiticeira",
                Quantidade = 50,
                Setor = "Almoxerifado",
                DataEntrada = new DateTime(2018, 06, 01)

            });

            Program.produtos.Add(new ListaProduto()
            {
                Nome = "Caneta",
                Quantidade = 15,
                Setor = "Diretoria",
                ValorUnitario = 1.50,
                Entrada = new DateTime(2018, 06, 01)

            });
            Program.produtos.Add(new ListaProduto()
            {
                Nome = "Lápis",
                Quantidade = 50,
                Setor = "Secretaria",
                ValorUnitario = 10.50,
                Entrada = new DateTime(2018, 06, 01)

            });
            Program.produtos.Add(new ListaProduto()
            {
                Nome = "Livro Ciências",
                Quantidade = 06,
                Setor = "Biblioteca",
                ValorUnitario = 50.66,
                Entrada = new DateTime(2018, 06, 01),
                LivroNome = "Ciências humanas",
                LivroCapa = "Dura",
                LivroDisciplina = "Ciências",
                LivroAnoLancamento = new DateTime(2018, 06, 01),
                LivroNomeAutor = "Renan Martins Cunha"
            });
            Program.produtos.Add(new ListaProduto()
            {
                Nome = "Caderno",
                Quantidade = 10,
                Setor = "Diretoria",
                ValorUnitario = 10.99,
                Entrada = new DateTime(2018, 06, 01),

            });
            Program.produtos.Add(new ListaProduto()
            {
                Nome = "Canetão",
                Quantidade = 60,
                Setor = "Sala de Aula",
                ValorUnitario = 99.50,
                Entrada = new DateTime(2018, 06, 01)

            });






        }
    }
}
