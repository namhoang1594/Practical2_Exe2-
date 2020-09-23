using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO_MANAGEMENT_SYSTEM
{
    class Animal
    {
        public string Name;
        public int Age;
        public string Description;
        public Animal()
        {

        }
        public Animal(string Name)
        {
            this.Name = Name;
        }
        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public Animal(string Name, int Age, string Description)
        {
            this.Name = Name;
            this.Age = Age;
            this.Description = Description;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int Age)
        {
            this.Age = Age;
        }
        public string GetDescription()
        {
            return Description;
        }
        public void SetDescription(string Description)
        {
            this.Description = Description;
        }
        public virtual void ViewInfo()
        {
            Console.WriteLine("Name = " + GetName() + ", Age = " + GetAge() + ", Description = " + GetDescription());
        }
        public virtual void Speak()
        {

        }
    }
}
