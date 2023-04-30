using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
        class Persona {
            //Propiedades
            private string nombre;
            private int sueldo;
            private string email; 
            private string sexo;
            private int peso;
            private decimal altura;

            public Persona(string nombre, string email, int sueldo, string sexo, int peso,
                decimal altura) { 
                this.nombre = nombre;
                this.sueldo = sueldo;
                this.email = email;
                this.sexo = sexo;
                this.peso = peso;
                this.altura = altura;
                CrearEmail(nombre);

            }

            public void CrearEmail ( string nombre)
        {
             this.email = nombre.ToLower() + "@superempresa.com ";
        }

            public string GetEmail ()
        {
            return this.email;
        }
            public string GetNombre ()
            {
                return this.nombre;
            }

            public string GetSexo ()
            {
                return this.sexo;
            }
        //Devuelvo String porque es el tipo de dato que debe recibir la consola.
            public string GetPeso ()
            {
                return this.peso.ToString();
            }

            public string GetSueldo ()
            {
                return this.sueldo.ToString();
            }

            public string GetAltura ()
            {
                return this.altura.ToString();
            }

        }
    }

