//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about iron plate armor
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Armors.HeavyArmor
{
    //-------------------------------------------------------------------
    // Store information about iron plate armor
    //-------------------------------------------------------------------
    public class IronPlate : Armor
    {
        public IronPlate()
        {
            defenseIncreased = 5;
            itemName = "Iron Plate Armor";
            itemDescription = "A heavy armor that increases your defense by " + defenseIncreased;
            itemCost = 10;
        }
    }
}
