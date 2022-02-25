//---------------------------------------------------------------
// Name:    Marshall Paider
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Manges all of the actions for the Inventory
//---------------------------------------------------------------------

using GenericRPG2.Items;
using GenericRPG2.Items.Accessories;
using GenericRPG2.Items.Armors;
using GenericRPG2.Items.Potions;
using GenericRPG2.Items.Potions.AttackPotions;
using GenericRPG2.Items.Potions.DefensePotions;
using GenericRPG2.Items.Potions.HealingPotions;
using GenericRPG2.Items.Potions.SpeedPotions;
using GenericRPG2.Items.Potions.SpPotions;
using GenericRPG2.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericRPG2.Inventory
{
    public class InventoryManager
    {
        private Dictionary<Item, int> inventory;

        public InventoryManager()
        {
            this.inventory = new Dictionary<Item, int>();
        }

        public InventoryManager(Item item)
        {
            this.inventory = new Dictionary<Item, int>();

            addItem(item);
        }

        public Dictionary<Item, int> getInventory()
        {
            return this.inventory;
        }

        //--------------------------------------------------------
        // Adds a given item, to the iventory
        //--------------------------------------------------------
        public void addItem(Item item)
        {
            bool foundItem = false;
            Item foundKey = item;

            // checks if the incoming item is in the list
            foreach (KeyValuePair<Item, int> entry in inventory)
            {
                if (item.getItemName().Equals(entry.Key.getItemName()))
                {
                    foundKey = entry.Key;
                    foundItem = true;
                }
            }

            if (!foundItem)
                inventory.Add(item, 1);
            else
                inventory[foundKey] += 1;
        }

        //--------------------------------------------------------
        // removes a given item from the inventory
        //--------------------------------------------------------
        public void removeItem(Item item)
        {
            Item removedItem = item;
            bool foundKey = false;
            foreach (KeyValuePair<Item, int> in_item in inventory)
            {
                if (in_item.Key.Equals(item))
                { 
                    removedItem = in_item.Key;
                    foundKey = true;
                }
            }
            if (foundKey && inventory[removedItem] > 1)
                inventory[removedItem]--;
            else if (foundKey && inventory[removedItem] == 1)
                inventory.Remove(removedItem);
        }

        //--------------------------------------------------------
        // Since we are using a dictionary, this finds the entry
        // at a given index, to give linked list list properties
        //--------------------------------------------------------
        public KeyValuePair<Item, int> getEntryAtIndex(int index)
        {
            KeyValuePair<Item, int> output = inventory.FirstOrDefault();
            int i = 0;

            foreach (KeyValuePair<Item, int> entry in inventory)
            {
                if (i <= index)
                    output = entry;
                i++;
            }

            return output;
        }

        //--------------------------------------------------------
        // returns a dictionary of all the equippable items that the 
        // inventory contains
        //--------------------------------------------------------
        public Dictionary<Item, int> getEquipableItems()
        {
            Dictionary<Item, int> equipableItems = new Dictionary<Item, int>();

            foreach(KeyValuePair<Item, int> entry in inventory)
            {
                if (isEquippable(entry.Key))
                    equipableItems.Add(entry.Key, entry.Value);
            }

            return equipableItems;
        }

        //--------------------------------------------------------
        // returns a dictionary of all the potions that the 
        // inventory contains
        //--------------------------------------------------------
        public Dictionary<Item, int> getPotions()
        {
            Dictionary<Item, int> potions = new Dictionary<Item, int>();

            foreach (KeyValuePair<Item, int> entry in inventory)
            {
                if (isPotion(entry.Key))
                    potions.Add(entry.Key, entry.Value);
            }

            return potions;
        }

        //--------------------------------------------------------
        // returns a dictionary of all the accessories that the 
        // inventory contains
        //--------------------------------------------------------
        public Dictionary<Item, int> getAccessories()
        {
            Dictionary<Item, int> accessories = new Dictionary<Item, int>();

            foreach (KeyValuePair<Item, int> entry in inventory)
            {
                if (entry.Key is Accessory)
                    accessories.Add(entry.Key, entry.Value);
            }

            return accessories;
        }

        //--------------------------------------------------------
        // returns a dictionary of all the armor that the 
        // inventory contains
        //--------------------------------------------------------
        public Dictionary<Item, int> getArmor()
        {
            Dictionary<Item, int> armor = new Dictionary<Item, int>();

            foreach (KeyValuePair<Item, int> entry in inventory)
            {
                if (entry.Key is Armor)
                    armor.Add(entry.Key, entry.Value);
            }

            return armor;
        }

        //--------------------------------------------------------
        // returns a dictionary of all the usable items that the 
        // inventory contains
        //--------------------------------------------------------
        public Dictionary<Item, int> getUsableItems()
        {
            Dictionary<Item, int> usableItems = new Dictionary<Item, int>();

            foreach (KeyValuePair<Item, int> entry in inventory)
            {
                if (isUsable(entry.Key))
                    usableItems.Add(entry.Key, entry.Value);
            }

            return usableItems;
        }

        //--------------------------------------------------------
        // checks if a given item is equippable
        //--------------------------------------------------------
        public bool isEquippable(Item item)
        {
            return item is Accessory || item is Armor || item is Weapon;
        }

        //--------------------------------------------------------
        // checks if an item is a potion
        //--------------------------------------------------------
        public bool isPotion(Item item)
        {
            return item is AttackPotion || item is DefensePotion || item is HealingPotion || item is SpeedPotion || item is SpPotion;
        }

        //--------------------------------------------------------
        // checks if a given item is a usable item
        //--------------------------------------------------------
        public bool isUsable(Item item)
        {
            return isPotion(item);
        }
    }
}
