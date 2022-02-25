//---------------------------------------------------------------------
// Name:    Marshall Paider
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Runs the logic of the Player Class
//---------------------------------------------------------------------

using GenericRPG2.CharacterClass;
using GenericRPG2.Items;
using GenericRPG2.Items.Accessories;
using GenericRPG2.Items.Armors;
using GenericRPG2.Items.Armors.Cloaks;
using GenericRPG2.Items.Armors.HeavyArmor;
using GenericRPG2.Items.Armors.LightArmor;
using GenericRPG2.Items.Armors.Robes;
using GenericRPG2.Items.Potions.AttackPotions;
using GenericRPG2.Items.Potions.DefensePotions;
using GenericRPG2.Items.Potions.HealingPotions;
using GenericRPG2.Items.Potions.SpeedPotions;
using GenericRPG2.Items.Potions.SpPotions;
using GenericRPG2.Items.Weapons;
using GenericRPG2.Items.Weapons.Bows;
using GenericRPG2.Items.Weapons.Daggers;
using GenericRPG2.Items.Weapons.Staffs;
using GenericRPG2.Items.Weapons.Swords;
using GenericRPG2.Stats;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GenericRPG2.Players
{
    public class PlayerManager
    {
        private Player player;

        public Player getPlayer()
        {
            return this.player;
        }

        public PlayerManager(CharacterClassEnum characterClass)
        {
            player = new Player(characterClass);
        }

        //------------------------------------------------------------------
        // This method updates the picture to be displayed depending on
        // the last direction the player went
        //------------------------------------------------------------------
        public void updateDirection(DirectionsEnum lastDirection)
        {
            if (lastDirection == DirectionsEnum.DOWN)
                player.setPlayerSprite(Properties.Resources.MainCharacter_Front);
            else if (lastDirection == DirectionsEnum.UP)
                player.setPlayerSprite(Properties.Resources.MainCharacter_Back);
            else if (lastDirection == DirectionsEnum.LEFT)
                player.setPlayerSprite(Properties.Resources.MainCharacter_Left);
            else if (lastDirection == DirectionsEnum.RIGHT)
                player.setPlayerSprite(Properties.Resources.MainCharacter_Right);

            player.setLastDirection(lastDirection);
        }

        //------------------------------------------------------------------
        // A function to equip a given item to the player
        //------------------------------------------------------------------
        public void equipItem(Item item)
        {
            // check if it can be equipped given the class
            if (isEquippable(item) && canEquip(item))
            {
                increaseStats(item);
                player.getEquippedItems().AddLast(item);
            }
        }

        //-------------------------------------------------------------------
        // A function to unequip a given item from the player
        //-------------------------------------------------------------------
        public void unequipItem(Item item)
        {
            if (player.getEquippedItems().Contains(item))
            {
                player.getEquippedItems().Remove(item);
                decreaseStats(item);
            }
        }

        //-------------------------------------------------------------------
        // checks if a given item is equippable
        //-------------------------------------------------------------------
        public bool isEquippable(Item item)
        {
            return item is Accessory || item is Armor || item is Items.Weapons.Weapon;
        }

        //-------------------------------------------------------------------
        // checks if a given item is usable
        //-------------------------------------------------------------------
        public bool isUsable(Item item)
        {
            return !(item is Accessory || item is Armor || item is Items.Weapons.Weapon);
        }

        //-------------------------------------------------------------------
        // applies the stats of a usable item to the player
        //-------------------------------------------------------------------
        public void useItem(Item item)
        {
            if (isUsable(item))
            {
                increaseStats(item);
                //player.getInventoryManager().getInventory()[item] -= 1;
                player.getInventoryManager().removeItem(item);
            }
        }


        //-------------------------------------------------------------------
        // checks if a player should or should not be able to use an item
        // based on if the item used would boost the player's stats past a
        // maximum value
        //-------------------------------------------------------------------
        public bool shouldUse(Item item)
        {
            bool output = isUsable(item);

            if (output)
            {
                if (item is HealingPotion && player.getPlayerStats().getCurrentHp() == player.getPlayerStats().getMaxHp())
                {
                    output = false;
                }
                else if (item is SpPotion && player.getPlayerStats().getCurrentSp() == player.getPlayerStats().getMaxSp())
                {
                    output = false;
                }
            }

            return output;
        }


        //--------------------------------------------------------------
        // This method adds a set amount of experience to the player and
        // levels the player up as many times as necessary.
        //--------------------------------------------------------------
        public void addExperience(int experience, Control control)
        {
            PlayerStats stats = (PlayerStats)player.getPlayerStats();

            stats.addExperience(experience);

            if (control != null)
                control.Text += $"\nYou gained {experience} experience.";

            while (stats.getExpToNextLevel() <= 0)
            {
                stats.addLevel(1);

                if (control != null)
                    control.Text += $"\nYou leveled up to level {stats.getLevel()}!";

            }

        }

        //--------------------------------------------------------------------
        // increases the stats of the player based on the item being used
        //--------------------------------------------------------------------
        public void increaseStats(Item item)
        {
            if (item is Weapon && canEquip(item))
                this.player.getPlayerStats().addAttack(((Weapon)item).getAttackIncreased());

            else if (item is Armor && canEquip(item))
                this.player.getPlayerStats().addDefense(((Armor)item).getDefenseIncreased());

            else if (item is Accessory && canEquip(item))
                this.player.getPlayerStats().addSpeed(((Accessory)item).getSpeedIncreased());

            else if (item is AttackPotion)
                this.player.getPlayerStats().addAttack(((AttackPotion)item).getAttackIncreased());

            else if (item is DefensePotion)
                this.player.getPlayerStats().addDefense(((DefensePotion)item).getDefenseIncreased());

            else if (item is HealingPotion && shouldUse(item))
                this.player.getPlayerStats().addHp(((HealingPotion)item).getHpRestored());

            else if (item is SpeedPotion)
                this.player.getPlayerStats().addSpeed(((SpeedPotion)item).getSpeedIncreased());

            else if (item is SpPotion && shouldUse(item))
                this.player.getPlayerStats().addSp(((SpPotion)item).getSpRestored());
        }

        //--------------------------------------------------------------------
        // decreases the stats if the player unequips an item
        //--------------------------------------------------------------------
        public void decreaseStats(Item item)
        {
            // get the new stats or the boost amount
            if (item is Weapon && canEquip(item))
                this.player.getPlayerStats().subtractAttack(((Weapon)item).getAttackIncreased());

            else if (item is Armor && canEquip(item))
                this.player.getPlayerStats().subtractDefense(((Armor)item).getDefenseIncreased());

            else if (item is Accessory && canEquip(item))
                this.player.getPlayerStats().subtractSpeed(((Accessory)item).getSpeedIncreased());

            else if (item is AttackPotion)
                this.player.getPlayerStats().subtractAttack(((AttackPotion)item).getAttackIncreased());

            else if (item is DefensePotion)
                this.player.getPlayerStats().subtractDefense(((DefensePotion)item).getDefenseIncreased());

            else if (item is HealingPotion)
                this.player.getPlayerStats().subtractHp(((HealingPotion)item).getHpRestored());

            else if (item is SpeedPotion)
                this.player.getPlayerStats().subtractSpeed(((SpeedPotion)item).getSpeedIncreased());

            else if (item is SpPotion)
                this.player.getPlayerStats().subtractSp(((SpPotion)item).getSpRestored());
        }

        //--------------------------------------------------------------------
        // adds the item to the inventory of the player
        //--------------------------------------------------------------------
        public void addItemToInventory(Item item)
        {
            this.player.getInventoryManager().addItem(item);
        }

        //--------------------------------------------------------------------
        // checks if the item can be can be equiped to the player
        //--------------------------------------------------------------------
        public bool canEquip(Item item)
        {
            // Longbow and LeatherArmor can be equipped to Archer
            // CopperDagger and SilkCloak can be equipped to Thief
            // WoodStaff and CottonRobe can be equipped to Mage
            // Longsword and IronPlate can be equipped to Knight

            return ((item is Longbow || item is LeatherArmor) &&
                this.getPlayer().getCharacterClass().Equals(CharacterClassEnum.ARCHER)) ||
                ((item is CopperDagger || item is SilkCloak) &&
                this.getPlayer().getCharacterClass().Equals(CharacterClassEnum.THIEF)) ||
                ((item is WoodStaff || item is CottonRobe) &&
                this.getPlayer().getCharacterClass().Equals(CharacterClassEnum.MAGE)) ||
                ((item is Longsword || item is IronPlate) &&
                this.getPlayer().getCharacterClass().Equals(CharacterClassEnum.KNIGHT)) ||
                item is Accessory;
        }

        //--------------------------------------------------------------------
        // checks if the type of the item has already been equipped to the
        // player (IE: an accessory is already equipped)
        //--------------------------------------------------------------------
        public bool isItemTypeEquipped(Item item)
        {
            bool output = false;

            foreach (Item equippedItem in player.getEquippedItems())
            {
                if (item is Accessory && equippedItem is Accessory)
                    output = true;
            }
            return output;
        }

        //--------------------------------------------------------------------
        // gets the Weapon that is equipped to the player
        //--------------------------------------------------------------------
        public Weapon getEquippedWeapon()
        {
            Weapon output = new Weapon();
            foreach (Item item in player.getEquippedItems())
            {
                if (item is Weapon)
                    output = (Weapon)item;
            }

            return output;
        }

        //--------------------------------------------------------------------
        // checks if a weapon is equipped to the player
        //--------------------------------------------------------------------
        public bool isWeaponEquipped()
        {
            bool output = false;
            foreach (Item item in player.getEquippedItems())
            {
                if (item is Weapon)
                    output = true;
            }

            return output;
        }

        //--------------------------------------------------------------------
        // checks if a given item is equipped to a player
        //--------------------------------------------------------------------
        public bool isEquipped(Item incomingItem)
        {
            bool output = false;
            foreach (Item item in player.getEquippedItems())
            {
                if (item.getItemName().Equals(incomingItem.getItemName()))
                    output = true;
            }
            return output;
        }

        //--------------------------------------------------------------------
        // gets the Armor that is equipped to the player
        //--------------------------------------------------------------------
        public Armor getEquippedArmor()
        {
            Armor output = new Armor();
            foreach (Item item in player.getEquippedItems())
            {
                if (item is Armor)
                    output = (Armor)item;
            }

            return output;
        }

        //--------------------------------------------------------------------
        // checks if an armor is equipped to the player
        //--------------------------------------------------------------------
        public bool isArmorEquipped()
        {
            bool output = false;
            foreach (Item item in player.getEquippedItems())
            {
                if (item is Armor)
                    output = true;
            }

            return output;
        }

        //--------------------------------------------------------------------
        // gets the Accessory that is equipped to the player
        //--------------------------------------------------------------------
        public Accessory getEquippedAccessory()
        {
            Accessory output = new Accessory();
            foreach (Item item in player.getEquippedItems())
            {
                if (item is Accessory)
                    output = (Accessory)item;
            }

            return output;
        }

        //--------------------------------------------------------------------
        // checks if an accessory is equipped to the player
        //--------------------------------------------------------------------
        public bool isAccessoryEquipped()
        {
            bool output = false;
            foreach (Item item in player.getEquippedItems())
            {
                if (item is Accessory)
                    output = true;
            }

            return output;
        }

        public Item findEquippedItemOfSameType(Item selectedItem)
        {
            Item outgoingItem = selectedItem;
            foreach (Item item in player.getEquippedItems())
            {
                if (selectedItem is Accessory && item is Accessory)
                    outgoingItem = item;
            }

            return outgoingItem;
        }
    }
}
