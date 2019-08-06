using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PrimeiroProjeto {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {
          return  Quantidade * Preco;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoveProduto(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome + " ," 
                + Preco.ToString("F2",CultureInfo.InvariantCulture)+ " , " 
                + Quantidade  
                + " unidades" + " , "
                + "Valor Total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
