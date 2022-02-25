//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Sets the information about lesser HP potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.HealingPotions
{
    //-------------------------------------------------------------------
    // Sets the information about lesser HP potions
    //-------------------------------------------------------------------
    public class HpPotionLesser : HealingPotion
    {
        public HpPotionLesser()
        {
            hpRestored = 10;
            itemName = "Lesser HP Potion";
            itemDescription = "A potion that heals " + hpRestored + " HP";
            itemCost = 5;
        }
    }
}
