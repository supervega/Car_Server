using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FuzzyLogic_Unit;
using System.Threading;
using Serial_Communication;
using _3D_Control_Interface;
using Microsoft.Win32;

namespace Car_Server
{
    public partial class MainForm : Form
    {
        public static Core Core_unit;
        public static Main_Interface NN_Core_Unit;
        public Thread InferenceThread;
        public static bool RunInferenceTracer = false;
        public float Ultra_Distance=10;
        public static CommunicationManager Communicator;
        public static System_Event_Log SEL;
        private Transport_Status Ts;
        private Console_Interface CI;
        private Random R;
        public static Control_User CurrentUser;
        public static test InvisiblePreview;

        private Thread StatusThread;
        public static string StatusMSG = "";

        public MainForm()
        {
            InitializeComponent();
        }


        public void RunInference()
        {
            while (true)
            {
                //if (Communicator.PortState)
                //{                 
                    
                    //int num = Int32.Parse(CommunicationManager.CurrentHex.Split(' ')[0], System.Globalization.NumberStyles.HexNumber);
                    float num = (float)R.NextDouble() * 100 / 3;                   
                    CommunicationManager.CurrentHex = "";
                    //Core_unit.Run_Distance_acceleration(new float[]{num}, RunInferenceTracer);
                    //Communicator.WriteData(Res.ToString());                    
                    Thread.Sleep(10);
                //}
            }
        }

        private void carStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car_Status C_Stat = new Car_Status();
            C_Stat.Show();
        }

