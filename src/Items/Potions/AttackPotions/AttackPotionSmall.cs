//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about small attack potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.AttackPotions
{
    //-------------------------------------------------------------------
    // Store information about small attack potions
    //-------------------------------------------------------------------
    public class AttackPotionSmall : AttackPotion
    {
        public AttackPotionSmall()
        {
            attackIncreased = 10;
            itemName = "Small Attack Potion";
            itemDescription = "A potion that increases your attack by " + attackIncreased;
            itemCost = 5;
        }
    }
}