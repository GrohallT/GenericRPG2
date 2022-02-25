//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information about a copper amulet
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items.Accessories.Amulets
{
    //-------------------------------------------------------------------
    // Store information about a copper amulet
    //-------------------------------------------------------------------
    public class CopperAmulet : Accessory
    {
        public CopperAmulet()
        {
            speedIncreased = 5;
            itemName = "Copper Amulet";
            itemDescription = "An amulet that increases your speed by " + speedIncreased;
            itemCost = 10;
        }
    }
}
