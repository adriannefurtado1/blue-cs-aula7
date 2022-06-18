using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosA7
{
    /* 
     *   1. Cadastro de Alunos
     *   Considere uma classe Aluno. 
     *   Esta classe possui como atributos privados o nome, as notas e a frequência. 
     *   Além do construtor, esta classe deve conter os métodos que cadastram os alunos, 
     *   adiciona suas notas, consulta um aluno por código e consulta todos os alunos do cadastro.
     */

    internal class Aluno
    {
        
        int[] frequencia = new int[20]; //frequencia é mencionada no escopo porém não tem uso dentro do escopo proposto


        private double codigo;
        private string nome;
        private double nota1;
        private double nota2;
        private double nota3;
   
        public double Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Nota1
        {
            get { return nota1; }   
            set { nota1 = value; }
        }

        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public double Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }

        public Aluno()
        {
            Menu();
        }

        public void Menu()
        {
            int operacao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("* Escolha a operação?                                           *");
                Console.WriteLine("* 1 - Cadastrar aluno                                           *");
                Console.WriteLine("* 2 - Adicionar notas do aluno                                  *");
                Console.WriteLine("* 3 - Consultar aluno por código                                *");
                Console.WriteLine("* 4 - Listar todos os alunos                                    *");
                Console.WriteLine("* 0 - Sair.                                                     *");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine();

                Console.Write("Digite a operação: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (operacao)
                {
                    case 1:
                        this.CadastraAluno();
                        break;
                    case 2:
                        this.AdicionaNotas();
                        break;
                    case 3:
                        this.ConsultaUmAluno();
                        break;
                    case 4:
                        this.ConsultaTodosOsAlunos();
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (operacao != 0);
        }

        public void CadastraAluno()
        {
            Console.WriteLine("[ CADASTRAR ALUNO ]");
            Console.WriteLine();

            Console.Write("Informe o código do aluno: ");
            this.Codigo = double.Parse(Console.ReadLine());

            Console.Write("Informe o nome do aluno: ");
            this.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
        }

        public void AdicionaNotas()
        {
            int operacao = -1;
            double nota = 0;

            Console.WriteLine($"[ ADICIONAR NOTAS ALUNO {this.Nome} ]");
            Console.WriteLine();
            
            if (this.Codigo == 0 || this.Nome == null)
            {
                Console.WriteLine($"[ ATENÇÃO: O aluno ainda não foi cadastrado. ]");
                Console.ReadLine();
                operacao = 0;
            }
            else
            {
                do
                {
                  
                    Console.WriteLine();
                    Console.WriteLine("*****************************************************************");
                    Console.WriteLine("* Qual nota deseja adicionar?                                   *");
                    Console.WriteLine("* 1 - Nota 1                                                    *");
                    Console.WriteLine("* 2 - Nota 2                                                    *");
                    Console.WriteLine("* 3 - Nota 3                                                    *");
                    Console.WriteLine("* 0 - Voltar                                                    *");
                    Console.WriteLine("*****************************************************************");
                    Console.WriteLine();

                    Console.Write("Digite a opcao: ");
                    operacao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (operacao != 0)
                    {
                        Console.Write($"Digite a nota {operacao}: ");
                        nota = double.Parse(Console.ReadLine());
                    }


                    switch (operacao)
                    {
                        case 1:
                            this.Nota1 = nota;
                            Console.WriteLine($"Nota {operacao} registrada para o aluno {this.Nome}.");
                            break;
                        case 2:
                            this.Nota2 = nota;
                            Console.WriteLine($"Nota {operacao} registrada para o aluno {this.Nome}.");
                            break;
                        case 3:
                            this.Nota3 = nota;
                            Console.WriteLine($"Nota {operacao} registrada para o aluno {this.Nome}.");
                            break;
                        case 0:
                            break;
                        default:
                            break;
                    }
                } while (operacao != 0);
            }

            Console.WriteLine();
            Console.WriteLine();
            
        }

        public void ConsultaUmAluno()
        {
            double codigoDigitado;
            Console.WriteLine("[ CONSULTAR ALUNO ]");
            Console.WriteLine();

            Console.Write("Informe o código do aluno: ");
            codigoDigitado= double.Parse(Console.ReadLine());

            if (this.Codigo == codigoDigitado)
            {
                Console.WriteLine($"====================================================");
                Console.WriteLine($"[ DADOS DO ALUNO ] ");
                Console.WriteLine($"Nome: {this.Nome}");
                Console.WriteLine($"Código: {this.Codigo}");
                Console.WriteLine($"Nota 1: {this.Nota1}");
                Console.WriteLine($"Nota 2: {this.Nota2}");
                Console.WriteLine($"Nota 3: {this.Nota3}");
                Console.WriteLine($"====================================================");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"====================================================");
                Console.WriteLine($"[ DADOS DO ALUNO ] ");
                Console.WriteLine();
                Console.WriteLine($"Aluno digitado não existe.");
                Console.WriteLine($"====================================================");
                Console.ReadLine();
            }

        }

        public void ConsultaTodosOsAlunos()
        {

            Console.WriteLine("[ LISTA DE ALUNOS ]");
            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine("*               ATENCAO!!                *");
            Console.WriteLine("* Não implementei a lista de alunos pois *");
            Console.WriteLine("* ia demandar muito tempo em detrimento  *");
            Console.WriteLine("* de estudar e praticar outros conteúdos *");
            Console.WriteLine("* que ainda preciso evoluir.             *");
            Console.WriteLine("******************************************");

            /*Console.WriteLine("[ LISTA DE ALUNOS ]");
            Console.WriteLine();

            Console.WriteLine($"====================================================");
            Console.WriteLine($"[ DADOS DO ALUNO ] ");
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"CPF: {this.Cpf}");
            Console.WriteLine($"Nota 1: {this.Nota1}");
            Console.WriteLine($"Nota 2: {this.Nota2}");
            Console.WriteLine($"Nota 3: {this.Nota3}");
            Console.WriteLine($"====================================================");*/
            Console.ReadLine();
        }
    }
}
