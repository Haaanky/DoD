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

=======
>>>>>>> a419211fba7f217598608e2ea12e177942a5d499
        }
        public override void ModifyPlayer(Character character)
        {
            character.Health += 10;
<<<<<<< HEAD
=======
            character.Damage += 50;
            
>>>>>>> a419211fba7f217598608e2ea12e177942a5d499
        }
        public override void ModifyPlayer(Character character)
        {
            character.Health -= 10;
        }

    }
}
