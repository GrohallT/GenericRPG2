//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about HP potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.HealingPotions
{
    //-------------------------------------------------------------------
    // Store information about HP potions
    //-------------------------------------------------------------------
    public class HealingPotion : Item
    {
        protected int hpRestored;

        public int getHpRestored()
        {
            return hpRestored;
        }
    }
}
