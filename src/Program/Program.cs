using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona { Nombre = "Belén", Edad = 10 };
            Persona persona2 = new Persona { Nombre = "María", Edad = 12 };
            Persona persona3 = new Persona { Nombre = "Pedro", Edad = 5 };
            Persona persona4 = new Persona { Nombre = "Noel", Edad = 6 };
            Persona persona5 = new Persona { Nombre = "Milagros", Edad = 4 };
            Persona persona6 = new Persona { Nombre = "Agustin", Edad = 2 };
            Persona persona7 = new Persona { Nombre = "Santi", Edad = 1 };
            Persona persona8 = new Persona { Nombre = "Santino", Edad = 5 };

            Node n1 = new Node(1, persona1);
            Node n2 = new Node(2, persona2);
            Node n3 = new Node(3, persona3);
            Node n4 = new Node(4, persona4);
            Node n5 = new Node(5, persona5);
            Node n6 = new Node(6, persona6);
            Node n7 = new Node(7, persona7);
            Node n8 = new Node(8, persona8);


            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí

            //suma de edades
            SumaEdadesVisitor sumaEdadesVisitor = new SumaEdadesVisitor();
            n1.Accept(sumaEdadesVisitor);

            int SumaEdades = sumaEdadesVisitor.SumaEdades;
            Console.WriteLine($"Suma de edades: {SumaEdades}");

            //mayor edad
            LargestChildVisitor largestChildVisitor = new LargestChildVisitor();
            n1.Accept(largestChildVisitor);

            int largestChildAge = largestChildVisitor.LargestChild.Edad;
            string largestChildName = largestChildVisitor.LargestChild.Nombre;
            Console.WriteLine($"El niño más grande es: {largestChildName} y tiene {largestChildAge} años");

            //nombre más largo
            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();
            n1.Accept(longestNameVisitor);

            string longestName = longestNameVisitor.LongestName;
            Console.WriteLine($"El niño con el nombre más largo es: {longestName}");

        }
    }
}
