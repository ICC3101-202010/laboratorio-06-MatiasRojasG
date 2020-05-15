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

        private string name;
        private string rut;
        public Empresa(string Name, string Rut)
        {
            this.name = Name;
            this.rut = Rut;
        }
        public string Name { get => name; set => name = value; }
        public string Rut { get => rut; set => rut = value; }

        
    }
}
