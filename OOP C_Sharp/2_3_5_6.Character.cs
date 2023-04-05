using System;

namespace OOP_C_Sharp
{

    class Player : Character
    {
        public override void PlayerNew()
        {
            Console.WriteLine($"Name:{Name}\n" +
                              $"Health:{Health}\n" +
                              $"Damage:{Damage}");
        }
    }

    class Enemy : Character
    {    
        public override void PlayerNew() 
        {
            Console.WriteLine($"Name:{Name}\n" +
                  $"Health:{Health}\n" +
                  $"Damage:{Damage}");
        }
    }



}
