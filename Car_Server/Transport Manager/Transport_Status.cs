using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Server
{
    public partial class Transport_Status : Form
    {
        public Transport_Status()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Visible=false;
        }

        private void Transport_Status_Load(object sender, EventArgs e)
        {
            LoadValues();
            cboBaud.Text = MainForm.Communicator.BaudRate;
            cboData.Text = MainForm.Communicator.DataBits;
            cboPort.Text = MainForm.Communicator.PortName;
            cboStop.Text = MainForm.Communicator.StopBits;
            cboParity.Text = MainForm.Communicator.Parity;
            if (MainForm.Communicator.CurrentTransmissionType == Serial_Communication.CommunicationManager.TransmissionType.Hex)
                rdoHex.Checked = true;
            else
                rdoText.Checked = true;
            if (MainForm.Communicator.PortState)
            {
                LblVariableName.Text = "Connected";
                LblVariableName.ForeColor = Color.Green;
                BtnOpenChannel.Enabled = false;
                BtnCLoseChannel.Enabled = true;
            }
        }

        public void LoadValues()
        {
            cboPort.Items.Clear();
            cboParity.Items.Clear();
            cboStop.Items.Clear();
            MainForm.Communicator.DisplayWindow = RTBTraffic;
            MainForm.Communicator.SetPortNameValues(cboPort);
            MainForm.Communicator.SetParityValues(cboParity);
            MainForm.Communicator.SetStopBitValues(cboStop);
        }

        public void BtnOpenChannel_Click(object sender, EventArgs e)
        {
            if (MainForm.Communicator.OpenPort())
            {
                LblVariableName.Text = "Connected";
                LblVariableName.ForeColor = Color.Green;
                BtnOpenChannel.Enabled = false;
                BtnCLoseChannel.Enabled = true;
                MainForm.StatusMSG = "Server has been connected successfully to serial port.";
                MainForm.SEL.LBEvents.Items.Add("Connected to serial port successfully.  " + DateTime.Now.ToString());
            }
            else
            {
                MainForm.StatusMSG = "Failed in connecting to serial port.";
                MainForm.SEL.LBEvents.Items.Add("Failed in connecting to serial port.  " + DateTime.Now.ToString());
            }
        }

        public void BtnCLoseChannel_Click(object sender, EventArgs e)
        {
            MainForm.Communicator.ClosePort();
           LblVariableName.Text = "Disconnected";
           LblVariableName.ForeColor = Color.Red;
           BtnOpenChannel.Enabled = true;
           BtnCLoseChannel.Enabled = false;
           MainForm.StatusMSG = "Server has been Disconnected successfully from serial port.";
           MainForm.SEL.LBEvents.Items.Add("Disconnect serial port successfully.  " + DateTime.Now.ToString());
        }

        private void BtnShowTraffic_Click(object sender, EventArgs e)
        {
            RTBTraffic.Enabled = true;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            if(rdoHex.Checked)
                MainForm.Communicator.ApplyChanges(cboBaud.Text, cboParity.Text, cboStop.Text, cboData.Text, cboPort.Text, Serial_Communication.CommunicationManager.TransmissionType.Hex);
            else
                MainForm.Communicator.ApplyChanges(cboBaud.Text, cboParity.Text, cboStop.Text, cboData.Text, cboPort.Text, Serial_Communication.CommunicationManager.TransmissionType.Text);
        }

        private void rdoHex_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoHex.Checked)
                MainForm.Communicator.ApplyChanges(cboBaud.Text, cboParity.Text, cboStop.Text, cboData.Text, cboPort.Text, Serial_Communication.CommunicationManager.TransmissionType.Hex);
        }

        private void rdoText_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoText.Checked)
                MainForm.Communicator.ApplyChanges(cboBaud.Text, cboParity.Text, cboStop.Text, cboData.Text, cboPort.Text, Serial_Communication.CommunicationManager.TransmissionType.Text);
        }
        
    }
}
