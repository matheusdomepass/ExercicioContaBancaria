using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    public class Conta
    {
        public int Id { get; private set; }
        public string NomeTitular { get; set; } 
        public double Saldo { get; private set; }

        public Conta(int id, string nomeTitular)
        {
            Id = id;
            NomeTitular = nomeTitular;
        }
        
        public Conta(int id, string nomeTitular, double saldo): this(id, nomeTitular)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public override string ToString() 
        {
            return "Conta "
                 + Id + ", Titular: "
                 + NomeTitular + ", Saldo: $ "
                 + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
