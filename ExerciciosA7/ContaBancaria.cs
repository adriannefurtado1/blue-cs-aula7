using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosA7
{
    /*Crie uma classe Conta Bancária que possua os seguintes atributos: 
     * número da conta, nome do cliente e saldo privados. 
     * Além dos métodos de get para os atributos crie um método para alterar o nome, 
     * realizar depósitos e saques. 
     * Também construa um construtor onde saldo é opcional, 
     * com valor default zero, já os demais atributos são obrigatórios.
    */

    internal class ContaBancaria
    {
        private double conta;
        private string nomeCliente;
        private float saldo = 0.00f;

        public double Conta
        {
            get { return conta; }
            set { conta = value; }
        }

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public ContaBancaria(double Conta, string NomeCliente, float Saldo)
        {
            this.Conta = Conta;
            this.NomeCliente = NomeCliente;
            this.Saldo = Saldo;

            //Menu();
        }

        /*public Menu()
        {
            int operacao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("* Escolha a operação?                                           *");
                Console.WriteLine("* 1 - Alterar nome                                              *");
                Console.WriteLine("* 2 - Depositar                                                 *");
                Console.WriteLine("* 3 - Sacar                                                     *");
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
        
        private AlteraNome()
        {

        }

        private Depositar()
        {

        }

        private Sacar()
        {

        }*/
    }
}
