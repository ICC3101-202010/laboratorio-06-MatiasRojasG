using System;
namespace Lab6POO
{
    public class Departamento : Division
    {
        private string name;
        public Departamento(string Name)
        {
            this.name = Name;
        }
        public string Name { get => name; set => name = value; }
    }
}
