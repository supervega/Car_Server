using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FuzzyLogic_Unit;
using ES_Lib;

namespace Car_Server
{
    public partial class Console_Interface : Form
    {
        public Core Core_Unit_Ref;

        public Console_Interface()
        {
            InitializeComponent();
        }

        private void RTBConsole_TextChanged(object sender, EventArgs e)
        {

        }

        private void Console_Interface_Load(object sender, EventArgs e)
        {
            RTBConsole.Text += ">>";
        }

        private void RTBConsole_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RTBConsole.Text += "\n>>";
                RTBConsole.Select(RTBConsole.Text.Length, RTBConsole.Text.Length);
            }
            if (e.KeyCode == Keys.F5)
            {                
                //Core_Unit_Ref.Main = new Project("Car Expert unit");
                Core_Unit_Ref.ErrorDGV = new DataGridView();
                Core_Unit_Ref.Main.ErrorExplorerRef = Core_Unit_Ref.ErrorDGV;
                Core_Unit_Ref.Main.TExtRef = RTBConsole;
                string[] Data = RTBConsole.Text.Split('\n');
                for (int i = Core_Unit_Ref.LineIndex; i < Data.Length; i++)
                {
                    if (Data[i].Length > 2 && Data[i][0] == '>' && Data[i][1] == '>')
                        Data[i] = Data[i].Substring(2, Data[i].Length - 2);
                    else
                        Data[i] = "";
                }
                Node Root = new Node();
                Root.NodeKind = "Main";
                Root.isInitial = true;
                Root.Value = ".";
                Core_Unit_Ref.Main.ASTDrawRoot = new Node();
                Core_Unit_Ref.Main.ASTDrawRoot.NodeKind = "Main";
                Core_Unit_Ref.Main.ASTDrawRoot.isInitial = true;
                foreach (ES_Lib.Rule R in Core_Unit_Ref.System_Rules)
	            {
                    Core_Unit_Ref.Main.Rules.Add(R);
	            }
                foreach (Fact F in Core_Unit_Ref.System_Facts)
                {
                    Core_Unit_Ref.Main.Facts.Add(F);
                }
                Core_Unit_Ref.Main.RuleCount = Core_Unit_Ref.RuleCount;
                for (int i = Core_Unit_Ref.LineIndex; i < Data.Length; i++)
                {
                    if (Data[i] != "" && Data[i] != ">>")
                    {
                        Core_Unit_Ref.Main.GET_AST(Data[i], i + 1);
                        Node Temp = new Node();
                        Root.NodeKind = "Main";
                        Temp.nextstates.Add(Core_Unit_Ref.Main.ParseRoot);
                        Core_Unit_Ref.Main.RUN(Temp, 0);
                        Root.nextstates.Add(Core_Unit_Ref.Main.ParseRoot);
                        Core_Unit_Ref.Main.ASTDrawRoot.nextstates.Add(Core_Unit_Ref.Main.ParseRoot);
                        Core_Unit_Ref.Main.DoChaining();
                    }
                }
                Core_Unit_Ref.RuleCount += Core_Unit_Ref.Main.RuleCount-Core_Unit_Ref.RuleCount;
                Core_Unit_Ref.System_Rules = new System.Collections.ArrayList();
                Core_Unit_Ref.System_Facts = new System.Collections.ArrayList();
                foreach (ES_Lib.Rule R in Core_Unit_Ref.Main.Rules)
                {
                    Core_Unit_Ref.System_Rules.Add(R);
                }
                foreach (Fact F in Core_Unit_Ref.Main.Facts)
                {
                    Core_Unit_Ref.System_Facts.Add(F);
                }
                Core_Unit_Ref.Main.ParseRoot = Root;
                Data = RTBConsole.Text.Split('\n');
                Core_Unit_Ref.LineIndex = Data.Length;
                RTBConsole.Text += "\n>>";
                RTBConsole.Select(RTBConsole.Text.Length, RTBConsole.Text.Length);
            }
        }
    }
}
