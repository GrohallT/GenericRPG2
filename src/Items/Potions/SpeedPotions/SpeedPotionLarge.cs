//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about large speed potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.SpeedPotions
{
    //-------------------------------------------------------------------
    // Store information about large speed potions
    //-------------------------------------------------------------------
    public class SpeedPotionLarge : SpeedPotion
    {
        public SpeedPotionLarge()
        {
            speedIncreased = 20;
            itemName = "Large Speed Potion";
            itemDescription = "A potion that increases your speed by " + speedIncreased;
            itemCost = 15;
        }
    }
}