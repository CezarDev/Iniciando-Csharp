using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto {
     class  ConversorDeMoeda {


        public static double CalculaValor(double cot, double qtdDolar) {
            double valorReais = cot * qtdDolar;
            return valorReais + valorReais * 0.06;
         }

        
    }
}
