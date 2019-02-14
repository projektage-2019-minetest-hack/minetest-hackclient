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
            this.BUT_SaveOffsets = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Check_Immortal = new System.Windows.Forms.CheckBox();
            this.L_HpValue = new System.Windows.Forms.Label();
            this.LHP = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Set_HP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.E_1Item_Offset = new System.Windows.Forms.TextBox();
            this.lFirstItemoffset = new System.Windows.Forms.Label();
            this.E_Z_Offset = new System.Windows.Forms.TextBox();
            this.lzoffset = new System.Windows.Forms.Label();
            this.E_HP_Offset = new System.Windows.Forms.TextBox();
            this.E_Y_Offset = new System.Windows.Forms.TextBox();
            this.lHPOffset = new System.Windows.Forms.Label();
            this.lyOffset = new System.Windows.Forms.Label();
            this.lXoffset = new System.Windows.Forms.Label();
            this.E_X_Offset = new System.Windows.Forms.TextBox();
            this.BUT_PlayerLoad = new System.Windows.Forms.Button();
            this.ComboPlayer = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
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
            // BUT_SaveOffsets
            // 
            this.BUT_SaveOffsets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_SaveOffsets.Location = new System.Drawing.Point(90, 481);
            this.BUT_SaveOffsets.Name = "BUT_SaveOffsets";
            this.BUT_SaveOffsets.Size = new System.Drawing.Size(112, 23);
            this.BUT_SaveOffsets.TabIndex = 2;
            this.BUT_SaveOffsets.Text = "Speicher Offsets";
            this.BUT_SaveOffsets.UseVisualStyleBackColor = true;
            this.BUT_SaveOffsets.Click += new System.EventHandler(this.BUT_SaveOffsets_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(403, 516);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // Check_Immortal
            // 
            this.Check_Immortal.AutoSize = true;
            this.Check_Immortal.Location = new System.Drawing.Point(318, 38);
            this.Check_Immortal.Name = "Check_Immortal";
            this.Check_Immortal.Size = new System.Drawing.Size(57, 17);
            this.Check_Immortal.TabIndex = 16;
            this.Check_Immortal.Text = "Imortal";
            this.Check_Immortal.UseVisualStyleBackColor = true;
            // 
            // L_HpValue
            // 
            this.L_HpValue.AutoSize = true;
            this.L_HpValue.Location = new System.Drawing.Point(43, 39);
            this.L_HpValue.Name = "L_HpValue";
            this.L_HpValue.Size = new System.Drawing.Size(16, 13);
            this.L_HpValue.TabIndex = 15;
            this.L_HpValue.Text = "---";
            // 
            // LHP
            // 
            this.LHP.AutoSize = true;
            this.LHP.Location = new System.Drawing.Point(12, 39);
            this.LHP.Name = "LHP";
            this.LHP.Size = new System.Drawing.Size(25, 13);
            this.LHP.TabIndex = 14;
            this.LHP.Text = "HP:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 37);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // Set_HP
            // 
            this.Set_HP.Location = new System.Drawing.Point(237, 34);
            this.Set_HP.Name = "Set_HP";
            this.Set_HP.Size = new System.Drawing.Size(75, 23);
            this.Set_HP.TabIndex = 13;
            this.Set_HP.Text = "Setze HP";
            this.Set_HP.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.ComboPlayer);
            this.panel1.Controls.Add(this.BUT_PlayerLoad);
            this.panel1.Controls.Add(this.E_1Item_Offset);
            this.panel1.Controls.Add(this.lFirstItemoffset);
            this.panel1.Controls.Add(this.E_Z_Offset);
            this.panel1.Controls.Add(this.lzoffset);
            this.panel1.Controls.Add(this.E_HP_Offset);
            this.panel1.Controls.Add(this.E_Y_Offset);
            this.panel1.Controls.Add(this.lHPOffset);
            this.panel1.Controls.Add(this.lyOffset);
            this.panel1.Controls.Add(this.BUT_SaveOffsets);
            this.panel1.Controls.Add(this.lXoffset);
            this.panel1.Controls.Add(this.E_X_Offset);
            this.panel1.Location = new System.Drawing.Point(409, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 516);
            this.panel1.TabIndex = 17;
            // 
            // E_1Item_Offset
            // 
            this.E_1Item_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_1Item_Offset.Location = new System.Drawing.Point(90, 234);
            this.E_1Item_Offset.Name = "E_1Item_Offset";
            this.E_1Item_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_1Item_Offset.TabIndex = 20;
            // 
            // lFirstItemoffset
            // 
            this.lFirstItemoffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lFirstItemoffset.AutoSize = true;
            this.lFirstItemoffset.Location = new System.Drawing.Point(4, 237);
            this.lFirstItemoffset.Name = "lFirstItemoffset";
            this.lFirstItemoffset.Size = new System.Drawing.Size(80, 13);
            this.lFirstItemoffset.TabIndex = 19;
            this.lFirstItemoffset.Text = "First Item Offset";
            // 
            // E_Z_Offset
            // 
            this.E_Z_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_Z_Offset.Location = new System.Drawing.Point(90, 208);
            this.E_Z_Offset.Name = "E_Z_Offset";
            this.E_Z_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_Z_Offset.TabIndex = 18;
            // 
            // lzoffset
            // 
            this.lzoffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lzoffset.AutoSize = true;
            this.lzoffset.Location = new System.Drawing.Point(4, 211);
            this.lzoffset.Name = "lzoffset";
            this.lzoffset.Size = new System.Drawing.Size(45, 13);
            this.lzoffset.TabIndex = 17;
            this.lzoffset.Text = "Z Offset";
            // 
            // E_HP_Offset
            // 
            this.E_HP_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_HP_Offset.Location = new System.Drawing.Point(90, 130);
            this.E_HP_Offset.Name = "E_HP_Offset";
            this.E_HP_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_HP_Offset.TabIndex = 12;
            // 
            // E_Y_Offset
            // 
            this.E_Y_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_Y_Offset.Location = new System.Drawing.Point(90, 182);
            this.E_Y_Offset.Name = "E_Y_Offset";
            this.E_Y_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_Y_Offset.TabIndex = 16;
            // 
            // lHPOffset
            // 
            this.lHPOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lHPOffset.AutoSize = true;
            this.lHPOffset.Location = new System.Drawing.Point(4, 133);
            this.lHPOffset.Name = "lHPOffset";
            this.lHPOffset.Size = new System.Drawing.Size(53, 13);
            this.lHPOffset.TabIndex = 11;
            this.lHPOffset.Text = "HP Offset";
            // 
            // lyOffset
            // 
            this.lyOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lyOffset.AutoSize = true;
            this.lyOffset.Location = new System.Drawing.Point(4, 185);
            this.lyOffset.Name = "lyOffset";
            this.lyOffset.Size = new System.Drawing.Size(45, 13);
            this.lyOffset.TabIndex = 15;
            this.lyOffset.Text = "Y Offset";
            // 
            // lXoffset
            // 
            this.lXoffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lXoffset.AutoSize = true;
            this.lXoffset.Location = new System.Drawing.Point(4, 159);
            this.lXoffset.Name = "lXoffset";
            this.lXoffset.Size = new System.Drawing.Size(45, 13);
            this.lXoffset.TabIndex = 13;
            this.lXoffset.Text = "X Offset";
            // 
            // E_X_Offset
            // 
            this.E_X_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_X_Offset.Location = new System.Drawing.Point(90, 156);
            this.E_X_Offset.Name = "E_X_Offset";
            this.E_X_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_X_Offset.TabIndex = 14;
            // 
            // BUT_PlayerLoad
            // 
            this.BUT_PlayerLoad.Location = new System.Drawing.Point(136, 8);
            this.BUT_PlayerLoad.Name = "BUT_PlayerLoad";
            this.BUT_PlayerLoad.Size = new System.Drawing.Size(75, 23);
            this.BUT_PlayerLoad.TabIndex = 21;
            this.BUT_PlayerLoad.Text = "Lade Spieler";
            this.BUT_PlayerLoad.UseVisualStyleBackColor = true;
            this.BUT_PlayerLoad.Click += new System.EventHandler(this.BUT_PlayerLoad_Click);
            // 
            // ComboPlayer
            // 
            this.ComboPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPlayer.FormattingEnabled = true;
            this.ComboPlayer.Location = new System.Drawing.Point(9, 8);
            this.ComboPlayer.Name = "ComboPlayer";
            this.ComboPlayer.Size = new System.Drawing.Size(121, 21);
            this.ComboPlayer.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Check_Immortal);
            this.Controls.Add(this.L_HpValue);
            this.Controls.Add(this.LHP);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Set_HP);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.Button BUT_SaveOffsets;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox Check_Immortal;
        private System.Windows.Forms.Label L_HpValue;
        private System.Windows.Forms.Label LHP;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Set_HP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox E_1Item_Offset;
        private System.Windows.Forms.Label lFirstItemoffset;
        private System.Windows.Forms.TextBox E_Z_Offset;
        private System.Windows.Forms.Label lzoffset;
        private System.Windows.Forms.TextBox E_HP_Offset;
        private System.Windows.Forms.TextBox E_Y_Offset;
        private System.Windows.Forms.Label lHPOffset;
        private System.Windows.Forms.Label lyOffset;
        private System.Windows.Forms.Label lXoffset;
        private System.Windows.Forms.TextBox E_X_Offset;
        private System.Windows.Forms.Button BUT_PlayerLoad;
        private System.Windows.Forms.ComboBox ComboPlayer;
    }
}

