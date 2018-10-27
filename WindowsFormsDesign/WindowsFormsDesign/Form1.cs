using System;
using System.Windows.Forms;

namespace WindowsFormsDesign {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            label1.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "button was pressed!";
        }
    }
}
