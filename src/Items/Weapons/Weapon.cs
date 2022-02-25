//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about weapons
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Weapons
{
    //-------------------------------------------------------------------
    // Store information about weapons
    //-------------------------------------------------------------------
    public class Weapon : Item
    {
        protected int attackIncreased;
        public int getAttackIncreased()
        {
            return attackIncreased;
        }
    }
}
