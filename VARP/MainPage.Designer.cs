namespace VARP
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.RollingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QTBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntermediateShearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dividingShearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RollingDataToolStripMenuItem,
            this.QTBToolStripMenuItem,
            this.IntermediateShearToolStripMenuItem,
            this.dividingShearToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // RollingDataToolStripMenuItem
            // 
            this.RollingDataToolStripMenuItem.Name = "RollingDataToolStripMenuItem";
            this.RollingDataToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.RollingDataToolStripMenuItem.Text = "Rolling Data";
            this.RollingDataToolStripMenuItem.Click += new System.EventHandler(this.RollingDataToolStripMenuItem_Click);
            // 
            // QTBToolStripMenuItem
            // 
            this.QTBToolStripMenuItem.Name = "QTBToolStripMenuItem";
            this.QTBToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.QTBToolStripMenuItem.Text = "QTB";
            this.QTBToolStripMenuItem.Click += new System.EventHandler(this.QTBToolStripMenuItem_Clock);
            // 
            // IntermediateShearToolStripMenuItem
            // 
            this.IntermediateShearToolStripMenuItem.Name = "IntermediateShearToolStripMenuItem";
            this.IntermediateShearToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.IntermediateShearToolStripMenuItem.Text = "Intermediate Shear";
            this.IntermediateShearToolStripMenuItem.Click += new System.EventHandler(this.IntermediateShearToolStripMenuItem_Click);
            // 
            // dividingShearToolStripMenuItem
            // 
            this.dividingShearToolStripMenuItem.Name = "dividingShearToolStripMenuItem";
            this.dividingShearToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.dividingShearToolStripMenuItem.Text = "Dividing Shear";
            this.dividingShearToolStripMenuItem.Click += new System.EventHandler(this.dividingShearToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainPage";
            this.Text = "T W S";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem RollingDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QTBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IntermediateShearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dividingShearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}



