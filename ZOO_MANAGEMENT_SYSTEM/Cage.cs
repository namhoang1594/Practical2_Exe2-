using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZOO_MANAGEMENT_SYSTEM
{
    class Cage
    {
        public int CageNumber { get; set; }
        public List<Animal> AnimalList { get; set; }
        public Cage()
        {
            AnimalList = new List<Animal>();
        }
        public void AddAnimal(Animal a)
        {
            AnimalList.Add(a);
        }
        public void RemoveAnimal(string Name)
        {
            for(int i = 0; i<AnimalList.Count;i++)
            {
                if(AnimalList[i].Name.Equals(Name))
                {
                    AnimalList.RemoveAt(i);
                }
            }
        }
        public void CageNum()
        {
            Console.WriteLine("Enter Cage number: ");
            CageNumber = int.Parse(Console.ReadLine());
        }
    }
}
