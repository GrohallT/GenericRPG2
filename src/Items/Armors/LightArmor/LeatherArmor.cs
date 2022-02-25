//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about leather armor
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Armors.LightArmor
{
    //-------------------------------------------------------------------
    // Store information about a leather armor
    //-------------------------------------------------------------------
    public class LeatherArmor : Armor
    {
        public LeatherArmor()
        {
            defenseIncreased = 5;
            itemName = "Leather Armor";
            itemDescription = "A light armor that increases your defense by " + defenseIncreased;
            itemCost = 10;
        }
    }
}
