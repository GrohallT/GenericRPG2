//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about a copper dagger
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Weapons.Daggers
{
    //-------------------------------------------------------------------
    // Store information about a copper dagger
    //-------------------------------------------------------------------
    public class CopperDagger : Weapon
    {
        public CopperDagger()
        {
            attackIncreased = 5;
            itemName = "Copper Dagger";
            itemDescription = "A dagger that increases your attack by " + attackIncreased;
            itemCost = 10;
        }
    }
}
