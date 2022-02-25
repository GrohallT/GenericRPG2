//---------------------------------------------------------------
// Name: Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Code to store a specific shop's data
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using GenericRPG2.Items.Potions;
using GenericRPG2.Items.Accessories.Amulets;
using GenericRPG2.Items.Accessories.Rings;

using GenericRPG2.Items.Weapons.Swords;
using GenericRPG2.Items.Weapons.Staffs;
using GenericRPG2.Items.Weapons.Daggers;
using GenericRPG2.Items.Weapons.Bows;

using GenericRPG2.Items.Armors.HeavyArmor;
using GenericRPG2.Items.Armors.LightArmor;
using GenericRPG2.Items.Armors.Cloaks;
using GenericRPG2.Items.Armors.Robes;
using GenericRPG2.Items;
using GenericRPG2.Items.Potions.HealingPotions;

namespace GenericRPG2.UI.Shop
{
    //---------------------------------------------------------------
    // Contains the shop data
    //---------------------------------------------------------------
    public class TestShop : ShopData
    {

        //adds the items in the shop's inventory in the constructor
        public TestShop()
        {
            shopInventory = new LinkedList<Item>();
            shopInventory.AddLast(new HpPotionLesser());
            shopInventory.AddLast(new HpPotionGreater());

            shopInventory.AddLast(new Longbow());
            shopInventory.AddLast(new CopperDagger());
            shopInventory.AddLast(new WoodStaff());
            shopInventory.AddLast(new Longsword());

            shopInventory.AddLast(new SilkCloak());
            shopInventory.AddLast(new IronPlate());
            shopInventory.AddLast(new LeatherArmor());
            shopInventory.AddLast(new CottonRobe());

            shopInventory.AddLast(new CopperAmulet());
            shopInventory.AddLast(new SilverRing());
        }
    }
}
