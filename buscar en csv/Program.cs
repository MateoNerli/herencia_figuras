using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace buscar_en_csv
{
    internal class Program
    {
        static void grabar()
        {
            string ape;
            float sueldo;
            int legajo;
            string direccion;

            FileStream archivo;
            StreamWriter grabador;

            archivo = new FileStream("archivo.csv", FileMode.Append);

            grabador = new StreamWriter(archivo);

            Console.Write("ingesar apellido: ");
            ape = Console.ReadLine();
            Console.Write("ingresar sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
            Console.Write("ingresar legajo: ");
            legajo = int.Parse(Console.ReadLine());
            Console.Write("ingresar direccion: ");
            direccion = Console.ReadLine();

            grabador.WriteLine("{0};{1};{2};{3}", ape, sueldo, legajo, direccion);

            grabador.Close();
            archivo.Close();
        }

        static void leer()
        {
            string cadena;
            string[] V;

            FileStream datos;
            StreamReader Lector;
            datos = new FileStream("archivo.csv", FileMode.Open);
            Lector = new StreamReader(datos);
            while (Lector.EndOfStream == false)
            {
                cadena = Lector.ReadLine();
                Console.WriteLine(cadena);
                V = cadena.Split(';');
                     
               Console.WriteLine(V[0].PadLeft(30, '-'));
               Console.WriteLine(V[1].PadRight(30, '-'));
               Console.WriteLine(V[2].PadRight(30, '-'));
               Console.WriteLine(V[3].PadLeft(30, '-'));
            }
            Lector.Close();
            datos.Close();
        }

        static void busqueda()
        { 
            int cont = 0;
            string linea, buscar;

            FileStream archivos;
            StreamReader busqueda;
            archivos = new FileStream("archivo.csv", FileMode.Append);
            busqueda = new StreamReader(archivos);

            Console.WriteLine("Ingrese el criterio de busqueda:");
            buscar = Console.ReadLine();

            while ((linea = busqueda.ReadLine()) == buscar)
            {
                Console.WriteLine(linea);
                cont = cont + 1;
            }
            busqueda.Close();
            archivos.Close();

            Console.WriteLine("Se han encontrado {0} Registros.", cont);
            Console.ReadLine();
        }
        
        
        
        static void Main(string[] args)
        {
       /*     int opcion;     

            Console.Write("1-Para grabar \n2-Para ver \n3-Para buscar: \n0-Para salir: \nIngrsar numero: ");
            opcion = int.Parse(Console.ReadLine());

            while (opcion != 0)
            {
                if (opcion == 1)
                {
                    grabar();
                }
                else if (opcion == 2)
                {
                    leer();
                }
                else if(opcion == 3)
                {
                    busqueda();
                }

                Console.Write("1-Para grabar \n2-Para ver \n3-Para buscar: \n0-Para salir: \nIngrsar numero: ");
                opcion = int.Parse(Console.ReadLine());
            }*/

            if (args.Length >= 2)
            {
                if (args[1] == "120")
                {
                       
                }
            }
            Console.ReadKey();
        }
    }
}
