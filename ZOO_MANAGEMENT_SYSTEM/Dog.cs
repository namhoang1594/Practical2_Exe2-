using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO_MANAGEMENT_SYSTEM
{
    class Dog : Animal
    {
        public Dog(string Name) : base(Name)
        {

        }
        public Dog(string Name, int Age) : base(Name, Age)
        {

        }
        public Dog(string Name, int Age, string Description) : base(Name, Age, Description)
        {

        }
        public override void ViewInfo()
        {
            base.ViewInfo();
        }
        public override void Speak()
        {
            Console.WriteLine("Gau Gau");
        }
    }
}
