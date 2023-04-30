using System;

namespace Ejercicio_1
{
    internal class Program
    {   
                static void Main(string[] args)
        {
            string nombre;
            string email;
            string sexo;
            int sueldo;
            int peso;
            decimal altura;
            
            email = string.Empty;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su sexo");
            sexo = Console.ReadLine();

            Console.WriteLine("¿Cuál es su sueldo?");
            sueldo = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es su peso?");
            peso = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es su altura?");
            altura = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Su email es: ");
            
            Persona nuevaPersona = new Persona (nombre, email, sueldo, sexo, peso, altura);

            Console.WriteLine( 
                    "Su nombre es: " + nuevaPersona.GetNombre() 
                    + "Su sueldo es: " + nuevaPersona.GetSueldo()
                    + "Su sexo es: " + nuevaPersona.GetSexo()
                    + "Su peso es: " +  nuevaPersona.GetPeso() 
                    + "Su altura es: " +   nuevaPersona.GetAltura()
                    + "Su email es: " + nuevaPersona.GetEmail()
                            );


            Console.ReadLine();
        }
    }
}
