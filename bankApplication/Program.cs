using System;
using System.Collections.Generic;

namespace bankApplication
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoDoUsuario = ObterOpcaoDoUsuario();
            while (opcaoDoUsuario.ToUpper() != "X")
            {
                switch (opcaoDoUsuario)
                {
                    case "1":
                        InserirConta();
                        break;
                    case "2":
                        ListarContas();
                        break;
                    case "3":
                        Sacar();
                        break;
                    case "4":
                        Depositar();
                        break;
                    case "5":
                        Transferir();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                } 

                opcaoDoUsuario = ObterOpcaoDoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar os nossos serviços.");
            Console.ReadLine();
        }


        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.WriteLine("Digite 1 para Conta Física ou 2 para Conta Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito a que o cliente tem direito: ");
            double entradaCredito = double.Parse(Console.ReadLine());
            
            Conta novaConta = new Conta(tipoConta:(TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);

            listContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        private static void Sacar()
        {
            Console.Write("Digite o númera da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
        }

        private static void Depositar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Transferir()
        {
            Console.WriteLine("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static string ObterOpcaoDoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoDoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoDoUsuario;
        }
        
    }
}
