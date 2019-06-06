using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADS_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convertbtn_Click(object sender, EventArgs e)
        {
            Modules M = new Modules();
            Resultlbl.Text = M.ConvertToFully(ExpressionTextBox.Text);
        }

        private void Evaluatebtn_Click(object sender, EventArgs e)
        {
            Modules M=new Modules();
            Evaluatelbl.Text = Convert.ToString(M.Evaluate(M.ConvertToFully(ExpressionTextBox.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modules M = new Modules();
            PostFixlbl.Text = Convert.ToString(M.ConvertToPostFix(M.ConvertToFully(ExpressionTextBox.Text)));
        }
    }
}