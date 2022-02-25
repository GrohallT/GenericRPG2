//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about a silver ring
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Accessories.Rings
{
    //-------------------------------------------------------------------
    // Store information about a silver ring
    //-------------------------------------------------------------------
    public class SilverRing : Accessory
    {
        public SilverRing()
        {
            speedIncreased = 5;
            itemName = "Silver Ring";
            itemDescription = "A ring that increases your speed by " + speedIncreased;
            itemCost = 10;
        }
    }
}
