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
    public partial class Fuzzy_Variable_Visualizer : Form
    {
        public Core Core_Unit_Ref;
        private Dictionary<int,Variable> Variables;
        private Membership SelectedMemberShip;
        private Variable Temp;
        private int VarIndex = 1;


        public Fuzzy_Variable_Visualizer()
        {
            InitializeComponent();
        }

        private void Fuzzy_Variable_Visualizer_Load(object sender, EventArgs e)
        {
            SelectedMemberShip = new Membership();
            Core_Unit_Ref.LoadVariablesData();
            Variables = new Dictionary<int, Variable>();
            for (int i = 1; i <= 1000; i++)
            {
                Variable V = Core_Unit_Ref.GetVariable(i);
                if (V != null)
                {
                    Variables.Add(V.ID, V);                    
                }
            }
            SetInfo();
        }

        private void Fuzzy_Variable_Visualizer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Core_Unit_Ref.Dispose();
        }

       
        private void SetInfo()
        {
            Temp = Variables[VarIndex];
            LblVariableID.Text = VarIndex.ToString();
            LblVariableName.Text = Temp.VariableName;
            LblFrom.Text = Temp.VariableRange.Start.ToString();
            LblTo.Text = Temp.VariableRange.End.ToString();
            LblVariableType.Text = Temp.VariableType.ToString();
            LblMidValue.Text = Temp.Perfect_Value.ToString();
            CBMemberShipNames.Items.Clear();
            foreach (Membership MEM in Temp.MemberShipFunctions)
            {
                CBMemberShipNames.Items.Add(MEM.MembershipName);
            }
            if (Temp.MemberShipFunctions.Count > 0)
            {
                CBMemberShipNames.SelectedIndex = 0;               
            }
             
            Core_Unit_Ref.DrawVariable(Temp.VariableName,false);
        }

        private void CBMemberShipNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBMemberShipNames.Items.Count > 0)
            {
                SelectedMemberShip = Temp.MemberShipFunctions[CBMemberShipNames.SelectedIndex];
                LblMEmberShipID.Text = SelectedMemberShip.MID.ToString();
                LblMemberShipParams.Text = "";
                foreach (int Param in SelectedMemberShip.MembershipParameters)
                {
                    LblMemberShipParams.Text += Param + " , ";
                }
                LblMemberShipParams.Text = LblMemberShipParams.Text.Substring(0, LblMemberShipParams.Text.Length - 2);
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (VarIndex + 1 <= Variables.Count)
            {
                VarIndex++;
                SetInfo();
            }
            else            
            {
                MainForm.StatusMSG = "This is the last Variable.";
                //Throw Last Record warning.
            }

        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (VarIndex - 1 >= 1)
            {
                VarIndex--;
                SetInfo();
            }
            else
            {
                MainForm.StatusMSG = "This is the first Variable.";
                //Throw first Record warning.
            }
        }

        private void Fuzzy_Variable_Visualizer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Core_Unit_Ref.Dispose();
        }
    }
}
