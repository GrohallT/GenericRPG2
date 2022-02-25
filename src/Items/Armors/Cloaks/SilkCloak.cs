//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about a silk cloak
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Armors.Cloaks
{
    //-------------------------------------------------------------------
    // Store information about a silk cloak
    //-------------------------------------------------------------------
    public class SilkCloak : Armor
    {
        public SilkCloak()
        {
            defenseIncreased = 5;
            itemName = "Silk Cloak";
            itemDescription = "A cloak that increases your defense by " + defenseIncreased;
            itemCost = 10;
        }
    }
}
