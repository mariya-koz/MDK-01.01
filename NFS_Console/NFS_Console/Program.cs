using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFS_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.SetModel("Lada");
            c1.SetSpeed(150);
            Console.WriteLine(c1.GetModel());

            Car c2 = new Car();
            c2.SetModel("Mercedes");
            c2.SetSpeed(300);

            WriteModel(c1);
            WriteModel(c2);

            List<Car> cars = new List<Car>();
            cars.Add(c1);
            cars.Add(c2);
        }

        static void WriteModel(Car mod)
        {
            Console.WriteLine(mod.GetModel());
        }
    }
}
