using System;
namespace Lab6POO
{
    public class Bloque : Division
    {
        private string name;
        public Bloque(string Name)
        {
            this.name = Name;
        }
        public string Name { get => name; set => name = value; }
    }
}
