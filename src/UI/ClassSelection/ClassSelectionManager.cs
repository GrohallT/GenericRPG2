//---------------------------------------------------------------
// Name: Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Code to manage the player clas selection 
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericRPG2.UI.ClassSelection
{
   //---------------------------------------------------------------
   // Contains the logic related to the class selection process
   //---------------------------------------------------------------
   public class ClassSelectionManager
   {
      ClassSelectionData classSelectionData;
   
      public ClassSelectionManager(Form form)
      {
         this.classSelectionData = new ClassSelectionData(form);

         int selection = classSelectionData.getPosition();

         clearDescriptions();

         classSelectionData.getClasses()[selection].BackColor = Color.LightBlue;
         classSelectionData.getDescriptions()[selection].Visible = true;
         classSelectionData.getConfirmationLabel().Visible = false;
         
      }

      //---------------------------------------------------------------
      // Highlights the labels that contain class names when the user
      // is currently "selecting" that class
      //---------------------------------------------------------------
      public void highlightClasses()
      {
         clearClassHighlights();
         clearDescriptions();

         int selection = classSelectionData.getPosition();
          
         classSelectionData.getClasses()[selection].BackColor = Color.LightBlue;
         classSelectionData.getDescriptions()[selection].Visible = true;
      }

      //---------------------------------------------------------------
      // Clears the highlights on the labels that contain the class names
      //---------------------------------------------------------------
      public void clearClassHighlights()
      {
         foreach (Label label in classSelectionData.getClasses())
            label.BackColor = Color.White;
      }

      //---------------------------------------------------------------
      // Makes all the labels that contain class descriptions invisible
      //---------------------------------------------------------------
      public void clearDescriptions()
      {
         foreach (Label label in classSelectionData.getDescriptions())
            label.Visible = false;
      }

      //---------------------------------------------------------------
      // Manages the input from the user
      //---------------------------------------------------------------
      public void manageInput(object sender, KeyEventArgs e)
      {
         int position = classSelectionData.getPosition();

         if (classSelectionData.getConfirmationLabel().Visible == false)
         {
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
               if (position < classSelectionData.getSelection().Length - 1)
               {
                  classSelectionData.setPosition(position + 1);
                  highlightClasses();
               }
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
               if (position > 0)
               {
                  classSelectionData.setPosition(position - 1);
                  highlightClasses();
               }
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Z)
            {
               classSelectionData.getConfirmationLabel().Visible = true;
               
               if(position == 0)
                  classSelectionData.setSelectedClassName("Knight");
               else if(position == 1)
                  classSelectionData.setSelectedClassName("Archer");
               else if (position == 2)
                  classSelectionData.setSelectedClassName("Mage");
               else if (position == 3)
                  classSelectionData.setSelectedClassName("Thief");

               classSelectionData.updateConfirmationText();

            }
         }
         else if(classSelectionData.getConfirmationLabel().Visible == true)
         {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Z)
            {
               classSelectionData.setClassSelection(position);
               classSelectionData.setCharacterEnum();
               classSelectionData.getCharacterSelectionForm().Hide();

               GameRunner.createCharacter(classSelectionData);
            }
            else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.X)
            {
               classSelectionData.getConfirmationLabel().Visible = false;
            }
         }
      }
      
      public ClassSelectionData getClassSelectionData()
      {
         return this.classSelectionData;
      }

   }
}
