using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab6POO
{
    [Serializable]
    public class Empresa
    {
        List<Division> divisions = new List<Division> { };
        List<Departamento> depl = new List<Departamento> { };
        List<Sección> secl = new List<Sección> { };
        List<Bloque> bloql = new List<Bloque> { };


        List<Persona> personal = new List<Persona> { };
        private string name;
        private string rut;
        public Empresa(string Name, string Rut)
        {
            this.name = Name;
            this.rut = Rut;
        }
        public string Name { get => name; set => name = value; }
        public string Rut { get => rut; set => rut = value; }


        public string ShowDep()
        {
            foreach (Departamento dep in depl)
            {
                return "Nombre departamento: " + dep.Name + " Nombre encargado: " + dep.NameEnc;
            }
            return "";
        }
        public string ShowSec()
        {
            foreach (Sección sec in secl)
            {
                return "Nombre sección: " + sec.Name + " Nombre encargado: " + sec.NameEnc;
            }
            return "";
        }
        public string ShowBloq()
        {
            foreach (Bloque bloq in bloql)
            {
                return "Nombre bloque: " + bloq.Name + " Nombre personal1: " + bloq.NameP1+" Nombre personal2: "+bloq.NameP2;
            }
            return "";
        }
        public void AddDivisiondep(Departamento departamento)
        {
            depl.Add(departamento);
        }
        public void AddDivisionsec(Sección seccion)
        {
            secl.Add(seccion);
        }
        public void AddDivisionbloq(Bloque bloque)
        {
            bloql.Add(bloque);
        }
    }
}
