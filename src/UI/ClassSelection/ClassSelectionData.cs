//---------------------------------------------------------------
// Name: Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Code to contain data used in the class selection process
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GenericRPG2.CharacterClass;

namespace GenericRPG2.UI.ClassSelection
{
   //---------------------------------------------------------------
   // Contains information related to the class selection process
   //---------------------------------------------------------------
   public class ClassSelectionData
   {
      protected const int SELECTION_NUMBER = 4;
      protected Label[] classes;
      protected Label[] descriptions;
      protected int[] selection;
      protected int position;
      protected string knightDescriptionText;
      protected string archerDescriptionText;
      protected string mageDescriptionText;
      protected string thiefDescriptionText;
      protected string confirmationText;
      protected int selectedClass;
      protected string selectedClassName;
      protected Form classSelectionForm;
      protected Label confirmationLabel;
      protected CharacterClassEnum selectedCharacterEnum;

      public ClassSelectionData(Form form)
      {
         this.classes = new Label[SELECTION_NUMBER];
         this.descriptions = new Label[SELECTION_NUMBER];
         this.selection = new int[SELECTION_NUMBER];
         this.position = 0;
         this.selectedClass = -1;
         this.selectedClassName = null;
         this.knightDescriptionText = "Class that specializes in defense\n\nBase Stats:\n" +
            "HP : 20\n" +
            "SP : 20\n" +
            "Atk: 20\n" +
            "Def: 100\n" +
            "Spd: 20";
         this.archerDescriptionText = "Class that specializes in attack\n\nBase Stats:\n" +
            "HP : 20\n" +
            "SP : 20\n" +
            "Atk: 100\n" +
            "Def: 20\n" +
            "Spd: 20";
         this.mageDescriptionText = "Class that specializes in magic\n\nBase Stats:\n" +
            "HP : 20\n" +
            "SP : 100\n" +
            "Atk: 20\n" +
            "Def: 20\n" +
            "Spd: 20";
         this.thiefDescriptionText = "Class that specializes in speed\n\nBase Stats:\n" +
            "HP : 20\n" +
            "SP : 20\n" +
            "Atk: 20\n" +
            "Def: 20\n" +
            "Spd: 100";
         this.confirmationText = "You have selected: " + selectedClassName + "\nYour class cannot be changed later, are you ok with this selection?\n" +
            "Enter - yes      BackSpace - no";
         this.classSelectionForm = form;
         this.confirmationLabel = this.classSelectionForm.Controls.Find("ConfirmationLabel", true).FirstOrDefault() as Label;

         for (int i = 0; i < SELECTION_NUMBER; i++)
         {
            classes[i] = new Label();
            descriptions[i] = new Label();
            selection[i] = i;

         }

         initializeClasses();
         initializeDescriptions();

      }

      //---------------------------------------------------------------
      // Initializes the labels that display the classes that the player
      // can choose
      //---------------------------------------------------------------
      public void initializeClasses()
      {
         classes[0] = this.classSelectionForm.Controls.Find("KnightClass", true).FirstOrDefault() as Label;
         classes[0].Text = "Knight";
         
         classes[1] = this.classSelectionForm.Controls.Find("ArcherClass", true).FirstOrDefault() as Label;
         classes[1].Text = "Archer";

         classes[2] = this.classSelectionForm.Controls.Find("MageClass", true).FirstOrDefault() as Label;
         classes[2].Text = "Mage";

         classes[3] = this.classSelectionForm.Controls.Find("ThiefClass", true).FirstOrDefault() as Label;
         classes[3].Text = "Thief";
      }

      //---------------------------------------------------------------
      // Initializes the labels that display the descriptions for
      // each class that the player can select
      //---------------------------------------------------------------
      public void initializeDescriptions()
      {
         descriptions[0] = this.classSelectionForm.Controls.Find("KnightDescription", true).FirstOrDefault() as Label;
         descriptions[0].Text = knightDescriptionText;

         descriptions[1] = this.classSelectionForm.Controls.Find("ArcherDescription", true).FirstOrDefault() as Label;
         descriptions[1].Text = archerDescriptionText;

         descriptions[2] = this.classSelectionForm.Controls.Find("MageDescription", true).FirstOrDefault() as Label;
         descriptions[2].Text = mageDescriptionText;

         descriptions[3] = this.classSelectionForm.Controls.Find("ThiefDescription", true).FirstOrDefault() as Label;
         descriptions[3].Text = thiefDescriptionText;

         this.confirmationLabel.Text = confirmationText;
      }

      public Label[] getClasses()
      {
         return this.classes;
      }

      public Label[] getDescriptions()
      {
         return this.descriptions;
      }

      public int[] getSelection()
      {
         return this.selection;
      }

      public int getPosition()
      {
         return this.position;
      }

      public void setPosition(int newPosition)
      {
         this.position = newPosition;
      }

      public Label getConfirmationLabel()
      {
         return this.confirmationLabel;
      }

      public void setClassSelection(int selected)
      {
         this.selectedClass = selected;
      }

      public int getClassSelection()
      {
         return this.selectedClass;
      }

      public void setSelectedClassName(String name)
      {
         this.selectedClassName = name;
      }

      public void updateConfirmationText()
      {
         this.confirmationText = "You have selected: " + selectedClassName + "\nYour class cannot be changed later, are you ok with this selection?\n" +
            "Enter - yes      BackSpace - no";
         this.confirmationLabel.Text = confirmationText;
      }

      public int getSelectedClass()
      {
         return this.selectedClass;
      }

      public void setCharacterEnum()
      {
         if (this.selectedClass == 0)
            this.selectedCharacterEnum = CharacterClassEnum.KNIGHT;
         else if (position == 1)
            this.selectedCharacterEnum = CharacterClassEnum.ARCHER;
         else if (position == 2)
            this.selectedCharacterEnum = CharacterClassEnum.MAGE;
         else if (position == 3)
            this.selectedCharacterEnum = CharacterClassEnum.THIEF;
      }
      //use this to pass to player
      public CharacterClassEnum getSelectedCharacterClass()
      {
         return this.selectedCharacterEnum;
      }
      public Form getCharacterSelectionForm()
      {
         return this.classSelectionForm;
      }

      public String getSelectedClassName()
      {
         return this.selectedClassName;
      }
   }
}
