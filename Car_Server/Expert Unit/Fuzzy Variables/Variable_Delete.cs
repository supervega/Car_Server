using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FuzzyLogic_Unit;

namespace Car_Server
{
    public partial class Variable_Delete : Form
    {
        public Core Core_Unit_Ref;

        public Variable_Delete()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       

        private void Variable_Delete_Load(object sender, EventArgs e)
        {
            Core_Unit_Ref.LoadVariablesData();
            for (int i = 0; i < 1000; i++)
            {
                Variable Currentvar = Core_Unit_Ref.GetVariable(i + 1);
                if (Currentvar != null)
                {
                    CBVariableType.Items.Add(Currentvar.VariableName);
                    if (Core_Unit_Ref.VariablesCount == CBVariableType.Items.Count)
                        break;
                }
            }
            if (CBVariableType.Items.Count > 0)
                CBVariableType.SelectedIndex = 0;
        }

        private void BtnDeleteVariable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                Variable Currentvar = Core_Unit_Ref.GetVariable(i + 1);
                if (Currentvar!=null && Currentvar.VariableName == CBVariableType.SelectedItem.ToString())
                {
                    Core_Unit_Ref.DeleteVaraible(Currentvar.ID);
                    Core_Unit_Ref.DeleteVariable(Currentvar.ID);
                    CBVariableType.Items.Remove(Currentvar.VariableName);
                    break;
                }
            }
            if (CBVariableType.Items.Count > 0)
                CBVariableType.SelectedIndex = 0;
        }
    }
}
