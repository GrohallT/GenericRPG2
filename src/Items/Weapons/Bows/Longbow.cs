//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about a longbow
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Weapons.Bows
{
    //-------------------------------------------------------------------
    // Store information about a longbow
    //-------------------------------------------------------------------
    public class Longbow : Weapon
    {
        public Longbow()
        {
            attackIncreased = 5;
            itemName = "Longbow";
            itemDescription = "A bow that increases your attack by " + attackIncreased;
            itemCost = 10;
        }
    }
}
