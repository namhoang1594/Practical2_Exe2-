using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO_MANAGEMENT_SYSTEM
{
    class Cat : Animal
    {
        public Cat(string Name) : base(Name)
        {

        }
        public Cat(string Name, int Age) : base(Name, Age)
        {

        }
        public Cat(string Name, int Age, string Description) : base(Name, Age, Description)
        {

        }
        public override void ViewInfo()
        {
            base.ViewInfo();
        }
        public override void Speak()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
