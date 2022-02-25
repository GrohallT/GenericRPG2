//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about a wooden staff
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Weapons.Staffs
{
    //-------------------------------------------------------------------
    // Store information about a wooden staff
    //-------------------------------------------------------------------
    public class WoodStaff : Weapon
    {
        public WoodStaff()
        {
            attackIncreased = 5;
            itemName = "Wooden Staff";
            itemDescription = "A staff that increases your attack by " + attackIncreased;
            itemCost = 10;
        }
    }
}
