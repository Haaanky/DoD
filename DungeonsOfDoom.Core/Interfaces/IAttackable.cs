using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public interface IAttackable
    {
        int Health { get; set; }
        int Strength { get; set; }

    }
}
