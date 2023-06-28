using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            string x = "";

            do
            {

                var respuesta = IngresarPersona();
                personas.Add(respuesta);
                Console.Clear();
                x = LeerDatos("Deseas registrar otra persona:");

            } while (x == "si");
            Imprimir(personas);

            Console.ReadKey();

        }



        public static Persona IngresarPersona()
        {

            Persona persona = new Persona();
            persona.Nombre = LeerDatos("Ingresa nombre:");
            persona.Paterno = LeerDatos("Ingresa apeido paterno:");
            persona.Materno = LeerDatos("Ingresa el apeido materno:");
            persona.sexo = LeerDatos("Ingreesa tu sexo:");
            persona.Edad = Convert.ToInt32(LeerDatos("Ingresa edad:"));



            return persona;
        }
        public static string LeerDatos(string mensaje)
        {
            string datoLeidodeteclado = "";
            Console.WriteLine(mensaje);
            datoLeidodeteclado = Console.ReadLine();
            return datoLeidodeteclado;
        }
        public static void Imprimir(List<Persona> personas)
        {
            string concatenacion="";
            int indice =0;
            foreach (var item in personas)
            {
                
                int numeracion = indice + 1;
                Console.WriteLine( numeracion + ".-" + item.Nombre + " " + item.Paterno + " " + item.Materno + " " + item.sexo + " " + item.Edad);
                


            }
        }
    }
}
