using System;

namespace OpenLab_02._6
{
    class Program
    {
        public static bool delitelne(int x)
        {
            if (x % 100 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj číslo, ktoré chceš aby ti napísalo či je delitelné 100 ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(delitelne(x));
        }
    }
}
