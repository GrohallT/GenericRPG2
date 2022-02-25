//---------------------------------------------------------------
// Name:    Marshall Paider
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store all of the information pertaining to the Player in the game
//---------------------------------------------------------------------

using GenericRPG2.CharacterClass;
using GenericRPG2.Inventory;
using GenericRPG2.Stats;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GenericRPG2.Items;

namespace GenericRPG2.Players
{
    //------------------------------------------------------------------
    // This class stores the necessary information on the Player and 
    // image of the player's sprite
    //------------------------------------------------------------------
    public class Player
    {
        private const int STARTING_SPRITE_X_POSITION = 832;
        private const int STARTING_SPRITE_Y_POSITION = 576;

        private const int SPRITE_WIDTH = 64;
        private const int SPRITE_HEIGHT = 64;

        private PlayerStats playerStats; // a collection of all of the stats of the player

        private DirectionsEnum lastDirection; // the last direction the player moved
        private CharacterClassEnum characterClass; // the class of the player

        private PictureBox playerSprite;

        // Future sprints will incorporate these variables
        private InventoryManager inventoryManager;
        private LinkedList<Item> equippedItems;
        //private Skills usableSkills;

        public Player(CharacterClassEnum characterClass)
        {
            this.playerStats = new PlayerStats(characterClass);
            this.characterClass = characterClass;

            // creates a PictureBox and sets the Image file, location, size, and stretches the image
            this.playerSprite = new PictureBox();
            playerSprite.Image = Properties.Resources.MainCharacter_Front;
            playerSprite.Location = new Point(STARTING_SPRITE_X_POSITION, STARTING_SPRITE_Y_POSITION);
            playerSprite.SizeMode = PictureBoxSizeMode.StretchImage;
            playerSprite.Size = new Size(SPRITE_WIDTH, SPRITE_HEIGHT);

            this.inventoryManager = new InventoryManager();
            this.equippedItems = new LinkedList<Item>();
            //this.usableSkills = new Skills();
        }

        public InventoryManager getInventoryManager()
        {
            return this.inventoryManager;
        }

        public LinkedList<Item> getEquippedItems()
        {
            return equippedItems;
        }

        public CharacterClassEnum getCharacterClass()
        {
            return characterClass;
        }

        public PlayerStats getPlayerStats()
        {
            return this.playerStats;
        }

        public DirectionsEnum getLastDirection()
        {
            return this.lastDirection;
        }

        public void setLastDirection(DirectionsEnum lastDirection)
        {
            this.lastDirection = lastDirection;

        }

        public PictureBox getPlayerSprite()
        {
            return playerSprite;
        }

        public void setPlayerSprite(Image playerSprite)
        {
            this.playerSprite.Image = playerSprite;
        }
    }
}
