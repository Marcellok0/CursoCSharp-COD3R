﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritimeticos {
        public static void Executar() {
            //preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é: {0}", totalComDesconto);

            //IMC
            double peso = 105.0;
            double altura = 1.80;
            double imc = peso / Math.Pow(altura, 2); //potencia (base, expoente) -   ou outra forma de fazer (altura * altura);
            Console.WriteLine($"IMC é {imc}.");

            //Numero Par/Impar

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            ///*par % 2  Módulo = resto da divisão 
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
