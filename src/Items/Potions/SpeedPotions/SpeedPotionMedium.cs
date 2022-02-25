//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about medium speed potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.SpeedPotions
{
    //-------------------------------------------------------------------
    // Store information about small speed potions
    //-------------------------------------------------------------------
    public class SpeedPotionMedium : SpeedPotion
    {
        public SpeedPotionMedium()
        {
            speedIncreased = 15;
            itemName = "Medium Speed Potion";
            itemDescription = "A potion that increases your speed by " + speedIncreased;
            itemCost = 10;
        }
    }
}