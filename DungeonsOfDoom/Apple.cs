using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Apple : Item, IPackable
    {
        public Apple(string name, int price, int weight ) : base (name, price, weight)
        {
        Console.WriteLine("Test Console Git");
        }
        public override void ModifyPlayer(Character character)
        {
            character.Health -= 10;
        }
    }
}