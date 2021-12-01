using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_start
{
    public class JellyFish:IAnimal
    {
        public string Name { get; set; }

        public JellyFish(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void Jump()
        {
            throw new NotSupportedException("Jellyfish cannot jump");
        }

        public void Swim()
        {
            Console.WriteLine($"The jellyfish with name {Name} swims!");
        }

        public void Walk()
        {
            throw new NotSupportedException("Jellyfish cannot walk");
        }
    }
}
