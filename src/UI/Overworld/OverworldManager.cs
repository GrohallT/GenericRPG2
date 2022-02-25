using GenericRPG2.CharacterClass;
using GenericRPG2.Enemies;
using GenericRPG2.Map;
using GenericRPG2.Players;
using GenericRPG2.UI.Shop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//----------------------------------------------------------------------
// Name: Brian Rodenkirch
// Project: Generic RPG 2, a simple turn-based RPG
// Purpose: This class manages the overworld and any processing involved with it, such as collision and map scrolling.
//----------------------------------------------------------------------
namespace GenericRPG2.UI.Overworld
{
    public class OverworldManager
    {
        private PlayerManager playerManager;

        private PictureBox mapPictureBox;

        private MapManager mapManager;

        private Overworld overworldForm;

        private List<Image> characterBackFacingList;
        private List<Image> characterLeftFacingList;
        private List<Image> characterFrontFacingList;
        private List<Image> characterRightFacingList;

        private Random random;

        private int DEFAULT_RANDOM_SEED = 2506;

        private DateTime timeOfLastInput;

        //-------------------------------------------------------------------
        // This class handles logic related to the Overworld form.
        //-------------------------------------------------------------------
        public OverworldManager(PlayerManager playerManager, MapManager mapManager, Overworld overworldForm)
        {
            this.mapManager = mapManager;
            this.mapPictureBox = overworldForm.getMapPictureBox();
            this.playerManager = playerManager;
            this.overworldForm = overworldForm;
            this.timeOfLastInput = DateTime.Now;

            characterBackFacingList = new List<Image>();
            characterLeftFacingList = new List<Image>();
            characterFrontFacingList = new List<Image>();
            characterRightFacingList = new List<Image>();

            characterBackFacingList.Add(Properties.Resources.MainCharacter_Back_Move1);
            characterBackFacingList.Add(Properties.Resources.MainCharacter_Back_Move2);
            characterBackFacingList.Add(Properties.Resources.MainCharacter_Back);
            
            characterLeftFacingList.Add(Properties.Resources.MainCharacter_Left_Move);
            characterLeftFacingList.Add(Properties.Resources.MainCharacter_Left);
            
            characterFrontFacingList.Add(Properties.Resources.MainCharacter_Front_Move1);
            characterFrontFacingList.Add(Properties.Resources.MainCharacter_Front_Move2);
            characterFrontFacingList.Add(Properties.Resources.MainCharacter_Front);
            
            characterRightFacingList.Add(Properties.Resources.MainCharacter_Right_Move);
            characterRightFacingList.Add(Properties.Resources.MainCharacter_Right);
            
            this.random = new Random(DEFAULT_RANDOM_SEED);
        }

        //-------------------------------------------------------------------
        // This method handles input passed in from the overworld form.
        //-------------------------------------------------------------------
        public void handleInput(KeyEventArgs e)
        {
            if (DateTime.Now < timeOfLastInput.AddMilliseconds(5))
                return;

            DirectionsEnum direction = getDirection(e.KeyCode);

            if (direction != DirectionsEnum.NONE)
                handleDirectionalInput(direction);

            if (inShopRange())
            {
                if (e.KeyCode == Keys.Z)
                {
                    TestShop testShop = new TestShop();
                    ShopForm shopForm = new ShopForm(testShop, playerManager);
                    overworldForm.Hide();
                    shopForm.ShowDialog();
                    overworldForm.Show();
                }
            }

            if (inInnRange())
            {
                if (e.KeyCode == Keys.Z)
                {
                    playerManager.getPlayer().getPlayerStats().setHpToMax();
                    overworldForm.getStatsLabel().Text = playerManager.getPlayer().getPlayerStats().displayStats();
                    overworldForm.setInnRestedVisible(true);
                    overworldForm.setInnConfirmationVisible(false);
                }
            }
            else
            {
                overworldForm.setInnRestedVisible(false);
            }

            if (e.KeyCode == Keys.C)
            {
                InventoryForm inventoryForm = new InventoryForm(playerManager);
                overworldForm.Hide();
                inventoryForm.ShowDialog();
                overworldForm.Show();
            }

            overworldForm.getStatsLabel().BringToFront();

            timeOfLastInput = DateTime.Now;

        }

        //-------------------------------------------------------------------
        // This method handles directional input from the Overworld form.
        //-------------------------------------------------------------------
        public void handleDirectionalInput(DirectionsEnum direction)
        {
            playerManager.updateDirection(direction);

            if (!isCollision(direction))
            {
                movePlayer(direction, true);
                
            }

            scrollMap(true);

            mapManager.displayPlayer(playerManager.getPlayer());

        }

        //-------------------------------------------------------------------
        // This function returns a direction based on the key pressed.
        //-------------------------------------------------------------------
        public DirectionsEnum getDirection(Keys keyPressed) =>
            keyPressed switch
            {
                Keys.W => DirectionsEnum.UP,
                Keys.A => DirectionsEnum.LEFT,
                Keys.S => DirectionsEnum.DOWN,
                Keys.D => DirectionsEnum.RIGHT,
                Keys.Up => DirectionsEnum.UP,
                Keys.Left => DirectionsEnum.LEFT,
                Keys.Down => DirectionsEnum.DOWN,
                Keys.Right => DirectionsEnum.RIGHT,
                _ => DirectionsEnum.NONE,
            };
            
