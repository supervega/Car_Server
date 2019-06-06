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
    public partial class Inference_Tracer : Form
    {
        public Core Core_Ref;

        public Inference_Tracer()
        {
            InitializeComponent();
        }

        private void Inference_Tracer_Load(object sender, EventArgs e)
        {            
            Core_Ref.VariablesPB = PBTracing;
            Core_Ref.LBFiredRules = LBFiredRules;
            Core_Ref.G = PContainer.CreateGraphics();
            if (Core_Ref.VariablesCount == 0)
                Core_Ref.LoadVariablesData();
            Core_Ref.InitilizeInferenceDrawing();
            MainForm.RunInferenceTracer = true;
        }

        private void BtnDrawAST_Click(object sender, EventArgs e)
        {
            MainForm.Core_unit.DrawAST();
        }

        private void Inference_Tracer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Core_Ref.DrawFlag = false;
            MainForm.RunInferenceTracer = false;            
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (Core_Ref.DrawingIndex - 1 >= 0)
                Core_Ref.DrawingIndex--;
            Core_Ref.InitilizeInferenceDrawing();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (Core_Ref.DrawingIndex + 1 < Core_Ref.VariablesCount)
                Core_Ref.DrawingIndex++;
            Core_Ref.InitilizeInferenceDrawing();
        }
    }
}
