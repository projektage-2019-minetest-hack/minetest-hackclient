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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.E_X_Offset = new System.Windows.Forms.TextBox();
            this.lXoffset = new System.Windows.Forms.Label();
            this.BUT_SaveOffsets = new System.Windows.Forms.Button();
            this.lyOffset = new System.Windows.Forms.Label();
            this.lHPOffset = new System.Windows.Forms.Label();
            this.E_Y_Offset = new System.Windows.Forms.TextBox();
            this.E_HP_Offset = new System.Windows.Forms.TextBox();
            this.lzoffset = new System.Windows.Forms.Label();
            this.E_Z_Offset = new System.Windows.Forms.TextBox();
            this.lFirstItemoffset = new System.Windows.Forms.Label();
            this.E_1Item_Offset = new System.Windows.Forms.TextBox();
            this.BUT_PlayerLoad = new System.Windows.Forms.Button();
            this.ComboPlayer = new System.Windows.Forms.ComboBox();
            this.numPlayer = new System.Windows.Forms.NumericUpDown();
            this.L_Anzahl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.E_NewName = new System.Windows.Forms.TextBox();
            this.L_Namevalue = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.BUT_SetName = new System.Windows.Forms.Button();
            this.Check_Immortal = new System.Windows.Forms.CheckBox();
            this.L_HpValue = new System.Windows.Forms.Label();
            this.LHP = new System.Windows.Forms.Label();
            this.numSetHP = new System.Windows.Forms.NumericUpDown();
            this.Set_HP = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 520);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.E_NewName);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.L_Namevalue);
            this.tabPage1.Controls.Add(this.lName);
            this.tabPage1.Controls.Add(this.BUT_SetName);
            this.tabPage1.Controls.Add(this.Check_Immortal);
            this.tabPage1.Controls.Add(this.L_HpValue);
            this.tabPage1.Controls.Add(this.LHP);
            this.tabPage1.Controls.Add(this.numSetHP);
            this.tabPage1.Controls.Add(this.Set_HP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // E_X_Offset
            // 
            this.E_X_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_X_Offset.Location = new System.Drawing.Point(105, 169);
            this.E_X_Offset.Name = "E_X_Offset";
            this.E_X_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_X_Offset.TabIndex = 14;
            // 
            // lXoffset
            // 
            this.lXoffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lXoffset.AutoSize = true;
            this.lXoffset.Location = new System.Drawing.Point(19, 172);
            this.lXoffset.Name = "lXoffset";
            this.lXoffset.Size = new System.Drawing.Size(45, 13);
            this.lXoffset.TabIndex = 13;
            this.lXoffset.Text = "X Offset";
            // 
            // BUT_SaveOffsets
            // 
            this.BUT_SaveOffsets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_SaveOffsets.Location = new System.Drawing.Point(122, 444);
            this.BUT_SaveOffsets.Name = "BUT_SaveOffsets";
            this.BUT_SaveOffsets.Size = new System.Drawing.Size(112, 23);
            this.BUT_SaveOffsets.TabIndex = 2;
            this.BUT_SaveOffsets.Text = "Speicher Offsets";
            this.BUT_SaveOffsets.UseVisualStyleBackColor = true;
            this.BUT_SaveOffsets.Click += new System.EventHandler(this.BUT_SaveOffsets_Click);
            // 
            // lyOffset
            // 
            this.lyOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lyOffset.AutoSize = true;
            this.lyOffset.Location = new System.Drawing.Point(19, 198);
            this.lyOffset.Name = "lyOffset";
            this.lyOffset.Size = new System.Drawing.Size(45, 13);
            this.lyOffset.TabIndex = 15;
            this.lyOffset.Text = "Y Offset";
            // 
            // lHPOffset
            // 
            this.lHPOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lHPOffset.AutoSize = true;
            this.lHPOffset.Location = new System.Drawing.Point(19, 146);
            this.lHPOffset.Name = "lHPOffset";
            this.lHPOffset.Size = new System.Drawing.Size(53, 13);
            this.lHPOffset.TabIndex = 11;
            this.lHPOffset.Text = "HP Offset";
            // 
            // E_Y_Offset
            // 
            this.E_Y_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_Y_Offset.Location = new System.Drawing.Point(105, 195);
            this.E_Y_Offset.Name = "E_Y_Offset";
            this.E_Y_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_Y_Offset.TabIndex = 16;
            // 
            // E_HP_Offset
            // 
            this.E_HP_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_HP_Offset.Location = new System.Drawing.Point(105, 143);
            this.E_HP_Offset.Name = "E_HP_Offset";
            this.E_HP_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_HP_Offset.TabIndex = 12;
            // 
            // lzoffset
            // 
            this.lzoffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lzoffset.AutoSize = true;
            this.lzoffset.Location = new System.Drawing.Point(19, 224);
            this.lzoffset.Name = "lzoffset";
            this.lzoffset.Size = new System.Drawing.Size(45, 13);
            this.lzoffset.TabIndex = 17;
            this.lzoffset.Text = "Z Offset";
            // 
            // E_Z_Offset
            // 
            this.E_Z_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_Z_Offset.Location = new System.Drawing.Point(105, 221);
            this.E_Z_Offset.Name = "E_Z_Offset";
            this.E_Z_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_Z_Offset.TabIndex = 18;
            // 
            // lFirstItemoffset
            // 
            this.lFirstItemoffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lFirstItemoffset.AutoSize = true;
            this.lFirstItemoffset.Location = new System.Drawing.Point(19, 250);
            this.lFirstItemoffset.Name = "lFirstItemoffset";
            this.lFirstItemoffset.Size = new System.Drawing.Size(80, 13);
            this.lFirstItemoffset.TabIndex = 19;
            this.lFirstItemoffset.Text = "First Item Offset";
            // 
            // E_1Item_Offset
            // 
            this.E_1Item_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_1Item_Offset.Location = new System.Drawing.Point(105, 247);
            this.E_1Item_Offset.Name = "E_1Item_Offset";
            this.E_1Item_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_1Item_Offset.TabIndex = 20;
            // 
            // BUT_PlayerLoad
            // 
            this.BUT_PlayerLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_PlayerLoad.Location = new System.Drawing.Point(53, 37);
            this.BUT_PlayerLoad.Name = "BUT_PlayerLoad";
            this.BUT_PlayerLoad.Size = new System.Drawing.Size(75, 23);
            this.BUT_PlayerLoad.TabIndex = 21;
            this.BUT_PlayerLoad.Text = "Lade Spieler";
            this.BUT_PlayerLoad.UseVisualStyleBackColor = true;
            this.BUT_PlayerLoad.Click += new System.EventHandler(this.BUT_PlayerLoad_Click);
            // 
            // ComboPlayer
            // 
            this.ComboPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPlayer.FormattingEnabled = true;
            this.ComboPlayer.Location = new System.Drawing.Point(7, 116);
            this.ComboPlayer.Name = "ComboPlayer";
            this.ComboPlayer.Size = new System.Drawing.Size(121, 21);
            this.ComboPlayer.TabIndex = 22;
            this.ComboPlayer.SelectedIndexChanged += new System.EventHandler(this.ComboPlayer_SelectedIndexChanged);
            // 
            // numPlayer
            // 
            this.numPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPlayer.Location = new System.Drawing.Point(153, 13);
            this.numPlayer.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numPlayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPlayer.Name = "numPlayer";
            this.numPlayer.Size = new System.Drawing.Size(90, 20);
            this.numPlayer.TabIndex = 23;
            this.numPlayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // L_Anzahl
            // 
            this.L_Anzahl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Anzahl.AutoSize = true;
            this.L_Anzahl.Location = new System.Drawing.Point(4, 15);
            this.L_Anzahl.Name = "L_Anzahl";
            this.L_Anzahl.Size = new System.Drawing.Size(143, 13);
            this.L_Anzahl.TabIndex = 24;
            this.L_Anzahl.Text = "Anzahl zu Suchender Spieler";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.L_Anzahl);
            this.panel1.Controls.Add(this.numPlayer);
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
            this.panel1.Location = new System.Drawing.Point(387, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 479);
            this.panel1.TabIndex = 17;
            // 
            // E_NewName
            // 
            this.E_NewName.Location = new System.Drawing.Point(111, 33);
            this.E_NewName.Name = "E_NewName";
            this.E_NewName.Size = new System.Drawing.Size(120, 20);
            this.E_NewName.TabIndex = 31;
            // 
            // L_Namevalue
            // 
            this.L_Namevalue.AutoSize = true;
            this.L_Namevalue.Location = new System.Drawing.Point(43, 36);
            this.L_Namevalue.Name = "L_Namevalue";
            this.L_Namevalue.Size = new System.Drawing.Size(16, 13);
            this.L_Namevalue.TabIndex = 30;
            this.L_Namevalue.Text = "---";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 36);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(25, 13);
            this.lName.TabIndex = 29;
            this.lName.Text = "HP:";
            // 
            // BUT_SetName
            // 
            this.BUT_SetName.Location = new System.Drawing.Point(237, 31);
            this.BUT_SetName.Name = "BUT_SetName";
            this.BUT_SetName.Size = new System.Drawing.Size(75, 23);
            this.BUT_SetName.TabIndex = 28;
            this.BUT_SetName.Text = "Setze Name";
            this.BUT_SetName.UseVisualStyleBackColor = true;
            // 
            // Check_Immortal
            // 
            this.Check_Immortal.AutoSize = true;
            this.Check_Immortal.Location = new System.Drawing.Point(318, 11);
            this.Check_Immortal.Name = "Check_Immortal";
            this.Check_Immortal.Size = new System.Drawing.Size(57, 17);
            this.Check_Immortal.TabIndex = 27;
            this.Check_Immortal.Text = "Imortal";
            this.Check_Immortal.UseVisualStyleBackColor = true;
            // 
            // L_HpValue
            // 
            this.L_HpValue.AutoSize = true;
            this.L_HpValue.Location = new System.Drawing.Point(43, 12);
            this.L_HpValue.Name = "L_HpValue";
            this.L_HpValue.Size = new System.Drawing.Size(16, 13);
            this.L_HpValue.TabIndex = 26;
            this.L_HpValue.Text = "---";
            // 
            // LHP
            // 
            this.LHP.AutoSize = true;
            this.LHP.Location = new System.Drawing.Point(12, 12);
            this.LHP.Name = "LHP";
            this.LHP.Size = new System.Drawing.Size(25, 13);
            this.LHP.TabIndex = 25;
            this.LHP.Text = "HP:";
            // 
            // numSetHP
            // 
            this.numSetHP.Location = new System.Drawing.Point(111, 10);
            this.numSetHP.Name = "numSetHP";
            this.numSetHP.Size = new System.Drawing.Size(120, 20);
            this.numSetHP.TabIndex = 23;
            // 
            // Set_HP
            // 
            this.Set_HP.Location = new System.Drawing.Point(237, 7);
            this.Set_HP.Name = "Set_HP";
            this.Set_HP.Size = new System.Drawing.Size(75, 23);
            this.Set_HP.TabIndex = 24;
            this.Set_HP.Text = "Setze HP";
            this.Set_HP.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(318, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Imortal";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "HP:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 6);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Setze HP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox E_NewName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_Anzahl;
        private System.Windows.Forms.NumericUpDown numPlayer;
        private System.Windows.Forms.ComboBox ComboPlayer;
        private System.Windows.Forms.Button BUT_PlayerLoad;
        private System.Windows.Forms.TextBox E_1Item_Offset;
        private System.Windows.Forms.Label lFirstItemoffset;
        private System.Windows.Forms.TextBox E_Z_Offset;
        private System.Windows.Forms.Label lzoffset;
        private System.Windows.Forms.TextBox E_HP_Offset;
        private System.Windows.Forms.TextBox E_Y_Offset;
        private System.Windows.Forms.Label lHPOffset;
        private System.Windows.Forms.Label lyOffset;
        private System.Windows.Forms.Button BUT_SaveOffsets;
        private System.Windows.Forms.Label lXoffset;
        private System.Windows.Forms.TextBox E_X_Offset;
        private System.Windows.Forms.Label L_Namevalue;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button BUT_SetName;
        private System.Windows.Forms.CheckBox Check_Immortal;
        private System.Windows.Forms.Label L_HpValue;
        private System.Windows.Forms.Label LHP;
        private System.Windows.Forms.NumericUpDown numSetHP;
        private System.Windows.Forms.Button Set_HP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}

