//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Sets the information about greater HP potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.HealingPotions
{
    //-------------------------------------------------------------------
    // Sets the information about greater HP potions
    //-------------------------------------------------------------------
    public class HpPotionGreater : HealingPotion
    {
        public HpPotionGreater()
        {
            hpRestored = 20;
            itemName = "Greater HP Potion";
            itemDescription = "A potion that heals " + hpRestored + " HP";
            itemCost = 15;
        }
    }
}
