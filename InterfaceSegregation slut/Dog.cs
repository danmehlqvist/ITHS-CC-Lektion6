using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_slut
{
    public class Dog : IAnimal, IJumpableAnimal, ISwimmableAnimal, IWalkableAnimal
    {
        public string Name { get;set; }

        public Dog(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void Jump()
        {
            Console.WriteLine($"The dog with name {Name} jumps!");
        }

        public void Swim()
        {
            Console.WriteLine($"The dog with name {Name} swims!");
        }

        public void Walk()
        {
            Console.WriteLine($"The dog with name {Name} walks!");
        }
    }
}
