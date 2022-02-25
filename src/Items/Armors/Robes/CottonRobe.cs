//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about a cotton robe
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Armors.Robes
{
    //-------------------------------------------------------------------
    // Store information about a cotton robe
    //-------------------------------------------------------------------
    public class CottonRobe : Armor
    {
        public CottonRobe()
        {
            defenseIncreased = 5;
            itemName = "Cotton Robe";
            itemDescription = "A robe that increases your defense by " + defenseIncreased;
            itemCost = 10;
        }
    }
}
