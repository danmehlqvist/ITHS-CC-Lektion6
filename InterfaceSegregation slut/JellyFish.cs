using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_slut
{
    public class JellyFish:IAnimal, ISwimmableAnimal
    {
        public string Name { get; set; }

        public JellyFish(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
       
        public void Swim()
        {
            Console.WriteLine($"The jellyfish with name {Name} swims!");
        }
    }
}
