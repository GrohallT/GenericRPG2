//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Sets the information about medium HP potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.SpPotions
{
    //-------------------------------------------------------------------
    // Sets the information about medium HP potions
    //-------------------------------------------------------------------
    public class SpPotionMedium : SpPotion
    {
        public SpPotionMedium()
        {
            spRestored = 15;
            itemName = "Medium SP Potion";
            itemDescription = "A potion that restores " + spRestored + " SP";
            itemCost = 10;
        }
    }
}
