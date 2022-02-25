/* Class to manage maps
 * @author Robert Becker
 */
/* Most methods dealing with the map take the desired map
 * as a parameter.
 * 
 */
using GenericRPG2.Players;
using GenericRPG2.UI.Overworld;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericRPG2.Map
{
    public class MapManager
    {
        protected Map map;

        private PictureBox mapPictureBox;

        public MapManager()
        {
            this.map = new Map();
        }

        public Map getMap()
        {
            return this.map;
        }

        /* Displays the specified map on the specified form
         * @param map: the map that is to be displayed
         * @param form: the form that the map is to be displayed on
         */
        public void displayMap(Form form)
        {
            mapPictureBox = ((Overworld)form).getMapPictureBox();

            mapPictureBox.Size = new System.Drawing.Size((12 * 3 + 2) * 64, (8 * 3 + 2) * 64);
            
            setMapImage();

            mapPictureBox.Visible = true;

        }

        public void setMapImage()
        {
            Image mapSection = new Bitmap((12 * 3 + 2) * 64, (8 * 3 + 2) * 64);

            Graphics graphics = Graphics.FromImage(mapSection);
            
            int sectionX = (map.getPlayerXPosition() - 1) / 12;
            int sectionY = (map.getPlayerYPosition() - 1) / 8;
            
            for (int i = sectionX * 12 - 13; i <= sectionX * 12 + 25; i++)
            {
                for (int j = sectionY * 8 - 9; j <= sectionY * 8 + 17; j++)
                {
                    if (i >= 0 && i < map.getMapWidth() && j >= 0 && j < map.getMapHeight())
                        graphics.DrawImageUnscaledAndClipped(map.getTileImage(map.getMapLayout()[i, j]), new Rectangle((i - sectionX * 12 + 12) * 64, (j - sectionY * 8 + 8) * 64, 64, 64));

                }

            }

            mapPictureBox.Location = new Point(-12 * 64, -8 * 64);
            mapPictureBox.Image = mapSection;

        }

        /* Displays the player on the specified form
         * @param player: the player class of the player which
         * is to be displayed
         * @param form: the formt that the player will be displayed on
         */
        public void displayPlayer(Player player)
        {
            player.getPlayerSprite().BringToFront();
        }

        /* Checks if there is a collision at the specified x and y coordinates
         * @param map: the map that is being checked for a collision
         * @param x: the x coordinate that is being checked
         * @param y: the y coordinate that is being checked
         * @return Boolean: returns true if there is a collision,
         * false otherwise
         */
        public Boolean isCollision(int x, int y)
        {
            Boolean collided = false;

            //all impassable tiles would be marked on
            //the map layout with an integer below or equal to 0

            if (x < 0 || y < 0)
                collided = true;
            else if (x >= map.getMapWidth() || y >= map.getMapHeight())
                collided = true;
            else if (map.getMapLayout()[x, y] <= 0)
                collided = true;
            return collided;
        }
    }
}
