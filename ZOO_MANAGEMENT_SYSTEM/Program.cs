using System;

namespace ZOO_MANAGEMENT_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            int choice;
            Console.WriteLine("ZOO MANAGEMENT SYSTEM");
            Console.WriteLine("1. Add Cage");
            Console.WriteLine("2. Remove Cage");
            Console.WriteLine("3. Add Animal");
            Console.WriteLine("4. Remove Animal");
            Console.WriteLine("5. Iterate Animals");
            Console.WriteLine("6. Exit");
            do
            {
                Console.WriteLine("\nSelect: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Cage:");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Cage cage = new Cage();
                            cage.CageNum();
                            zoo.AddCage(cage);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the Cage want to remove: ");
                        int rmc = int.Parse(Console.ReadLine());
                        zoo.RemoveCage(rmc);
                        break;
                    case 3:
                        for (int i = 0; i < zoo.CageList.Count; i++)
                        {
                            Console.WriteLine("Enter the number of animal at Cage have the number: {0}", zoo.CageList[i].CageNumber);
                            int s = int.Parse(Console.ReadLine());
                            for (int j = 0; j < s; j++)
                            {
                                Console.WriteLine("Enter the animal type: ");
                                Console.WriteLine("1. Tiger");
                                Console.WriteLine("2. Dog");
                                Console.WriteLine("3. Cat");
                                int animal = int.Parse(Console.ReadLine());
                                Animal animal1;
                                Console.WriteLine("You select {0}",animal);
                                Console.WriteLine("Enter name of animal: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter age of animal: ");
                                int age = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter description");
                                string des = Console.ReadLine();
                                switch (animal)
                                {
                                    case 1:
                                        Console.WriteLine("You just have entered information for the Tiger.");
                                       animal1 = new Tiger(name,age,des);
                                        break;
                                    case 2:
                                        Console.WriteLine("You just have entered information for the Dog.");
                                        animal1 = new Dog(name, age, des);
                                        break;
                                    case 3:
                                        Console.WriteLine("You just have entered information for the Cat.");
                                        animal1 = new Cat(name, age, des);
                                        break;
                                    default:
                                        Console.WriteLine("You just have entered information for the Tiger.");
                                        animal1 = new Tiger(name, age, des);
                                        break;
                                }
                                zoo.CageList[i].AddAnimal(animal1);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter the number of Cage want to delete: ");
                        int del = int.Parse(Console.ReadLine());
                        foreach (Cage c in zoo.CageList)
                        {
                            if (c.CageNumber == del)
                            {
                                Console.WriteLine("Enter the name of animal: ");
                                string name = Console.ReadLine();
                                c.RemoveAnimal(name);
                                break;
                            }
                        }
                        break;
                    case 5:
                        foreach (Cage c in zoo.CageList)
                        {
                            Console.WriteLine("List of animal in Cage List:  {0}", c.CageNumber);
                            foreach (Animal animal in c.AnimalList)
                            {                          
                                animal.ViewInfo();
                                animal.Speak();
                            }
                        }
                        break;
                    case 6: return;
                }
            }
            while (choice != 6);
        }
    }
}
