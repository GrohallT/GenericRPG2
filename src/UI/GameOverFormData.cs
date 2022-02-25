//---------------------------------------------------------------
// Name: Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store the data related to the game over form
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace GenericRPG2.UI
{
   //---------------------------------------------------------------
   // Contains the data for the game over form
   //---------------------------------------------------------------
   public class GameOverFormData
   {

      protected Label[] options;
      protected int position;

      public GameOverFormData()
      {
         this.options = new Label[2];
         this.position = 0;
      }

      public Label[] getOptions()
      {
         return this.options;
      }

      public int getPoisition()
      {
         return this.position;
      }

      public void setPosition(int newPosition)
      {
         this.position = newPosition;
      }
   }
}
