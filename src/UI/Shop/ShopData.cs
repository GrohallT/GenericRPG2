//---------------------------------------------------------------
// Name: Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Code to store the shop data
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using GenericRPG2.Items;

namespace GenericRPG2.UI.Shop
{
   //---------------------------------------------------------------
   // Contains the shop data
   //---------------------------------------------------------------
   public class ShopData
   {
      protected LinkedList<Item> shopInventory;
      protected int inventoryLocation;

      public ShopData()
      {
         inventoryLocation = 0;
      }

      public LinkedList<Item> getShopInventory()
      {
         return this.shopInventory;
      }

      public int getInvLocation()
      {
         return this.inventoryLocation;
      }

      public void setInvLocation(int location)
      {
         this.inventoryLocation = location;
      }
   }
}
