using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new ReadFileD();
            if (demo.LoadFile())
                if (demo.ValidateFile())
                    if (demo.ProcessFile())
                        Console.WriteLine("Se proceso el archivo con exito");

            Console.ReadKey();
        }
    }
}
