using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AntiVirusGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int customTex = 0;
            int customColor = 0;
            int IMG = 0;

        }
        private void TextSkin()
        {
            Form1.ActiveForm.Text = "";
            tabPage1.Text = "";
            tabPage2.Text = "";
            tabPage3.Text = "";
            tabPage4.Text = "";
            tabPage5.Text = "";
            label1.Text = "";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
