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
            int numero = 3;
            Console.WriteLine(numero);

            float numero2 = 2;
            int resultado = numero + (int) numero2;
            Console.WriteLine(resultado);

            String text = "Olá mundo";
            Console.WriteLine(text);

            bool certidaoDeVivo = false;

            Console.WriteLine("Você está vivo? {0}",certidaoDeVivo);

            Dias dia = Dias.Domingo;
            Console.WriteLine(dia);
            Console.WriteLine("Dia referencia numerica: {0}", (int)dia);

            Dias1 dia1 = Dias1.Segunda;
            Console.WriteLine(dia1);
            Console.WriteLine("Dia referencia numerica: {0}", (int)dia1);

            Console.ReadLine();
            // comentario
        }
    }
}
