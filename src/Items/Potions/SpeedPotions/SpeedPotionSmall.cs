//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about small speed potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.SpeedPotions
{
    //-------------------------------------------------------------------
    // Store information about small speed potions
    //-------------------------------------------------------------------
    public class SpeedPotionSmall : SpeedPotion
    {
        public SpeedPotionSmall()
        {
            speedIncreased = 10;
            itemName = "Small Speed Potion";
            itemDescription = "A potion that increases your speed by " + speedIncreased;
            itemCost = 5;
        }
    }
}