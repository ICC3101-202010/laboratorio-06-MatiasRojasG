using System;
namespace Lab6POO
{
    public class Division
    {
        private string name;
        public Division(string Name)
        {
            this.name = Name;
        }
        public string Name { get => name; set => name = value; }
    }
}
