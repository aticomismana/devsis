using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposPrimitivos
{
    class Program
    {
        enum Dias { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado }
        enum Dias1 { Domingo=11, Segunda=12, Terça=13, Quarta=14, Quinta=15, Sexta=16, Sábado=17 }

        static void Main(string[] args)
        {
            // inteiro
            int numero = 3;
            Console.WriteLine(numero);

            // float
            float numero2 = 2;
            int resultado = numero + (int) numero2;
            Console.WriteLine(resultado);

            // string
            String text = "Olá mundo";
            Console.WriteLine(text);

            // bool representado por true e false
            bool certidaoDeVivo = false;
            Console.WriteLine("Você está vivo? {0}",certidaoDeVivo);

            // enum
            Dias dia = Dias.Domingo;
            Console.WriteLine(dia);
            Console.WriteLine("Dia referencia numerica: {0}", (int)dia);

            Dias1 dia1 = Dias1.Segunda;
            Console.WriteLine(dia1);
            Console.WriteLine("Dia referencia numerica: {0}", (int)dia1);

            // vetor unidimensional
            int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr = new int[10];

            Console.WriteLine(num[5]);

            // Matriz
            int[,] mat = new int[5, 5];
            mat[0, 1] = 1;
            mat[0, 2] = 2;

            Console.WriteLine("Valor da matriz na posicao [0,1]:"+mat[0,1]);

            List<String> frutas = new List<String>();
            frutas.Add("pera");
            frutas.Add("Maça");
            frutas.Add("Banana");

            Console.WriteLine(frutas[0]);

            frutas.Remove("Banana");

            List<int> sorteio = new List<int>();
            sorteio.Add(1);

            Console.ReadLine();
            // comentario
        }
    }
}
