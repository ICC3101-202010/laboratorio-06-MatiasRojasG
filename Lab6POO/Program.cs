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
           

                if (respuesta == "No" || respuesta == "no" || respuesta == "NO")
                {
                    Console.WriteLine("Ingrese el nombre de la empresa:");
                    nombreem = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut de la empresa:");
                    rutem = Console.ReadLine();
                    Empresa empresa = new Empresa(nombreem, rutem);
                    empresas.Add(empresa);
                    Console.WriteLine("Ingrese el nombre del departamento");
                    string nombredep = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre del encargado");
                    string nombreenc = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido del encargado");
                    string apellenc = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut del encargado");
                    string rutenc = Console.ReadLine();
                    Persona encargadodep = new Persona(nombreenc, apellenc, rutenc, nombredep);
                    Departamento departamento = new Departamento(nombredep, encargadodep);
                    empresa.AddDivisiondep(departamento); ;


                    Console.WriteLine("Ingrese el nombre de la seccion 1:");
                    string nombresec1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre del encargado");
                    string nombrencs = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido del encargado");
                    string apellencs = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut del encargado");
                    string rutencs = Console.ReadLine();
                    Persona encargadosec = new Persona(nombrencs, apellencs, rutencs, nombresec1);
                    Sección seccion = new Sección(nombredep, encargadosec);
                    empresa.AddDivisionsec(seccion);

                    Console.WriteLine("Ingrese el nombre de la seccion 2:");
                    string nombresec2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre del encargado:");
                    string nombrencs2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido del encargado:");
                    string apellencs2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut del encargado:");
                    string rutencs2 = Console.ReadLine();
                    Persona encargadosec2 = new Persona(nombrencs2, apellencs2, rutencs2, nombresec2);
                    Sección seccion2 = new Sección(nombresec2, encargadosec2);
                    empresa.AddDivisionsec(seccion2);



                    Console.WriteLine("Ingrese el nombre del Bloque:");
                    string nombrebloque = Console.ReadLine();


                    Console.WriteLine("Ingrese el nombre del personal 1:");
                    string nombrepers1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido del personal 1:");
                    string apellpers1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut del personal 1:");
                    string rutpers1 = Console.ReadLine();
                    Persona personal1 = new Persona(nombrepers1, apellpers1, rutpers1, nombrebloque);
                    Console.WriteLine("Ingrese el nombre del personal 2:");
                    string nombrepers2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido del personal 2:");
                    string apellpers2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el rut del personal 2:");
                    string rutpers2 = Console.ReadLine();
                    Persona personal2 = new Persona(nombrepers2, apellpers2, rutpers2, nombrebloque);
                    Bloque bloque = new Bloque(nombrebloque, personal1, personal2);
                    empresa.AddDivisionbloq(bloque);



                    Save(empresas);






                }
                if (respuesta == "Si" || respuesta == "si" || respuesta == "SI")
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

                        Console.WriteLine("Ingrese el nombre de la empresa:");
                        nombreem = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut de la empresa:");
                        rutem = Console.ReadLine();
                        Empresa empresa = new Empresa(nombreem, rutem);
                        empresas.Add(empresa);
                        Console.WriteLine("Ingrese el nombre del departamento");
                        string nombredep = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del encargado");
                        string nombreenc = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del encargado");
                        string apellenc = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut del encargado");
                        string rutenc = Console.ReadLine();
                        Persona encargadodep = new Persona(nombreenc, apellenc, rutenc, nombredep);
                        Departamento departamento = new Departamento(nombredep, encargadodep);
                        empresa.AddDivisiondep(departamento);;


                        Console.WriteLine("Ingrese el nombre de la seccion 1:");
                        string nombresec1 = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del encargado");
                        string nombrencs = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del encargado:");
                        string apellencs = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut del encargado:");
                        string rutencs = Console.ReadLine();
                        Persona encargadosec = new Persona(nombrencs, apellencs, rutencs, nombresec1);
                        Sección seccion = new Sección(nombredep, encargadosec);
                        empresa.AddDivisionsec(seccion);

                        Console.WriteLine("Ingrese el nombre de la seccion 2:");
                        string nombresec2 = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del encargado:");
                        string nombrencs2 = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del encargado:");
                        string apellencs2 = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut del encargado:");
                        string rutencs2 = Console.ReadLine();
                        Persona encargadosec2 = new Persona(nombrencs2, apellencs2, rutencs2, nombresec2);
                        Sección seccion2 = new Sección(nombresec2, encargadosec2);
                        empresa.AddDivisionsec(seccion2);



                        Console.WriteLine("Ingrese el nombre del Bloque:");
                        string nombrebloque = Console.ReadLine();


                        Console.WriteLine("Ingrese el nombre del personal 1:");
                        string nombrepers1 = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del personal 1:");
                        string apellpers1 = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut del personal 1:");
                        string rutpers1 = Console.ReadLine();
                        Persona personal1 = new Persona(nombrepers1, apellpers1, rutpers1, nombrebloque);
                        Console.WriteLine("Ingrese el nombre del personal 2:");
                        string nombrepers2 = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del personal 2:");
                        string apellpers2 = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut del personal 2:");
                        string rutpers2 = Console.ReadLine();
                        Persona personal2 = new Persona(nombrepers2, apellpers2, rutpers2, nombrebloque);
                        Bloque bloque = new Bloque(nombrebloque, personal1, personal2);
                        empresa.AddDivisionbloq(bloque);



                        Save(empresas);


                    }
                }
                if (respuesta=="Salir")
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
                Console.WriteLine(empresa.ShowDep());
                Console.WriteLine(empresa.ShowSec());
                Console.WriteLine(empresa.ShowBloq());
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
