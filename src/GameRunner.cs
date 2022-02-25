//----------------------------------------------------------------------
// Name: Brian Rodenkirch
// Project: Generic RPG 2, a simple turn-based RPG
// Purpose: This class runs the game, managing the necessary forms and information.
//----------------------------------------------------------------------
using GenericRPG2.Map;
using GenericRPG2.Players;
using GenericRPG2.UI.ClassSelection;
using GenericRPG2.UI.Overworld;
using System.Runtime.CompilerServices;

namespace GenericRPG2
{
    //-------------------------------------------------------------------
    // This class runs the game, managing the necessary forms and information.
    //-------------------------------------------------------------------
    public static class GameRunner
    {
        private static ClassSelectionForm classSelectionForm;

        private static PlayerManager playerManager;

        private static MapManager mapManager;

        private static Overworld overworld;

        //-----------------------------------------------------------------
        // This method runs on startup, creating and displaying the class selection form.
        //-----------------------------------------------------------------
        public static void Main()
        {
            classSelectionForm = new ClassSelectionForm();

            classSelectionForm.ShowDialog();

        }

        //-----------------------------------------------------------------
        // This method initializes the Player class and the overworld, displaying it.
        //-----------------------------------------------------------------
        public static void createCharacter(ClassSelectionData classSelectionData)
        {
            createComponents(classSelectionData);

            overworld.ShowDialog();

        }

        //-----------------------------------------------------------------
        // This method creates the necessary components using the given
        // class selection data in order to run the game.
        //-----------------------------------------------------------------
        public static void createComponents(ClassSelectionData classSelectionData)
        {
            playerManager = new PlayerManager(classSelectionData.getSelectedCharacterClass());

            mapManager = new MapManager();

            overworld = new Overworld(playerManager, mapManager);

        }

        public static PlayerManager getPlayerManager()
        {
            return playerManager;

        }

        public static MapManager getMapManager()
        {
            return mapManager;

        }

        public static Overworld getOverworld()
        {
            return overworld;

        }

    }

}
