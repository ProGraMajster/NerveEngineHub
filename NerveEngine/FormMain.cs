using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerveEngine
{
    public partial class FormMain : Form
    {
        public FormSplash formSplash;
        public FormMain()
        {
            this.Visible= false;
            InitializeComponent();
            this.Hide();
            timerhide.Start();
            formSplash = new FormSplash();
            formSplash.Show();
            this.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timerhide.Stop();
            this.Show();
        }

        private void timerhide_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
