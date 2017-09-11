using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Console);
            foreach (var methods in myType.GetMethods()) {
                Console.WriteLine(methods);
            }
            
            Console.ReadLine();
        }
    }
}
