//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about SP potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.SpPotions
{
    //-------------------------------------------------------------------
    // Store information about SP potions
    //-------------------------------------------------------------------
    public class SpPotion : Item
    {
        protected int spRestored;

        public int getSpRestored()
        {
            return spRestored;
        }
    }
}
