using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Apple : Item, IPackable
    {
        public Apple(string name, int price, int weight ) : base (name, price, weight)
        {
<<<<<<< HEAD
        }
        public override void ModifyPlayer(Character character)
        {
            character.Health += 300;
=======
        Console.WriteLine("Test Console Git");
        }
        public override void ModifyPlayer(Character character)
        {
            character.Health -= 10;
>>>>>>> a974e2362332e9f1eeb607a76aee8add8c0b48e9
        }

    }
}