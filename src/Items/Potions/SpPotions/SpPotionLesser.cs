//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Sets the information about lesser HP potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.SpPotions
{
    //-------------------------------------------------------------------
    // Sets the information about lesser HP potions
    //-------------------------------------------------------------------
    public class SpPotionLesser : SpPotion
    {
        public SpPotionLesser()
        {
            spRestored = 10;
            itemName = "Lesser SP Potion";
            itemDescription = "A potion that restores " + spRestored + " SP";
            itemCost = 5;
        }
    }
}
