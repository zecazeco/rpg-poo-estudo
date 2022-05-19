using System;
using rpg_dotnet_zeco.src.Entities;

namespace rpg_dotnet_zeco
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard player01 = new Wizard("Shell", 23, 50, 0);
            Warrior player02 = new Warrior("John", 16, 50, 0);
            Console.WriteLine(player01);
            Console.WriteLine(player02);

            Console.WriteLine(player01.Attack());
            Console.WriteLine(player02.Damage(10));

            Console.WriteLine(player02.Attack());
            Console.WriteLine(player01.Damage(5));  

            Console.WriteLine(player01);
            Console.WriteLine(player02);                      
        }
    }
}
