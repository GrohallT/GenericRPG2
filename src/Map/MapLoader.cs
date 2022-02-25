//----------------------------------------------------------------------
// Name:    Brian Rodenkirch
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Loads the map from a text file.
//----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Map
{
    //------------------------------------------------------------------
    // This class loads the map from a text file.
    //------------------------------------------------------------------
    public abstract class MapLoader
    {
        //--------------------------------------------------------------
        // This method loads the map from a text file.
        //--------------------------------------------------------------
        public static int[][] loadMap()
        {
            string text = Properties.Resources.Map;
            string[] rows = text.Split("\n");
            
            for (int row = 0; row < rows.Length; row++)
            {
                rows[row] = rows[row].Replace("  ", " ").Trim();
            }

            int[][] map = new int[rows[0].Split(" ").Length][];

            for (int column = 0; column < map.Length; column++)
            {
                map[column] = new int[rows.Length];

                for (int row = 0; row < rows.Length; row++)
                {
                    map[column][row] = int.Parse(rows[row].Split(" ")[column]);
                     
                }

            }

            return map;

        }

    }

}
