using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_start
{
    public class Tortoise : IAnimal
    {
        public string Name { get; set; }

        public Tortoise(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void Jump()
        {
            throw new NotSupportedException("Tortoises cannot jump");
        }

        public void Walk()
        {
            Console.WriteLine($"The tortiose with name {Name} walks!");
        }

        public void Swim()
        {
            // Tortoises är landsköldpaddor och sjunker som stenar. Turtles trivs dock bra i haven.
            throw new NotSupportedException("Tortoises cannot swim.");
        }


    }
}
