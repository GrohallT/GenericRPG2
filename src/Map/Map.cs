//---------------------------------------------------------------------
// Name:    Bennett Ceku
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Stores the layout and tiles of the current loaded Map.
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericRPG2.Map
{
    //-------------------------------------------------------------------
    // Stores the layout and tiles of the current loaded Map.
    //-------------------------------------------------------------------
    public class Map
    {
        protected int width;
        protected int height;
        protected int[,] layout;
        protected int playerXPosition;
        protected int playerYPosition;
        
        protected int[][] defaultLayout = MapLoader.loadMap();

        private Dictionary<int, Image> tileImages;

        public Map()
        {
            tileImages = new Dictionary<int, Image>();

            addTilesToDictionary();

            width = defaultLayout.Length;
            height = defaultLayout[0].Length;
            
            layout = new int[width, height];
            
            playerXPosition = 1;
            playerYPosition = 1;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    layout[i, j] = defaultLayout[i][j];
                    
                }

            }
            
            //saveMapAsImage();

        }

        //--------------------------------------------------------------
        // This method adds all of the tiles and their respective ids to
        // the dictionary for future use.
        //--------------------------------------------------------------
        private void addTilesToDictionary()
        {
            tileImages.Add(-16, Properties.Resources.NapoleonTileBR);
            tileImages.Add(-15, Properties.Resources.NapoleonTileBL);
            tileImages.Add(-14, Properties.Resources.NapoleonTileTR);
            tileImages.Add(-13, Properties.Resources.NapoleonTileTL);
            tileImages.Add(-12, Properties.Resources.MarbleWall);
            tileImages.Add(-11, Properties.Resources.Campfire);
            tileImages.Add(-10, Properties.Resources.Fireplace);
            tileImages.Add(-9, Properties.Resources.Inn);
            tileImages.Add(-8, Properties.Resources.Void);
            tileImages.Add(-7, Properties.Resources.PalmTree);
            tileImages.Add(-6, Properties.Resources.Tree);
            tileImages.Add(-5, Properties.Resources.Shop);
            tileImages.Add(-4, Properties.Resources.Brick);
            tileImages.Add(-3, Properties.Resources.Lava);
            tileImages.Add(-2, Properties.Resources.DeepWater);
            tileImages.Add(-1, Properties.Resources.Rock);
            tileImages.Add(0, Properties.Resources.Water);
            tileImages.Add(1, Properties.Resources.Grass);
            tileImages.Add(2, Properties.Resources.Sand);
            tileImages.Add(3, Properties.Resources.Snow);
            tileImages.Add(4, Properties.Resources.Gravel);
            tileImages.Add(5, Properties.Resources.Wood);
            tileImages.Add(6, Properties.Resources.Marble);
            tileImages.Add(7, Properties.Resources.StoneBrick);
            
        }

        public int getMapHeight()
        {
            return height;
        }

        public int getMapWidth()
        {
            return width;
        }

        public int[,] getMapLayout()
        {
            return layout;
        }

        public int getPlayerXPosition()
        {
            return playerXPosition;
        }

        public int getPlayerYPosition()
        {
            return playerYPosition;
        }

        public void setPlayerXPosition(int xPos)
        {
            playerXPosition = xPos;
        }

        public void setPlayerYPosition(int yPos)
        {
            playerYPosition = yPos;
        }

        //-------------------------------------------------------------------
        // Returns the Image of the tile associated with the given number.
        //-------------------------------------------------------------------
        public Image getTileImage(int tileNumber)
        {
            Image tileImage = tileImages.GetValueOrDefault(tileNumber);

            if (tileImage == null)
                return Properties.Resources.Error;

            return tileImage;
        }

        //--------------------------------------------------------------
        // This method is an unimplemented utility method for saving the
        // map as an image in the user's document folder. The method can
        // be used by the project team as need be, but should not be
        // referenced in the final release.
        //--------------------------------------------------------------
        /*private void saveMapAsImage()
        {
            Bitmap map = new Bitmap(width * 64, height * 64);

            Graphics graphics = Graphics.FromImage(map);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    graphics.DrawImageUnscaledAndClipped(getTileImage(layout[i, j]), new Rectangle(i * 64, j * 64, 64, 64));

                }

            }

            map.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Map.png", System.Drawing.Imaging.ImageFormat.Png);

        }*/

    }

}
