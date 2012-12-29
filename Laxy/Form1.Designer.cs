namespace Laxy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.debuglabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_tast = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorModusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktuellesLevelSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_mouse = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_oCount = new System.Windows.Forms.Label();
            this.panel = new Laxy.PanelDB();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // debuglabel
            // 
            this.debuglabel.AutoSize = true;
            this.debuglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debuglabel.Location = new System.Drawing.Point(447, 9);
            this.debuglabel.Name = "debuglabel";
            this.debuglabel.Size = new System.Drawing.Size(69, 13);
            this.debuglabel.TabIndex = 1;
            this.debuglabel.Text = "debuglabel";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.OnTimer);
            // 
            // timer_tast
            // 
            this.timer_tast.Interval = 1000;
            this.timer_tast.Tick += new System.EventHandler(this.timer_tast_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem,
            this.hinzufügenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(127, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.level1ToolStripMenuItem,
            this.level2ToolStripMenuItem,
            this.editorModusToolStripMenuItem,
            this.aktuellesLevelSpeichernToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "Spiel";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // level1ToolStripMenuItem
            // 
            this.level1ToolStripMenuItem.Name = "level1ToolStripMenuItem";
            this.level1ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.level1ToolStripMenuItem.Text = "Level 1";
            this.level1ToolStripMenuItem.Click += new System.EventHandler(this.level1ToolStripMenuItem_Click);
            // 
            // level2ToolStripMenuItem
            // 
            this.level2ToolStripMenuItem.Name = "level2ToolStripMenuItem";
            this.level2ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.level2ToolStripMenuItem.Text = "Level 2";
            this.level2ToolStripMenuItem.Click += new System.EventHandler(this.level2ToolStripMenuItem_Click);
            // 
            // editorModusToolStripMenuItem
            // 
            this.editorModusToolStripMenuItem.Name = "editorModusToolStripMenuItem";
            this.editorModusToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.editorModusToolStripMenuItem.Text = "Editor Modus";
            this.editorModusToolStripMenuItem.Click += new System.EventHandler(this.editorModusToolStripMenuItem_Click);
            // 
            // aktuellesLevelSpeichernToolStripMenuItem
            // 
            this.aktuellesLevelSpeichernToolStripMenuItem.Name = "aktuellesLevelSpeichernToolStripMenuItem";
            this.aktuellesLevelSpeichernToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.aktuellesLevelSpeichernToolStripMenuItem.Text = "Aktuelles Level speichern";
            this.aktuellesLevelSpeichernToolStripMenuItem.Click += new System.EventHandler(this.aktuellesLevelSpeichernToolStripMenuItem_Click);
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.hinzufügenToolStripMenuItem.Text = "abbrechen";
            this.hinzufügenToolStripMenuItem.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem_Click);
            // 
            // lbl_mouse
            // 
            this.lbl_mouse.AutoSize = true;
            this.lbl_mouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mouse.Location = new System.Drawing.Point(349, 9);
            this.lbl_mouse.Name = "lbl_mouse";
            this.lbl_mouse.Size = new System.Drawing.Size(63, 13);
            this.lbl_mouse.TabIndex = 3;
            this.lbl_mouse.Text = "lbl_mouse";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(286, 9);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(48, 13);
            this.lbl_info.TabIndex = 4;
            this.lbl_info.Text = "lbl_info";
            // 
            // lbl_oCount
            // 
            this.lbl_oCount.AutoSize = true;
            this.lbl_oCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oCount.Location = new System.Drawing.Point(239, 9);
            this.lbl_oCount.Name = "lbl_oCount";
            this.lbl_oCount.Size = new System.Drawing.Size(64, 13);
            this.lbl_oCount.TabIndex = 6;
            this.lbl_oCount.Text = "obstCount";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.MaximumSize = new System.Drawing.Size(620, 560);
            this.panel.MinimumSize = new System.Drawing.Size(620, 560);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(620, 560);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPanelPaint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseClick);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 590);
            this.Controls.Add(this.lbl_oCount);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_mouse);
            this.Controls.Add(this.debuglabel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LAXY - The Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnFormKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnFormKeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label debuglabel;
        private PanelDB panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_tast;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.Label lbl_mouse;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ToolStripMenuItem level2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorModusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktuellesLevelSpeichernToolStripMenuItem;
        private System.Windows.Forms.Label lbl_oCount;
    }
}

