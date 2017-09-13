using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks;

namespace Labushka1 {
    class Program {
        static void Main(string[] args) {
            int[] arr = new int[] { 6, 13, 18, 5, 22, 9, 8, 18, 7, 2 };
            Console.WriteLine(SwitcherCl.Switcher(arr));
            Console.WriteLine(PrimeNumer.isPrime(-4));
            Console.ReadKey();
        }
    }
}
