using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myreflexion
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass hero = new MyClass();
            hero.Age = 22;
            hero.Name = "Elnar";
            Type type = typeof(MyClass);
            foreach (var property in type.GetProperties()) {
                Console.WriteLine(property.ToString()+" "+property.GetValue(hero));
            }
            Console.ReadLine();
        }
    }
}
