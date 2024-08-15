using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeConverter
{
    public partial class volumeConverter : Form
    {
        public volumeConverter()
        {
            InitializeComponent();
            literTextBox.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void literTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            float cl;
            float liter;
            cl= Convert.ToInt32(clTextBox.Text);
            liter = cl / 100;
            literTextBox.Text = (liter.ToString());   

        }

        private void clTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clTextBox.Text = "";
            literTextBox.Text = "";

        }
    }
}
