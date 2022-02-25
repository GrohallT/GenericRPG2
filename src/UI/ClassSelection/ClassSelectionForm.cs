//---------------------------------------------------------------
// Name: Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Form for the class selection process
//---------------------------------------------------------------
using GenericRPG2.UI.ClassSelection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericRPG2
{
   //---------------------------------------------------------------
   // Contains the form related to the class selection process
   //---------------------------------------------------------------
   public partial class ClassSelectionForm : Form
   {
      ClassSelectionManager classSelectionManager;

      public ClassSelectionForm()
      {
         InitializeComponent();
         classSelectionManager = new ClassSelectionManager(this);
      }

      private void ClassSelectionForm_Load(object sender, EventArgs e)
      {
      }

      //---------------------------------------------------------------
      // The form key down event
      //---------------------------------------------------------------
      private void ClassSelectionForm_KeyDown(object sender, KeyEventArgs e)
      {
         classSelectionManager.manageInput(sender, e);
      }
   }
}
