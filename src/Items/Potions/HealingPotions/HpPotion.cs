//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Sets the information about medium tier HP potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.HealingPotions
{
    //-------------------------------------------------------------------
    // Sets the information about medium tier HP potions
    //-------------------------------------------------------------------
    public class HpPotion : HealingPotion
    {
        public HpPotion()
        {
            hpRestored = 15;
            itemName = "HP Potion";
            itemDescription = "A potion that heals " + hpRestored + " HP";
            itemCost = 10;
        }
    }
}
