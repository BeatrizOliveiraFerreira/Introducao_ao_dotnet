
// Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.

// A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

// Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.



using System;
    class desafioum {
      static void Main() {
        decimal A = 3 / -2;
        Console.WriteLine(A + ".5");

        Console.WriteLine("divisao impossivel");
    
        int N = 0 / 8;
        Console.WriteLine(N + ".0");
      }
    }