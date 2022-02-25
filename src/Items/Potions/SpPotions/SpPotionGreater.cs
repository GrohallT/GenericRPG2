//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Sets the information about greater SP potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.SpPotions
{
    //-------------------------------------------------------------------
    // Sets the information about greater SP potions
    //-------------------------------------------------------------------
    public class SpPotionGreater : SpPotion
    {
        public SpPotionGreater()
        {
            spRestored = 20;
            itemName = "Greater SP Potion";
            itemDescription = "A potion that restores " + spRestored + " SP";
            itemCost = 15;
        }
    }
}
