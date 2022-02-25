//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about a longsword
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Weapons.Swords
{
    //-------------------------------------------------------------------
    // Store information about a longsword
    //-------------------------------------------------------------------
    public class Longsword : Weapon
    {
        public Longsword()
        {
            attackIncreased = 5;
            itemName = "Longsword";
            itemDescription = "A sword that increases your attack by " + attackIncreased;
            itemCost = 10;
        }
    }
}
