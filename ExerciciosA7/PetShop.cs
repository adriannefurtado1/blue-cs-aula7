using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosA7
{
    /* 4. Pet Shop
     * Vamos modelar um cadastro de animais de uma pet-shop? 
     * Crie uma classe que modele os animais e contenha como atributos:
     *  .nome, 
     *  .espécie, 
     *  .cor, 
     *  .idade, 
     *  .observação e 
     *  .dados do dono. 
     * Os atributos relacionados ao dono do animal deve ser privados para proteção de dados. 
     * Forrneça métodos para cadastro e leitura das informações.
     */

    internal class PetShop
    {
        double codigo;
        string nomeAnimal;
        string especieAnimal;
        string cor;
        int idade;
        string observação;
        private string nomeDono;
        private double telefone;

        public string NomeAnimal
        {
            get { return nomeAnimal; }
        }

        public string EspecieAnimal
        {
            get { return especieAnimal; }
        }

        public string Cor
        {
            get { return cor; }
        }

        public int Idade
        {
            get { return idade; }
        }

        public string Observacao
        {
            get { return observação; }
        }

        public string NomeDono
        {
            get { return nomeDono; }
        }

        public double Telefone
        {
            get { return telefone; }
        }

        public PetShop()
        {
            Menu();
        }

        private void Menu()
        {
            int operacao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("* Escolha a operação?                                           *");
                Console.WriteLine("* 1 - Cadastrar animal                                          *");
                Console.WriteLine("* 2 - Consultar cadastro animal                                 *");
                Console.WriteLine("* 0 - Sair.                                                     *");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine();

                Console.Write("Digite a operação: ");
                
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (operacao)
                {
                    case 1:
                        this.CadastrarAnimal();
                        break;
                    case 2:
                        this.ImprimeDadosAnimal();
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (operacao != 0);
        }

        public void CadastrarAnimal()
        {
            Console.WriteLine("[ CADASTRAR ANIMAL ]");
            Console.WriteLine();
            Console.WriteLine("Campos com * são obrigatórios.");

            Console.Write("* Código de Registro: ");
            
            this.codigo = double.Parse(Console.ReadLine());

            Console.Write("* Nome do animal: ");
            this.nomeAnimal = Console.ReadLine();

            Console.Write("* Espécie: ");
            this.especieAnimal = Console.ReadLine();

            Console.Write("* Idade: ");
            this.idade = int.Parse(Console.ReadLine());

            Console.Write("* Cor: ");
            this.cor = Console.ReadLine();

            Console.Write("* Telefone: ");
            this.telefone = double.Parse(Console.ReadLine());

            Console.Write("* Nome do Dono: ");
            this.nomeDono = Console.ReadLine();

            Console.Write("Observacões: ");
            this.observação = Console.ReadLine();

            Console.WriteLine($"{this.NomeAnimal} cadastrado com sucesso.");

            Console.WriteLine();
            Console.WriteLine();
        }

        public void ImprimeDadosAnimal()
        {
            Console.WriteLine("[ CONSULTAR ANIMAL ]");
            Console.WriteLine();

            Console.Write("Informe o codigo do animal: ");
            

            Console.WriteLine($"====================================================");
            Console.WriteLine($"[ DADOS DO ANIMAL ] ");
            Console.WriteLine($"Codigo: {this.codigo}");
            Console.WriteLine($"Animal: {this.NomeAnimal}");
            Console.WriteLine($"Especie: {this.EspecieAnimal}");
            Console.WriteLine($"Idade: {this.Idade}");
            Console.WriteLine($"Dono: {this.NomeDono}");
            Console.WriteLine($"Telefone: {this.Telefone}");
            Console.WriteLine($"Observação: {this.Observacao}");
            Console.WriteLine($"====================================================");
            Console.ReadLine();
        }

    }
}
