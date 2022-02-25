//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about large attack potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.AttackPotions
{
    //-------------------------------------------------------------------
    // Store information about large attack potions
    //-------------------------------------------------------------------
    public class AttackPotionLarge : AttackPotion
    {
        public AttackPotionLarge()
        {
            attackIncreased = 20;
            itemName = "Large Attack Potion";
            itemDescription = "A potion that increases your attack by " + attackIncreased;
            itemCost = 15;
        }
    }
}