        private void openControlInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.StatusMSG = "3D engine initilized..";
            MainForm.SEL.LBEvents.Items.Add("3D engine initilized...  " + DateTime.Now.ToString());
            Scene M = new Scene();
        }

        private void showVariablesCurvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fuzzy_Variable_Visualizer FVV = new Fuzzy_Variable_Visualizer();
            FVV.MdiParent = this;
            Core_unit.InitilizeCore(Application.StartupPath);
            FVV.Core_Unit_Ref = Core_unit;
            Core_unit.VariablesPB = FVV.PBVariables;
            FVV.Show();
            Core_unit.DrawVariable("delta",false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TimerStatusBar.Start();
            SEL = new System_Event_Log();
            SEL.Show();
            SEL.Visible = false;
            SEL.LBEvents.Items.Add("System Event log initilized.  " + DateTime.Now.ToString());
            CheckRegistry();
            //if (DBConnection.checkInfo())
            //    Application.Exit();
            //else
            //    DBConnection.InitilizeConnection();
            CurrentUser = new Control_User();
            StatusThread = new Thread(new ThreadStart(StatusCheck));
            StatusThread.Start();            
            CI = new Console_Interface();
            CI.Dock = DockStyle.Top;
            CI.VisibleChanged += new EventHandler(OnConsole_Visibility_Changed);
            CI.MdiParent = this;
            CI.Show();
            CI.Visible = false;
            Core_unit = new Core(Application.StartupPath);
            Core_unit.Main.TExtRef = CI.RTBConsole;
            CI.Core_Unit_Ref = Core_unit;          
            Core_unit.CompileCode();
            Communicator = new CommunicationManager();
            Ts = new Transport_Status();
            Ts.Show();
            Ts.Visible = false;
            Core_unit.LoadVariablesData();
            InferenceThread = new Thread(new ThreadStart(RunInference));
            //InferenceThread.Start();//must be started and aborted from the channel controller
            CommunicationManager.CurrentHex = "13";
            R = new Random();
            InvisiblePreview = new test();
        }

        private void CheckRegistry()
        {
            try
            {
                RegistryKey rk2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SUPERVEGA", true);
                if (rk2.GetValue("SUPERVEGA_DBusr") != null)
                {
                    DBConnection.DBUserName = rk2.GetValue("SUPERVEGA_DBusr").ToString();
                    DBConnection.DBPassword = rk2.GetValue("SUPERVEGA_DBpwd").ToString();
                    DBConnection.DBName = rk2.GetValue("SUPERVEGA_DBname").ToString();
                    DBConnection.HostName = rk2.GetValue("SUPERVEGA_Network").ToString();
                    DBConnection.DBServerName= rk2.GetValue("SUPERVEGA_DBserver").ToString();
                }
                rk2.Close();
            }
            catch (Exception ex)
            {
                SystemInitializer FI = new SystemInitializer();
                FI.StartPosition = FormStartPosition.CenterScreen;
                FI.ShowDialog();
            }


        }

        public void OnConsole_Visibility_Changed(object sender,EventArgs e)
        {
            if (CI.Visible)
            {
                CI.Size = new Size(CI.Size.Width, 0);
            }
        }

        public void StatusCheck()
        {
            while (true)
            {
                TSStatusMSG.Text = StatusMSG;
                Thread.Sleep(1000);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variable_Add VA = new Variable_Add();
            VA.Core_Unit_Ref = Core_unit;
            VA.Show();
        }

        private void goLiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\cec\\Desktop\\FinalObjectTracking\\FinalObjectTracking\\bin\\Debug\\FinalObjectTracking.exe");
            /*
            Live_Video LV = new Live_Video();
            //LV.MdiParent = this;
            LV.StartPosition = FormStartPosition.CenterScreen;
            LV.Show();
             */
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerStatusBar.Stop();
            if (SEL.CBExportAutomatically.Checked)
                SEL.SaveLog(Application.StartupPath+"\\SystemLog.log");
            if (InferenceThread.IsAlive)
                InferenceThread.Abort();
            if (StatusThread.IsAlive)
                StatusThread.Abort();
            Core_unit.Dispose();
        }

        private void inferenceTracerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Show = true;
            foreach (Form F in this.MdiChildren)
            {
                if (F.Name == "Fuzzy_Variable_Visualizer")
                {
                    Show = false;
                    break;
                }
            }
            if (Show)
            {
                Inference_Tracer IT = new Inference_Tracer();
                IT.MdiParent = this;
                IT.Core_Ref = Core_unit;
                IT.Show();
            }
            else
            {
                MainForm.StatusMSG = "Please Close Variable Visualizer First.";                 
                //Please close Variable Visualizer First.
            }
        }

        private void openChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Ts.BtnOpenChannel_Click(sender, e);
            //After a sccussful connection opening run inference thread
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Ts.MdiParent = this;
            Ts.Visible = true;
        }

        private void closeChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ts.BtnCLoseChannel_Click(sender, e);
            //After a sccussful connection Closing suspend inference thread
        }

        private void dBManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void eventLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEL.Visible = true;
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variable_Modify VM = new Variable_Modify();
            VM.Core_Unit_Ref = Core_unit;
            VM.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variable_Delete VD = new Variable_Delete();
            VD.Core_Unit_Ref = Core_unit;
            VD.Show();
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CI.IsDisposed)
                TimerConsole.Start();
        }

        bool Show = false;
        private void TimerConsole_Tick(object sender, EventArgs e)
        {
            if (CI.Visible && Show)
            {
                CI.Size = new Size(CI.Size.Width, CI.Size.Height - 4);
                if (CI.Size.Height <= 2)
                {
                    Show = false;
                    CI.Visible = false;
                    TimerConsole.Stop();
                }
            }
            else
            {
                CI.Size = new Size(CI.Size.Width, CI.Size.Height + 4);
                CI.Visible = true;
                if (CI.Size.Height >= 400)
                {
                    Show = true;
                    TimerConsole.Stop();
                }
            }
        }

        private void dBControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_Settings DB_Manager = new DB_Settings();
            DB_Manager.MdiParent = this;
            DB_Manager.Show();
        }

        string tempmsg = "";
        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            if (StatusMSG != tempmsg)
                tempmsg = TSStatusMSG.Text;
            else
                StatusMSG = "";
        }

        private void editAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUsers EU = new AddUsers();
            EU.MdiParent = this;
            EU.StartPosition = FormStartPosition.CenterScreen;
            EU.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users US = new Users();
            US.MdiParent = this;
            US.StartPosition = FormStartPosition.CenterScreen;
            US.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in this.MdiChildren)
            {
                F.Close();
            }
            MainForm.SEL.LBEvents.Items.Add(CurrentUser.FullName + " has just sign out.  " + DateTime.Now.ToString());
            MainForm.StatusMSG = CurrentUser.FullName + " has just sign out.  ";
            CurrentUser = new Control_User();
        }

        private void pathControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PathController PathC= new PathController();
            //MF.MdiParent = this;
            PathC.Show();
            //Path_Controller PC = new Path_Controller();
            //PC.MdiParent = this;
            //PC.Show();
        }

        private void neuralNetworkEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NN_Core_Unit = new Main_Interface();
            NN_Core_Unit.StartPosition = FormStartPosition.CenterScreen;
            NN_Core_Unit.Show();
        }

        private void imageProcessingUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }        
    }
}
