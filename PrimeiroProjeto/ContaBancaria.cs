using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto {
    class ContaBancaria {

        public int NumConta;
        public string TitularConta;
        public double Saldo;

        public ContaBancaria( int numConta, string titularConta) {
            Saldo = 0.00;
        }


        public ContaBancaria(int numConta, string titularConta, double saldo) {
            NumConta = numConta;
            TitularConta = titularConta;
            Saldo = saldo;
        }
    }
}
