using NerveEngineHub;
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
        /*public FormSplash formSplash;*/
        public FormMain()
        {
            this.Visible= false;
            InitializeComponent();
            this.Hide();
            timerhide.Start();
            /*formSplash = new FormSplash();
            formSplash.Show();*/
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
        public PageNewProject pageNewProject=null;

        private void PageNewProject_Disposed(object sender, EventArgs e)
        {
            panel1.Show();
            pageNewProject.Disposed-= PageNewProject_Disposed;
            GC.SuppressFinalize(pageNewProject);
            pageNewProject = null;
        }

        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            if (this.pageNewProject == null)
            {
                this.pageNewProject = new PageNewProject()
                {
                    Dock = DockStyle.Fill
                };
                pageNewProject.Disposed += PageNewProject_Disposed;
                this.Controls.Add(this.pageNewProject);
                pageNewProject.Show();
                pageNewProject.BringToFront();
            }
        }

        private void buttonOpenProject_Click(object sender, EventArgs e)
        {
            panelListProjects.Controls.Add(new Projectsitem()
            {
                Dock = DockStyle.Top
            });
        }
    }
}
