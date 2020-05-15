using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab6POO
{
    [Serializable]
    public class Departamento : Division
    {
        private string name;
        private Persona encargado;
        public Departamento(string Name, Persona Encargado)
        {
            this.name = Name;
            this.encargado = Encargado;
        }
        public string Name { get => name; set => name = value; }
        public string NameEnc { get => encargado.Name + " " + encargado.LastName; }
    }
}
