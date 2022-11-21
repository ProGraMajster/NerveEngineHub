namespace NerveEngineHub
{
    partial class Projectsitem
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelStar = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelModified = new System.Windows.Forms.Label();
            this.labelEditorVersion = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelStar
            // 
            this.labelStar.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStar.Location = new System.Drawing.Point(0, 0);
            this.labelStar.MaximumSize = new System.Drawing.Size(55, 55);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(55, 55);
            this.labelStar.TabIndex = 2;
            this.labelStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStar.Click += new System.EventHandler(this.labelStar_Click);
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(55, 0);
            this.labelName.MaximumSize = new System.Drawing.Size(285, 55);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelName.Size = new System.Drawing.Size(285, 55);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "NAME";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelModified
            // 
            this.labelModified.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelModified.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModified.Location = new System.Drawing.Point(340, 0);
            this.labelModified.MaximumSize = new System.Drawing.Size(149, 55);
            this.labelModified.Name = "labelModified";
            this.labelModified.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelModified.Size = new System.Drawing.Size(149, 55);
            this.labelModified.TabIndex = 4;
            this.labelModified.Text = "MODIFIED";
            this.labelModified.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEditorVersion
            // 
            this.labelEditorVersion.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelEditorVersion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEditorVersion.Location = new System.Drawing.Point(489, 0);
            this.labelEditorVersion.MaximumSize = new System.Drawing.Size(149, 55);
            this.labelEditorVersion.Name = "labelEditorVersion";
            this.labelEditorVersion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelEditorVersion.Size = new System.Drawing.Size(149, 55);
            this.labelEditorVersion.TabIndex = 6;
            this.labelEditorVersion.Text = "EDITOR VERSION";
            this.labelEditorVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPath
            // 
            this.labelPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPath.Location = new System.Drawing.Point(638, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelPath.Size = new System.Drawing.Size(54, 55);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "PATH";
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Projectsitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelEditorVersion);
            this.Controls.Add(this.labelModified);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(2000, 55);
            this.Name = "Projectsitem";
            this.Size = new System.Drawing.Size(692, 55);
            this.Load += new System.EventHandler(this.Projectsitem_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Label labelStar;
        private Label labelName;
        private Label labelModified;
        private Label labelEditorVersion;
        private Label labelPath;
        private System.Windows.Forms.Timer timer1;
    }
}
