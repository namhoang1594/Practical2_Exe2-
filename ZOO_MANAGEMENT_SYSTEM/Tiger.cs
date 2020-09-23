using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO_MANAGEMENT_SYSTEM
{
    class Tiger : Animal
    {
        public Tiger(string Name) : base(Name)
        {  

        }
        public Tiger(string Name, int Age) : base(Name,Age)
        {

        }
        public Tiger(string Name, int Age, string Description) :base(Name,Age,Description)
        {

        }
        public override void ViewInfo()
        {
            base.ViewInfo();
        }
        public override void Speak()
        {
            Console.WriteLine("Grrr Grrr");
        }
    }
}
