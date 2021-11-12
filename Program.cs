/*
Nome: Laidone Mendes de Carvalho
*/

using System;
using System.Collections;

namespace Laboratorio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1 + "\n");
            Console.WriteLine("Coordenada X do círculo 1 com os valor padrão -> " + circ1.CentroX + "\n");
            Console.WriteLine("Coordenada Y do círculo 1 com os valor padrão -> " + circ1.CentroY + "\n");
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine("Coordena X do círculo 2 -> " + circ2.CentroX + "\n");
            Console.WriteLine("Coordena Y do círculo 2 -> " + circ2.CentroY + "\n");
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3 + "\n");
            Console.WriteLine("Coordenada X do círculo colorido com valor padrão é colorido -> " + circ3.CentroX);
            Console.WriteLine("Coordenada Y do círculo colorido com valor padrão é colorido -> " + circ3.CentroY + "\n");
            // Foi possível utilizar as propriedades CentroX e Centro Y pois a classe Círuclo colorido herda as propriedades da Classe Círculo
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4 + "\n");
            Console.WriteLine("Coordenada X do círculo colorido com valor padrão é colorido -> " + circ4.CentroX);
            Console.WriteLine("Coordenada Y do círculo colorido com valor padrão é colorido -> " + circ4.CentroY + "\n");
            CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido();
            Console.WriteLine(circ5);
            CirculoColoridoPreenchido circ6 = new CirculoColoridoPreenchido(1.5, 3.1, 1, "Vermelho");
            Console.WriteLine(circ6);
            ArrayList list = new ArrayList();
            list.Add(circ3);
            Console.WriteLine(list[0]);
        }
    }
}