//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about attack potions
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Potions.DefensePotions
{
    //-------------------------------------------------------------------
    // Store information about attack potions
    //-------------------------------------------------------------------
    public class DefensePotion : Item
    {
        protected int defenseIncreased;

        public int getDefenseIncreased()
        {
            return defenseIncreased;
        }
    }
}
