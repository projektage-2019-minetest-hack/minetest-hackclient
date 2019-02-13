namespace HackClient
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Set_HP = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LHP = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lHPOffset = new System.Windows.Forms.Label();
            this.L_HpValue = new System.Windows.Forms.Label();
            this.E_HP_Offset = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(82, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // Set_HP
            // 
            this.Set_HP.Location = new System.Drawing.Point(221, 25);
            this.Set_HP.Name = "Set_HP";
            this.Set_HP.Size = new System.Drawing.Size(75, 23);
            this.Set_HP.TabIndex = 2;
            this.Set_HP.Text = "Setze HP";
            this.Set_HP.UseVisualStyleBackColor = true;
            this.Set_HP.Click += new System.EventHandler(this.Set_HP_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 424);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.L_HpValue);
            this.tabPage1.Controls.Add(this.LHP);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.Set_HP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LHP
            // 
            this.LHP.AutoSize = true;
            this.LHP.Location = new System.Drawing.Point(6, 27);
            this.LHP.Name = "LHP";
            this.LHP.Size = new System.Drawing.Size(25, 13);
            this.LHP.TabIndex = 4;
            this.LHP.Text = "HP:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.E_HP_Offset);
            this.tabPage2.Controls.Add(this.lHPOffset);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Back Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lHPOffset
            // 
            this.lHPOffset.AutoSize = true;
            this.lHPOffset.Location = new System.Drawing.Point(20, 22);
            this.lHPOffset.Name = "lHPOffset";
            this.lHPOffset.Size = new System.Drawing.Size(53, 13);
            this.lHPOffset.TabIndex = 0;
            this.lHPOffset.Text = "HP Offset";
            // 
            // L_HpValue
            // 
            this.L_HpValue.AutoSize = true;
            this.L_HpValue.Location = new System.Drawing.Point(37, 27);
            this.L_HpValue.Name = "L_HpValue";
            this.L_HpValue.Size = new System.Drawing.Size(16, 13);
            this.L_HpValue.TabIndex = 5;
            this.L_HpValue.Text = "---";
            // 
            // E_HP_Offset
            // 
            this.E_HP_Offset.Location = new System.Drawing.Point(79, 19);
            this.E_HP_Offset.Name = "E_HP_Offset";
            this.E_HP_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_HP_Offset.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Set_HP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LHP;
        private System.Windows.Forms.Label lHPOffset;
        private System.Windows.Forms.Label L_HpValue;
        private System.Windows.Forms.TextBox E_HP_Offset;
    }
}

