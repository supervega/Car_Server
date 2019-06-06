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
    public partial class Variable_Modify : Form
    {
        public Core Core_Unit_Ref;
        public Variable Currentvar;
        public int Index = 1;

        public Variable_Modify()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModifyVariable_Click(object sender, EventArgs e)
        {
            Currentvar.VariableName = TXTVariableName.Text;
            if (CBVariableType.Text.ToLower() == "input")
                Currentvar.VariableType = Variable.VarType.Input;
            if (CBVariableType.Text.ToLower() == "output")
                Currentvar.VariableType = Variable.VarType.Output;
            Currentvar.VariableRange = new Range((float)Convert.ToDouble(NUDFrom.Value), (float)Convert.ToDouble(NUDTo.Value));
            Currentvar.Perfect_Value = (int)NUDMid.Value;
            Currentvar.CSS = (int)NUDCentroid_Step_Size.Value;
            string Result = Core_Unit_Ref.Modify_Variable(Currentvar);
            if (Result == "")
                ClearComponents();
            else
            {
                MainForm.StatusMSG = Result;
                MainForm.SEL.LBEvents.Items.Add(Result + "  " + DateTime.Now.ToString());
            }
        }

        private void ClearComponents()
        {
            TXTVariableName.Text = "";
            TXTMembershipName.Text = "";
            TXTMembershipParameters.Text = "";
            NUDCentroid_Step_Size.Value = 0;
            NUDFrom.Value = 0;
            NUDMid.Value = 0;
            NUDTo.Value = 0;
            CBMembership.Items.Clear();
            LblMembershipID.Text = "1";
            CBVariableType.SelectedIndex = 0;
            if (Index + 1 <= Core_Unit_Ref.VariablesCount)
            {
                Index++;
                Currentvar = Core_Unit_Ref.GetVariable(Index);
                SetComponents(Currentvar);
            }
            else
            {
                if (Index - 1 >= 1)
                {
                    Index--;
                    Currentvar = Core_Unit_Ref.GetVariable(Index);
                    SetComponents(Currentvar);
                }
                LblVariableID.Text = "0";
            }
        }

        private void Variable_Modify_Load(object sender, EventArgs e)
        {
            Core_Unit_Ref.LoadVariablesData();
            Currentvar = Core_Unit_Ref.GetVariable(Index);
            SetComponents(Currentvar);
        }

        private void SetComponents(Variable var)
        {
            LblVariableID.Text = var.ID.ToString();
            TXTVariableName.Text = var.VariableName;
            if (var.VariableType == Variable.VarType.Input)
                CBVariableType.SelectedIndex = 0;
            else
                CBVariableType.SelectedIndex = 1;
            NUDFrom.Value = (decimal)var.VariableRange.Start;
            NUDTo.Value = (decimal)var.VariableRange.End;
            NUDMid.Value = (decimal)var.Perfect_Value;
            NUDCentroid_Step_Size.Value = (decimal)var.CSS;
            bool first = true;
            CBMembership.Items.Clear();
            foreach (Membership mem in var.MemberShipFunctions)
            {
                if (first)
                {
                    LblMembershipID.Text = mem.MID.ToString();
                    TXTMembershipName.Text = mem.MembershipName;
                    foreach (int Param in mem.MembershipParameters)
                    {
                        TXTMembershipParameters.Text = Param + " ";
                    }
                    TXTMembershipParameters.Text.Substring(0, TXTMembershipParameters.Text.Length - 1);
                    first = false;
                }
                CBMembership.Items.Add(mem.MembershipName);
            }
            if(CBMembership.Items.Count>0)
                CBMembership.SelectedIndex = 0;
        }

        private void CBMembership_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXTMembershipParameters.Text = "";
            foreach (Membership Mem in Currentvar.MemberShipFunctions)
            {
                if (Mem.MembershipName == CBMembership.SelectedItem.ToString())
                {
                    LblMembershipID.Text = Mem.MID.ToString();
                    TXTMembershipName.Text = Mem.MembershipName;
                    foreach (int Val in Mem.MembershipParameters)
                    {
                        TXTMembershipParameters.Text += Val + " ";
                    }
                    TXTMembershipParameters.Text = TXTMembershipParameters.Text.Substring(0, TXTMembershipParameters.Text.Length - 1);
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (Index + 1 <= Core_Unit_Ref.VariablesCount)
            {
                Index++;
                Currentvar = Core_Unit_Ref.GetVariable(Index);
                SetComponents(Currentvar);
            }
            else
            {
                MainForm.StatusMSG = "This is the last variable.";
                MainForm.SEL.LBEvents.Items.Add("Last variable reached in modify process.  " + DateTime.Now.ToString());
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (Index - 1 >= 1)
            {
                Index--;
                Currentvar = Core_Unit_Ref.GetVariable(Index);
                SetComponents(Currentvar);
            }
            else
            {
                MainForm.StatusMSG = "This is the first variable.";
                MainForm.SEL.LBEvents.Items.Add("First variable reached in modify process.  " + DateTime.Now.ToString());
            }
        }

        private void BtnModifyMembership_Click(object sender, EventArgs e)
        {
            Membership Mem = new Membership();
            Mem.MID = Convert.ToInt32(LblMembershipID.Text);
            Mem.MembershipName = TXTMembershipName.Text;
            string[] Points = TXTMembershipParameters.Text.Split(new char[] { '-', '/', ',', ' ' });
            Mem.MembershipParameters = new List<int>();
            foreach (string str in Points)
            {
                Mem.MembershipParameters.Add(Convert.ToInt32(str));
            }
            for (int i = 0; i < Currentvar.MemberShipFunctions.Count; i++)
            {
                Membership Temp = (Membership)Currentvar.MemberShipFunctions[i];
                if (Temp.MID == Convert.ToInt32(LblMembershipID.Text))
                {
                    CBMembership.Items.Remove(Temp.MembershipName);
                    Currentvar.MemberShipFunctions.Remove(Temp);
                    break;
                }
            }
            Currentvar.MemberShipFunctions.Add(Mem);
            CBMembership.Items.Add(Mem.MembershipName);
            CBMembership.SelectedIndex = 0;
            TXTMembershipName.Text = "";
            TXTMembershipParameters.Text = "";
            LblMembershipID.Text = (CBMembership.Items.Count + 1).ToString();
        }
    }
}
