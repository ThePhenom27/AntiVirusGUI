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
            int scanMode = 0;
            customTex = 0;
            customColor = 0;
            IMG = 0;
            // change these to modify the GUI.
            if (customTex == 1)
            {
                TextSkin();
            }
            if (customColor == 1)
            {
                // throw new NotImplementedException();
                colorSkin();
            }
            if (IMG == 1)
            {
                //  throw new NotImplementedException();
                enableIMG();
            }
        }
        private void TextSkin()
        {
            Form1.ActiveForm.Text = "";
            tabPage1.Text = ""; // scan options
            tabPage2.Text = ""; // scan
            tabPage3.Text = ""; // license
            tabPage4.Text = ""; // other
            tabPage5.Text = ""; // about
            label1.Text = ""; // name
            label2.Text = ""; // scan message name
            radioButton1.Text = ""; // scan option 1
            radioButton2.Text = ""; // scan option 2
            radioButton3.Text = ""; // scan option 3
            button1.Text = ""; // scan button

        }
        private void colorSkin()
        {

        }
        private void enableIMG()
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
