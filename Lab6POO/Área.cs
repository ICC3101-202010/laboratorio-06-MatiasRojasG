using System;
namespace Lab6POO
{
    public class Área : Division
    {
        private string name;
        public Área(string Name)
        {
            this.name = Name;
        }
        public string Name { get => name; set => name = value; }
    }
}