        //-------------------------------------------------------------------
        // This method moves the player in the specified direction.
        //-------------------------------------------------------------------
        public void movePlayer(DirectionsEnum direction, bool animated)
        {
            switch (direction)
            {
                case DirectionsEnum.UP:
                    if (animated)
                        Animator.moveAnimated(playerManager.getPlayer().getPlayerSprite(), 0, -64, 0.2, characterBackFacingList);
                    mapManager.getMap().setPlayerYPosition(mapManager.getMap().getPlayerYPosition() - 1);
                    break;
                case DirectionsEnum.LEFT:
                    if (animated)
                        Animator.moveAnimated(playerManager.getPlayer().getPlayerSprite(), -64, 0, 0.2, characterLeftFacingList);
                    mapManager.getMap().setPlayerXPosition(mapManager.getMap().getPlayerXPosition() - 1);
                    break;
                case DirectionsEnum.DOWN:
                    if (animated)
                        Animator.moveAnimated(playerManager.getPlayer().getPlayerSprite(), 0, 64, 0.2, characterFrontFacingList);
                    mapManager.getMap().setPlayerYPosition(mapManager.getMap().getPlayerYPosition() + 1);
                    break;
                case DirectionsEnum.RIGHT:
                    if (animated)
                        Animator.moveAnimated(playerManager.getPlayer().getPlayerSprite(), 64, 0, 0.2, characterRightFacingList);
                    mapManager.getMap().setPlayerXPosition(mapManager.getMap().getPlayerXPosition() + 1);
                    break;
            }

        }

        //-------------------------------------------------------------------
        // This method scrolls the map if the player reaches the edge.
        //-------------------------------------------------------------------
        public void scrollMap(bool animated)
        {
            Point initialMapPosition = new Point(mapManager.getMap().getPlayerXPosition(), mapManager.getMap().getPlayerYPosition());

            //This if statement checks if the player is in the correct location for the map to scroll.
            if (playerManager.getPlayer().getPlayerSprite().Location.X + mapPictureBox.Location.X == 0 && initialMapPosition.X > 0)
            {
                Console.WriteLine("here");
                if (animated)
                    Animator.move(mapPictureBox, 64 * 12, 0, 0.5);
                playerManager.getPlayer().getPlayerSprite().Location = new Point(1536, playerManager.getPlayer().getPlayerSprite().Location.Y);
                mapManager.setMapImage();
            }
            else if (playerManager.getPlayer().getPlayerSprite().Location.X + mapPictureBox.Location.X == 64 * 13 && initialMapPosition.X < mapManager.getMap().getMapWidth() - 1)
            {
                Console.WriteLine("here");
                if (animated)
                    Animator.move(mapPictureBox, -64 * 12, 0, 0.5);
                playerManager.getPlayer().getPlayerSprite().Location = new Point(832, playerManager.getPlayer().getPlayerSprite().Location.Y);
                mapManager.setMapImage();
            }
            else if (playerManager.getPlayer().getPlayerSprite().Location.Y + mapPictureBox.Location.Y == 0 && initialMapPosition.Y > 0)
            {
                Console.WriteLine("here");
                if (animated)
                    Animator.move(mapPictureBox, 0, 64 * 8, 0.5);
                playerManager.getPlayer().getPlayerSprite().Location = new Point(playerManager.getPlayer().getPlayerSprite().Location.X, 1024);
                mapManager.setMapImage();
            }
            else if (playerManager.getPlayer().getPlayerSprite().Location.Y + mapPictureBox.Location.Y == 64 * 9 && initialMapPosition.Y < mapManager.getMap().getMapHeight() - 1)
            {
                Console.WriteLine("here");
                if (animated)
                    Animator.move(mapPictureBox, 0, -64 * 8, 0.5);
                playerManager.getPlayer().getPlayerSprite().Location = new Point(playerManager.getPlayer().getPlayerSprite().Location.X, 576);
                mapManager.setMapImage();
            }
            else
            {
                if (inFinalBossRange())
                {
                    startBossBattle();
                }

                else if (isEnemy())
                {
                    List<EnemyManager> enemies = generateEnemies();

                    // uncomment the constructor when battleform is done
                    BattleForm battleForm = new BattleForm(this, playerManager, enemies);
                    overworldForm.Hide();
                    battleForm.ShowDialog();
                    
                }

            }

        }

        public void startBossBattle()
        {
            List<EnemyManager> enemies = new List<EnemyManager>();
            enemies.Add(new EnemyManager(EnemyTypeEnum.MECHA_NAPOLEON));

            // uncomment the constructor when battleform is done
            BattleForm battleForm = new BattleForm(this, playerManager, enemies);
            overworldForm.Hide();
            battleForm.ShowDialog();
        }

