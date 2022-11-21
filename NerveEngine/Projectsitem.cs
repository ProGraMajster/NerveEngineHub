using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerveEngineHub
{
    public partial class Projectsitem : UserControl
    {
        public Projectsitem()
        {
            InitializeComponent();
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(this.Width, 55);
        }

        private void Projectsitem_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(this.Width, 55);
            this.labelStar.Size = new System.Drawing.Size(55, 55);
            this.labelName.Size = new System.Drawing.Size(285, 55);
            this.labelModified.Size = new System.Drawing.Size(149, 55);
            this.labelEditorVersion.Size = new System.Drawing.Size(149, 55);
            this.Size = new System.Drawing.Size(this.Width, 55);
        }

        private void labelStar_Click(object sender, EventArgs e)
        {
            if(labelStar.Text == "🟊")
            {
                labelStar.Text = "";
            }
            else
            {
                labelStar.Text = "🟊";
            }
        }
    }
}
