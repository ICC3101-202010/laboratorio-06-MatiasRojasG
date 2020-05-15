using System;
namespace Lab6POO
{
    public class Sección : Division
    {
        private string name;
        public Sección(string Name)
        {
            this.name = Name;
        }
        public string Name { get => name; set => name = value; }
    }
}
