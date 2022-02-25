//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about attack potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.SpeedPotions
{
    //-------------------------------------------------------------------
    // Store information about attack potions
    //-------------------------------------------------------------------
    public class SpeedPotion : Item
    {
        protected int speedIncreased;

        public int getSpeedIncreased()
        {
            return speedIncreased;
        }
    }
}
