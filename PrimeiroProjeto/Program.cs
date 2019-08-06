using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Hello World!");

            /*      
                         --------THIS CODE SHOW HOW TO USE THE FORMATATION WITH THE INVARINT CULTURE--------

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1+"," + " cujo preço é $ " + preco1.ToString("F2"));
            Console.WriteLine(produto2+"," + " cujo preço é $ " + preco2.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondando (três casas decimais: " + medida.ToString("F3"));
            Console.WriteLine("Separador invariant culture: " + medida.ToString("F3",CultureInfo.InvariantCulture));
            */

            /*
            
                                 --------THIS SHOW HOW TO USE THE METHOD SPLIT--------

            Console.WriteLine("Entre com seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço do produto ?");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu último nome \nSua idade \nSua altura");
            string[] vet = Console.ReadLine().Split(' ');
            string sobreNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobreNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
                                          --------ESTRUTURA CONDICIONAL-------

            Console.WriteLine("Digite um número...");
            int x = int.Parse(Console.ReadLine());
         
                if (x % 2 == 0) {
                    Console.WriteLine("É PAR !!!");
                } else {
                    Console.WriteLine("É ÍMPAR !!!");
                }
            
            Console.WriteLine("Digite a hora a atual");
            int hora = int.Parse(Console.ReadLine());
            if(hora < 12) {
                Console.WriteLine("Bom dia");
            }else if(hora <= 18) {
                Console.WriteLine("Boa tarde");
            } else {
                Console.WriteLine("Boa noite");
            }
            */

            /*
                                         -------ESTRUTURA DE REPETIÇÃO-------  
            
            Console.WriteLine("Digite um número");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x >= 0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine("A raiz quadrada de " + x + " é " + raiz.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite um número");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }            
            Console.WriteLine("O número " + x +" é negativo... \nAté logo");
            
            Console.WriteLine("Quantos números você vai digitar? ");
            int qtdNum = int.Parse(Console.ReadLine());
            int soma = 0;
            for(int i = 1; i <= qtdNum; i++) {
                Console.WriteLine("Digite o " + i + "° número");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;                
            }
            Console.WriteLine("A soma dos valores é " + soma);
            */

            /*
                            -------ORIENTAÇÃO A OBJETOS CLASSE TRIÂNGULO------- 
            
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite as medidas dos triângulos X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas dos triângulos Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("A área de X é: " + areaX.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("A área de Y é: " + areaY.ToString("F3", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("A maior área é a do X: " + areaX.ToString("F3", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("A maior área é a do Y: " + areaY.ToString("F3", CultureInfo.InvariantCulture));

            }
            */
            /*
                                ---------Chamando Métodos Class Produto com Construtor---------        
            
            

            Console.WriteLine("Digite o Nome do Produto");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o Preço do Produto");
           double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.WriteLine("Digite a Quantidade do Produto");
            int quantidade = int.Parse(Console.ReadLine());
            
            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a serem adicionados... ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine("Produto atualizado" + p);

            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a serem removidos.. ");
            int qteMenos = int.Parse(Console.ReadLine());
            p.RemoveProduto(qteMenos);
            Console.WriteLine("Produto atualizado" + p);
            
            
            /*
                     ====== Chamando Método static(sem instância de obj) class ConversorDeMoeda =========
            
            Console.WriteLine("Qual é a cotação do dolar ?");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares voçê vai comprar ? ");
            double qteDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorFinal = ConversorDeMoeda.CalculaValor(cotacao, qteDolares);
            Console.WriteLine("O valor a ser pago será de R$ " + valorFinal.ToString("F2"));

            */
            /*
                      ========= ORDEM SUGERIDA PARA PARA IMPLEMENTÇÃO DE UMA CLASSE ============
             * ATRIBUTOS PRIVADOS 
             * PROPRIEDADES AUTOIMPLEMENTADAS 
             * CONSTRUTOES
             * PROPRIEDADES CUSTOMIZADAS
             * OUTROS MÉTODOS
             */

            /*
                    ===============DATA USANDO O ParseExact=====================
                    outros DateTime.Now();
            DateTime d1 = DateTime.ParseExact("15/05/2019 12:50:26", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            */

            Console.WriteLine("E ai gurizada do Hibernete");
            Console.WriteLine("=====================");
            Console.WriteLine("C# tá oh");
            Console.WriteLine("...");
            Console.WriteLine("Estralando");


        }

    }
}
