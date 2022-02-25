//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about accessories
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Accessories
{
    //-------------------------------------------------------------------    
    // Store information about accessories
    //-------------------------------------------------------------------
    public class Accessory : Item
    {
        protected int speedIncreased;
        public int getSpeedIncreased()
        {
            return speedIncreased;
        }
    }
}
