using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_start
{
    public interface IAnimal
    {
        string Name { get; set; }

        void Walk();

        void Jump();

        void Swim();
    }
}
