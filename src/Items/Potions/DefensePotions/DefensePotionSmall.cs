//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about small defense potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.DefensePotions
{
    //-------------------------------------------------------------------
    // Store information about small defense potions
    //-------------------------------------------------------------------
    public class DefensePotionSmall : DefensePotion
    {
        public DefensePotionSmall()
        {
            defenseIncreased = 10;
            itemName = "Small Defense Potion";
            itemDescription = "A potion that increases your defense by " + defenseIncreased;
            itemCost = 5;
        }
    }
}