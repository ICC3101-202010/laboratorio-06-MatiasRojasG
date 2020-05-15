using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab6POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string respuesta;
            string nombreem;
            string rutem;
            List<Empresa> empresas = new List<Empresa> { };
            while (true)
            {
                Console.WriteLine("Buenos días");
                Console.WriteLine("¿Desea cargar una empresa desde el archivo?");
                respuesta = Console.ReadLine();
           

                if (respuesta == "No" || respuesta == "no")
                {
                    Console.WriteLine("Ingrese el nombre de la empresa:");
                    nombreem = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut de la empresa:");
                    rutem = Console.ReadLine();
                    Empresa empresa = new Empresa(nombreem, rutem);
                    empresas.Add(empresa);
                    Save(empresas);






                }
                if (respuesta == "Si" || respuesta == "si")
                {
                    try
                    {
                        empresas = Load();
                        showEnterprises(empresas);
                    }
                    catch(FileNotFoundException)
                    {
                        Console.WriteLine("No pudimos encontrar a la empresa\n");
                        Console.WriteLine("Favor ingrese los datos de la empresa que desea agregar:");

                        Console.WriteLine("Nombre:");
                        nombreem = Console.ReadLine();
                        Console.WriteLine("Rut:");
                        rutem = Console.ReadLine();
                        Empresa empresafnf = new Empresa(nombreem, rutem);
                        empresas.Add(empresafnf);
                        Save(empresas);
                        

                    }
                }
                if (respuesta=="kie")
                {
                    break;
                }





            }
        }

        static public void showEnterprises(List<Empresa> empresas)
        {
            foreach (Empresa empresa in empresas)
            {
                Console.WriteLine("Nombre: "+empresa.Name+" Rut Empresa: "+empresa.Rut);
            }
        }

        static private void Save(List<Empresa> empresas)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresas);
            stream.Close();
        }



        static List<Empresa> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Empresa> empresas = (List<Empresa>)formatter.Deserialize(stream);
            stream.Close();
            return empresas;
        }
    }
}
