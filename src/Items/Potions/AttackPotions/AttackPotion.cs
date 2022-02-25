//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about attack potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.AttackPotions
{
    //-------------------------------------------------------------------
    // Store information about attack potions
    //-------------------------------------------------------------------
    public class AttackPotion : Item
    {
        protected int attackIncreased;

        public int getAttackIncreased()
        {
            return attackIncreased;
        }
    }
}
