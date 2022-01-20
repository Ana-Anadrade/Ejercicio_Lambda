using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_Lambda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  },
        };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla los nombres de los estudiantes
            var listaAlumno = details.Select(item => new { item.Nombre });
            string leer = string.Join(Environment.NewLine, listaAlumno);
            Console.WriteLine("Los nombres son:");
            Console.WriteLine(leer);
            Console.WriteLine(" \n");
            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            var lista = details.OrderByDescending(item => item.Promedio).Select(ite => new { ite.Nombre, ite.Apellido });
            string leer1 = string.Join(Environment.NewLine, lista);
            Console.WriteLine("Los nombres y apelidos de los estudiantes ordenados por promedio mayor a menor son:");
            Console.WriteLine(leer1);
            Console.WriteLine(" \n");
            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            var leer2 = details.OrderBy(item => item.Apellido).Select(ite => new { ite.Apellido });
            string lectura = string.Join(Environment.NewLine, leer2);
            Console.WriteLine("Los apellidos de los estudiantes ordenados ascendente alfabéticamente son:");
            Console.WriteLine(lectura);
            Console.WriteLine(" \n");
            //4. Muestre por pantalla los datos del estudiante mas joven
            var leer3 = details.OrderBy(a => a.Edad).First();
            Console.WriteLine("Los datos del estudiante mas joven son:");
            Console.WriteLine(string.Join("", leer3.Id, leer3.Nombre, leer3.Apellido, leer3.Promedio, leer3.Edad, ""));
            Console.WriteLine(" \n");
            List<int> numero = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            var Ecuadrado = numero.Select(numero => numero * 2);
            Console.WriteLine("El cudrado de los numeros son:");
            Console.WriteLine(string.Join("  ", Ecuadrado));
            Console.WriteLine(" \n");
            //2. Muestre por pantalla los números pares
            var Epares = numero.Select(numero => numero % 2);
            Console.WriteLine("Los numeros pares son:");
            Console.WriteLine(string.Join("  ", Epares));
            Console.WriteLine(" \n");
            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            List<int> Eimpar = numero.FindAll(i => i % 2 != 0);
            var multi = Eimpar.Select(j => j * 5);
            Console.WriteLine("El resultado de multiplicar por 5 los numero impares:");
            Console.WriteLine(string.Join(" ", multi));
            Console.WriteLine(" \n");
        }
    }
}
