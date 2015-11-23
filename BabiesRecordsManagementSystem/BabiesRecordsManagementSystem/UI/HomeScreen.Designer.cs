namespace BabiesRecordsManagementSystem.UI
{
    partial class HomeScreen
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.babiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importBabiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBabiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popularirtyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.babiesToolStripMenuItem,
            this.searchToolStripMenuItem1,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // babiesToolStripMenuItem
            // 
            this.babiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importBabiesToolStripMenuItem});
            this.babiesToolStripMenuItem.Name = "babiesToolStripMenuItem";
            this.babiesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.babiesToolStripMenuItem.Text = "&Babies";
            // 
            // importBabiesToolStripMenuItem
            // 
            this.importBabiesToolStripMenuItem.Name = "importBabiesToolStripMenuItem";
            this.importBabiesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.importBabiesToolStripMenuItem.Text = "Import new babies ";
            this.importBabiesToolStripMenuItem.Click += new System.EventHandler(this.importBabiesToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBabiesToolStripMenuItem,
            this.popularirtyToolStripMenuItem});
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem1.Text = "Search";
            // 
            // searchBabiesToolStripMenuItem
            // 
            this.searchBabiesToolStripMenuItem.Name = "searchBabiesToolStripMenuItem";
            this.searchBabiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchBabiesToolStripMenuItem.Text = "Search Babies";
            this.searchBabiesToolStripMenuItem.Click += new System.EventHandler(this.searchBabiesToolStripMenuItem_Click);
            // 
            // popularirtyToolStripMenuItem
            // 
            this.popularirtyToolStripMenuItem.Name = "popularirtyToolStripMenuItem";
            this.popularirtyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.popularirtyToolStripMenuItem.Text = "Popularity";
            this.popularirtyToolStripMenuItem.Click += new System.EventHandler(this.popularirtyToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "HomeScreen";
            this.Text = "Babies Name Popularity System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem babiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importBabiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchBabiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popularirtyToolStripMenuItem;
    }
}



