//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about armor
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Armors
{
    //-------------------------------------------------------------------
    // Store information about armor
    //-------------------------------------------------------------------
    public class Armor : Item
    {
        protected int defenseIncreased;
        public int getDefenseIncreased()
        {
            return defenseIncreased;
        }
    }
}
