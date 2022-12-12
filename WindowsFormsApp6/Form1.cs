using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChangedradioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                MessageBox.Show("неправильно");
            if (radioButton2.Checked == true)
                MessageBox.Show("неправильно");
            if (radioButton3.Checked == true)
                MessageBox.Show("правильно");
            if (radioButton4.Checked == true)
                MessageBox.Show("неправильно");



        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
                MessageBox.Show("правильно");
            if (radioButton8.Checked == true)
                MessageBox.Show("правильно");
            if (radioButton9.Checked == true)
                MessageBox.Show("правильно");
            if (radioButton10.Checked == true)
                MessageBox.Show("правильно");
            if (radioButton11.Checked == true)
                MessageBox.Show("правильно");
        }
    }
}
