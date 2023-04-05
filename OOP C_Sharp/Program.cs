using System;

namespace OOP_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player human = new Player
            {
                Name="Hulk",
                Damage=50,
                Health=200
            };
            human.PlayerNew();
            Console.WriteLine("=================");
            Enemy goblin = new Enemy
            {
                Name = "Goblin",
                Damage =34,
                Health=100
            };

            goblin.PlayerNew();
        }

    }

abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public void Attack()
        {

        }
        public void UseItem()
        {

        }
        public abstract void PlayerNew();
    }
}
