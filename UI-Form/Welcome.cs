using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI_Form
{
    public partial class WelForm : Form
    {
        public WelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Create o = new Create();
            o.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Update p = new Update();
            p.Show();
        }

        private void WelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
