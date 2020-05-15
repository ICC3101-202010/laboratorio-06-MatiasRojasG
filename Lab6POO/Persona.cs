using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab6POO
{
    [Serializable]
    public class Persona
    {
        private string name;
        private string lastname;
        private string rut;
        private string cargo;
        public Persona(string Name, string Lastname, string Rut, string Cargo)
        {
            this.name = Name;
            this.lastname = Lastname;
            this.rut = Rut;
            this.cargo = Cargo;
        }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastname; set => lastname = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
