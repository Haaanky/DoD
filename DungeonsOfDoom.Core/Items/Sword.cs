using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Items
{
    public class Sword : Weapon, IPackable
    {
        public Sword(string name, int price, int weight) : base(name, price, weight)
        {
        }
        
        public override void ModifyPlayer(Character character)
        {
            character.Strength += 25;
        }
    }
}
