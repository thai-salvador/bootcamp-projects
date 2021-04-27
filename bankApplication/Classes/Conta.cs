using System;
namespace bankApplication
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; } // enum
        private string Nome { get; set; }
        private double Credito { get; set; }
        private double Saldo { get; set; }

        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.Nome = nome;
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito; 
        }

        public bool Sacar(double valorSaque)
        { 
            // validação de saldo suficiente
            if (this.Saldo - valorSaque < (this.Credito * -1)) // verificar se o cliente quer sacar mais do que dispõe
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque; // this.Saldo = this.Saldo - valorSaque
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito; // this.Saldo = this.Saldo + valorDeposito
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
           string retorno = "";
           retorno += "TipoConta " + this.TipoConta + " | ";
           retorno += "Nome " + this.Nome + " | ";
           retorno += "Saldo " + this.Saldo + " | ";
           retorno += "Crédito " + this.Credito + " | ";
           return retorno;
        }
    }  
}