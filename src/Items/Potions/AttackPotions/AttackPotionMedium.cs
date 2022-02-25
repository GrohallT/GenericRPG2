//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about medium attack potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.AttackPotions
{
    //-------------------------------------------------------------------
    // Store information about medium attack potions
    //-------------------------------------------------------------------
    public class AttackPotionMedium : AttackPotion
    {
        public AttackPotionMedium()
        {
            attackIncreased = 15;
            itemName = "Medium Attack Potion";
            itemDescription = "A potion that increases your attack by " + attackIncreased;
            itemCost = 10;
        }
    }
}