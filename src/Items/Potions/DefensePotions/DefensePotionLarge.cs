//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about large defense potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.DefensePotions
{
    //-------------------------------------------------------------------
    // Store information about large defense potions
    //-------------------------------------------------------------------
    public class DefensePotionLarge : DefensePotion
    {
        public DefensePotionLarge()
        {
            defenseIncreased = 20;
            itemName = "Large Defense Potion";
            itemDescription = "A potion that increases your defense by " + defenseIncreased;
            itemCost = 15;
        }
    }
}