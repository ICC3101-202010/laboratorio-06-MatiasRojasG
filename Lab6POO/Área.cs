using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab6POO
{
    [Serializable]
    public class Área : Division
    {
        public List<Persona> encargado = new List<Persona> { };
        private string name;
        public Área(string Name)
        {
            this.name = Name;
        }
        public string Name { get => name; set => name = value; }
    }
}