        //-------------------------------------------------------------------
        // This method checks if the player is able to move in the specified direction.
        //-------------------------------------------------------------------
        public Boolean isCollision(DirectionsEnum direction) =>
           direction switch
           {
               DirectionsEnum.UP => mapManager.isCollision(mapManager.getMap().getPlayerXPosition(), mapManager.getMap().getPlayerYPosition() - 1),
               DirectionsEnum.LEFT => mapManager.isCollision(mapManager.getMap().getPlayerXPosition() - 1, mapManager.getMap().getPlayerYPosition()),
               DirectionsEnum.DOWN => mapManager.isCollision(mapManager.getMap().getPlayerXPosition(), mapManager.getMap().getPlayerYPosition() + 1),
               DirectionsEnum.RIGHT => mapManager.isCollision(mapManager.getMap().getPlayerXPosition() + 1, mapManager.getMap().getPlayerYPosition()),
               _ => true,
           };

        //-------------------------------------------------------------------
        // This method checks if the player is close to a shop tile.
        //-------------------------------------------------------------------
        public bool inShopRange()
        {
            int[,] mapLayout = mapManager.getMap().getMapLayout();
            int playerXPosition = mapManager.getMap().getPlayerXPosition();
            int playerYPosition = mapManager.getMap().getPlayerYPosition();
            int mapWidth = mapManager.getMap().getMapWidth();
            int mapHeight = mapManager.getMap().getMapHeight();

            if ((playerXPosition + 1) < mapWidth && (playerYPosition + 1) < mapHeight && playerXPosition > 0 && playerYPosition > 0)
            {
                for(int i = playerXPosition - 1; i <= (playerXPosition + 1); i++)
                {
                    for(int j = playerYPosition - 1; j <= (playerYPosition + 1); j++)
                    {
                        if (mapLayout[i, j] == -5)
                        {
                            overworldForm.getShopConfirmation().Visible = true;
                            return true;
                        }
                    }
                }
            }

            overworldForm.getShopConfirmation().Visible = false;
            return false;
        }

        //-------------------------------------------------------------------
        // This method checks if the player is close to a inn tile.
        //-------------------------------------------------------------------
        public bool inInnRange()
        {
            int[,] mapLayout = mapManager.getMap().getMapLayout();
            int playerXPosition = mapManager.getMap().getPlayerXPosition();
            int playerYPosition = mapManager.getMap().getPlayerYPosition();
            int mapWidth = mapManager.getMap().getMapWidth();
            int mapHeight = mapManager.getMap().getMapHeight();

            if ((playerXPosition + 1) < mapWidth && (playerYPosition + 1) < mapHeight && playerXPosition > 0 && playerYPosition > 0)
            {
                for (int i = playerXPosition - 1; i <= (playerXPosition + 1); i++)
                {
                    for (int j = playerYPosition - 1; j <= (playerYPosition + 1); j++)
                    {
                        if (mapLayout[i, j] == -9)
                        {
                            if(!overworldForm.getInnRested().Visible)
                                overworldForm.getInnConfirmation().Visible = true;
                            return true;
                        }
                    }
                }
            }

            overworldForm.getInnConfirmation().Visible = false;
            return false;
        }

        //-------------------------------------------------------------------
        // This method checks if the player is in range of the final boss
        //-------------------------------------------------------------------
        public bool inFinalBossRange()
        {
            int[,] mapLayout = mapManager.getMap().getMapLayout();
            int playerXPosition = mapManager.getMap().getPlayerXPosition();
            int playerYPosition = mapManager.getMap().getPlayerYPosition();
            int mapWidth = mapManager.getMap().getMapWidth();
            int mapHeight = mapManager.getMap().getMapHeight();

            if ((playerXPosition + 1) < mapWidth && (playerYPosition + 1) < mapHeight && playerXPosition > 0 && playerYPosition > 0)
            {
                for (int i = playerXPosition - 1; i <= (playerXPosition + 1); i++)
                {
                    for (int j = playerYPosition - 1; j <= (playerYPosition + 1); j++)
                    {
                        if (mapLayout[i, j] >= -16 && mapLayout[i, j] <= -13)
                        {
                            overworldForm.getShopConfirmation().Visible = true;
                            return true;
                        }
                    }
                }
            }

            overworldForm.getShopConfirmation().Visible = false;
            return false;
        }

        public bool isEnemy()
        {
            return random.Next(1, 101) % 10 == 0;
        }

        public List<EnemyManager> generateEnemies()
        {
            List<EnemyManager> listOfEnemies = new List<EnemyManager>();

            // number of enemies
            int numberOfEnemies = random.Next(1, 4);

            for (int i = 0; i < numberOfEnemies; i++)
            {
                listOfEnemies.Add(new EnemyManager());
            }

            return listOfEnemies;
        }

        public Overworld getOverworldForm()
        {
            return this.overworldForm;

        }

        public DateTime getTimeOfLastInput()
        {
            return this.timeOfLastInput;
        }

    }

}
