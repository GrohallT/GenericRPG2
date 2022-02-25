//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about medium defense potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.DefensePotions
{
    //-------------------------------------------------------------------
    // Store information about medium defense potions
    //-------------------------------------------------------------------
    public class DefensePotionMedium : DefensePotion
    {
        public DefensePotionMedium()
        {
            defenseIncreased = 15;
            itemName = "Medium Defense Potion";
            itemDescription = "A potion that increases your defense by " + defenseIncreased;
            itemCost = 10;
        }
    }
}