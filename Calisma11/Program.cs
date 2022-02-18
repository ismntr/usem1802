using System;
using System.Threading;
using Usem.OrnekSiniflar;

namespace Usem.Ana
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = new Kisi("Ali");
            k.IdProp = -1;
            Console.WriteLine(k.IdProp);
        }
    }
}
