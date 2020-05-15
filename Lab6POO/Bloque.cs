using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab6POO
{
    [Serializable]
    public class Bloque : Division
    {
        private Persona personal1;
        private Persona personal2;
        public List<Persona> personal = new List<Persona> { };
        private string name;
        public Bloque(string Name, Persona persona1, Persona persona2)
        {
            this.name = Name;
            this.personal1 = persona1;
            this.personal2 = persona2;
        }
        public string Name { get => name; set => name = value; }
        public string NameP1 { get => personal1.Name + " " + personal1.LastName; }
        public string NameP2 { get => personal2.Name + " " + personal2.LastName; }
        public void Addpersonal(Persona persona)
        {
            personal.Add(persona);
        }
    }
}
