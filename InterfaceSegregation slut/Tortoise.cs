using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_slut
{
    public class Tortoise : IAnimal, IWalkableAnimal
    {
        public string Name { get; set; }

        public Tortoise(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void Walk()
        {
            Console.WriteLine($"The tortiose with name {Name} walks!");
        }

    }
}
