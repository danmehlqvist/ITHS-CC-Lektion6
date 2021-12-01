using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_slut
{
    public class MethodInjection
    {
        public void DoSomething(IProductDiscount discount)
        {
            // We are doing something important :)
        }
    }

    public static class MethodInjectionExtensions
    {
        // Oj. Vi kan inte instantsiera props i en statisk klass.
        // public IProductDiscount ProductDiscount { get; set; }

        // Vi kan inte ha konstruktorer i statiska klasser.
        // public MethodInjectionExtensions() { }

        // Då är det enda vi kan göra att injekta vid paramatrarna i metoden => Method Injection
        public static string DoSomethingExt(this string indata, IProductDiscount productDiscount)
        {
            return string.Empty;
        }
    }
}
