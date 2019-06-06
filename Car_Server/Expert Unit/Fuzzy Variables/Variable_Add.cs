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
    public partial class Variable_Add : Form
    {
        public Core Core_Unit_Ref;
        private Variable CurrentVar;


        public Variable_Add()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddVariable_Click(object sender, EventArgs e)
        {
            CurrentVar.VariableName = TXTVariableName.Text;
            if (CBVariableType.Text.ToLower() == "input")
                CurrentVar.VariableType = Variable.VarType.Input;
            if (CBVariableType.Text.ToLower() == "output")
                CurrentVar.VariableType = Variable.VarType.Output;
            CurrentVar.VariableRange = new Range((float)Convert.ToDouble(NUDFrom.Value), (float)Convert.ToDouble(NUDTo.Value));
            CurrentVar.Perfect_Value = (int)NUDMid.Value;
            CurrentVar.CSS=(int)NUDCentroid_Step_Size.Value;
            string Result=Core_Unit_Ref.AddVariable(CurrentVar);
            if (Result == "")
                ClearComponents();
            else
            {
                MainForm.StatusMSG = Result;
                MainForm.SEL.LBEvents.Items.Add(Result + "  " + DateTime.Now.ToString());
            }
        }

        private void Variable_Add_Load(object sender, EventArgs e)
        {
            CurrentVar = new Variable();
            Core_Unit_Ref.LoadVariablesData();
        }

        private void BtnAddMembership_Click(object sender, EventArgs e)
        {            
            LblMembershipID.Text=(CBMembership.Items.Count+1).ToString();
            Membership Mem = new Membership();
            Mem.MID = Convert.ToInt32(LblMembershipID.Text);
            Mem.MembershipName = TXTMembershipName.Text;
            string[] Points = TXTMembershipParameters.Text.Split(new char[] { '-', '/', ',', ' ' });
            Mem.MembershipParameters=new List<int>();
            foreach (string str in Points)
            {
                Mem.MembershipParameters.Add(Convert.ToInt32(str));
            }
            CurrentVar.MemberShipFunctions.Add(Mem);
            CBMembership.Items.Add(Mem.MembershipName);
            TXTMembershipName.Text = "";
            TXTMembershipParameters.Text = "";
            LblMembershipID.Text = (CBMembership.Items.Count + 1).ToString();
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
        }

        private void CBMembership_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Membership Mem in CurrentVar.MemberShipFunctions)
            {
                if (Mem.MembershipName == CBMembership.SelectedItem.ToString())
                {
                    BtnAddMembership.Enabled = false;
                    BtnModify.Enabled = true;
                    LblMembershipID.Text = Mem.MID.ToString();
                    TXTMembershipName.Text = Mem.MembershipName;
                    foreach (int Val in Mem.MembershipParameters)
                    {
                        TXTMembershipParameters.Text += Val + ",";
                    }
                    TXTMembershipParameters.Text = TXTMembershipParameters.Text.Substring(0, TXTMembershipParameters.Text.Length - 1);
                }
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            BtnAddMembership.Enabled = false;
            BtnModify.Enabled = true;
            Membership Mem = new Membership();
            Mem.MID = Convert.ToInt32(LblMembershipID.Text);
            Mem.MembershipName = TXTMembershipName.Text;
            string[] Points = TXTMembershipParameters.Text.Split(new char[] { '-', '/', ',', ' ' });
            Mem.MembershipParameters=new List<int>();
            foreach (string str in Points)
            {
                Mem.MembershipParameters.Add(Convert.ToInt32(str));
            }
            for (int i = 0; i < CurrentVar.MemberShipFunctions.Count; i++)
            {
                Membership Temp = (Membership)CurrentVar.MemberShipFunctions[i];
                if (Temp.MID == Convert.ToInt32(LblMembershipID.Text))
                {
                    CBMembership.Items.Remove(Temp.MembershipName);
                    CurrentVar.MemberShipFunctions.Remove(Temp);
                    break;
                }
            }
            CurrentVar.MemberShipFunctions.Add(Mem);
            CBMembership.Items.Add(Mem.MembershipName);
            TXTMembershipName.Text = "";
            TXTMembershipParameters.Text = "";
            LblMembershipID.Text = (CBMembership.Items.Count + 1).ToString();
        }
    }
}
