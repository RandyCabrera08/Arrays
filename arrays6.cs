using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            double[] numeros = new double[4]; // Se declara un arreglo de doubles de tamaño 4 para almecenar los numeros
            double suma=0; // Se declara una variable double para almacenar la suma de los numeros
            double media; // Se declara una variable double para guardar la media de los numeros
            Console.WriteLine("Este programa captura 4 numeros por teclado proporcionados por el usuario, y despues muestra en pantalla la media y los numeros"); // Se indica al usuario que hace el programa
            // Se declara un ciclo for para capturar los datos puesto que ya conocemos cuantas veces se hara el ciclo
            for(int c=0; c<4; c++){
                Console.Write("Introduzca el valor {0}: ", c+1); // Se indica al usuario en intruduzca el numero
                numeros[c] = Convert.ToDouble(Console.ReadLine()); // Se convierte y se guarda el numero introducido dentro del arreglo en la posicion c
                suma += numeros[c]; // Se van sumando los numeros introducidos dentro de la variable suma
            }
            media = suma / 4;
            Console.Write("\nLos numeros introducidos fueron: "); // Texto para mostrar los numeros introducidos
            for(int c=0; c<4; c++){
                Console.Write(" ({0}) ", numeros[c]); // Se hace un ciclo for para mostrar los numeros capturados
            }
            Console.Write("\nY la media aritmetica es: {0}", media); // Finalmente se presenta la media al usuario
        }
    }
}
