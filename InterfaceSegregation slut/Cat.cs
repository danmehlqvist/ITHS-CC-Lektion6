using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_slut
{
    public class Cat : IAnimal, IJumpableAnimal, ISwimmableAnimal, IWalkableAnimal
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void Jump()
        {
            Console.WriteLine($"The cat with name {Name} jumps!");
        }

        public void Swim()
        {
            Console.WriteLine($"The cat with name {Name} swims!");
        }

        public void Walk()
        {
            Console.WriteLine($"The cat with name {Name} walks!");
        }
    }
}
