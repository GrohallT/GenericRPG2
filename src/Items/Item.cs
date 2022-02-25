//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store information common among all items
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Items
{
    //-------------------------------------------------------------------
    // Store information common among all items
    //-------------------------------------------------------------------
    public class Item
    {
        protected String itemName;
        protected String itemDescription;
        protected int itemCost;

        public String getItemName()
        {
            return itemName;
        }

        public String getItemDescription()
        {
            return itemDescription;
        }

        public int getItemCost()
        {
            return itemCost;
        }

        override public String ToString()
        {
            return itemName;
        }

        override public bool Equals(object obj)
        {
            if (obj is Item)
            {
                return this.itemName.Equals(((Item)obj).itemName);
            }
            return base.Equals(obj);
        }
    }
}
