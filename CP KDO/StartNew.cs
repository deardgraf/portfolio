using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_KDO
{
    public partial class StartNew : Form
    {
        bool clicked = false;
        bool canceled = false;
        public StartNew()
        {
            InitializeComponent();
            MaximizeBox = false;
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
        }
        
        public string Name1
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Name2
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public bool Clicked
        {
            get { return clicked; }
            set { clicked = value; }
        }
        public bool Canceled
        {
            get { return canceled; }
            set { canceled = value; }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }
        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox2.Text)
            {
                Clicked = true;
                Hide();
            }
            else MessageBox.Show($"Імена гравців не можуть співпадати", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void canc_Click(object sender, EventArgs e)
        {
            Canceled = true;
            Hide();
        }
        private void StartNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}