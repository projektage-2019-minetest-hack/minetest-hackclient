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
            this.TabClient = new System.Windows.Forms.TabPage();
            this.E_Z = new System.Windows.Forms.TextBox();
            this.E_Y = new System.Windows.Forms.TextBox();
            this.BUT_SetPos = new System.Windows.Forms.Button();
            this.E_X = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lYValue = new System.Windows.Forms.Label();
            this.lZValue = new System.Windows.Forms.Label();
            this.lXValue = new System.Windows.Forms.Label();
            this.lY = new System.Windows.Forms.Label();
            this.lx = new System.Windows.Forms.Label();
            this.lPos = new System.Windows.Forms.Label();
            this.TabServer = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Anzahl = new System.Windows.Forms.Label();
            this.numPlayer = new System.Windows.Forms.NumericUpDown();
            this.ComboPlayer = new System.Windows.Forms.ComboBox();
            this.BUT_PlayerLoad = new System.Windows.Forms.Button();
            this.E_1Item_Offset = new System.Windows.Forms.TextBox();
            this.lFirstItemoffset = new System.Windows.Forms.Label();
            this.E_Z_Offset = new System.Windows.Forms.TextBox();
            this.lzoffset = new System.Windows.Forms.Label();
            this.E_HP_Offset = new System.Windows.Forms.TextBox();
            this.E_Y_Offset = new System.Windows.Forms.TextBox();
            this.lHPOffset = new System.Windows.Forms.Label();
            this.lyOffset = new System.Windows.Forms.Label();
            this.BUT_SaveOffsets = new System.Windows.Forms.Button();
            this.lXoffset = new System.Windows.Forms.Label();
            this.E_X_Offset = new System.Windows.Forms.TextBox();
            this.Check_Immortal = new System.Windows.Forms.CheckBox();
            this.L_HpValue = new System.Windows.Forms.Label();
            this.LHP = new System.Windows.Forms.Label();
            this.numSetHP = new System.Windows.Forms.NumericUpDown();
            this.Set_HP = new System.Windows.Forms.Button();
            this.BUT_Copy = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabClient.SuspendLayout();
            this.TabServer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetHP)).BeginInit();
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
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabClient);
            this.tabControl1.Controls.Add(this.TabServer);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 520);
            this.tabControl1.TabIndex = 23;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabClient
            // 
            this.TabClient.Controls.Add(this.BUT_Copy);
            this.TabClient.Controls.Add(this.E_Z);
            this.TabClient.Controls.Add(this.E_Y);
            this.TabClient.Controls.Add(this.BUT_SetPos);
            this.TabClient.Controls.Add(this.E_X);
            this.TabClient.Controls.Add(this.label6);
            this.TabClient.Controls.Add(this.lYValue);
            this.TabClient.Controls.Add(this.lZValue);
            this.TabClient.Controls.Add(this.lXValue);
            this.TabClient.Controls.Add(this.lY);
            this.TabClient.Controls.Add(this.lx);
            this.TabClient.Controls.Add(this.lPos);
            this.TabClient.Location = new System.Drawing.Point(4, 22);
            this.TabClient.Name = "TabClient";
            this.TabClient.Padding = new System.Windows.Forms.Padding(3);
            this.TabClient.Size = new System.Drawing.Size(639, 494);
            this.TabClient.TabIndex = 1;
            this.TabClient.Text = "Client";
            this.TabClient.UseVisualStyleBackColor = true;
            // 
            // E_Z
            // 
            this.E_Z.Location = new System.Drawing.Point(242, 63);
            this.E_Z.Name = "E_Z";
            this.E_Z.Size = new System.Drawing.Size(100, 20);
            this.E_Z.TabIndex = 10;
            // 
            // E_Y
            // 
            this.E_Y.Location = new System.Drawing.Point(135, 63);
            this.E_Y.Name = "E_Y";
            this.E_Y.Size = new System.Drawing.Size(100, 20);
            this.E_Y.TabIndex = 9;
            // 
            // BUT_SetPos
            // 
            this.BUT_SetPos.Location = new System.Drawing.Point(146, 89);
            this.BUT_SetPos.Name = "BUT_SetPos";
            this.BUT_SetPos.Size = new System.Drawing.Size(75, 23);
            this.BUT_SetPos.TabIndex = 8;
            this.BUT_SetPos.Text = "Set Position";
            this.BUT_SetPos.UseVisualStyleBackColor = true;
            this.BUT_SetPos.Click += new System.EventHandler(this.BUT_SetPos_Click);
            // 
            // E_X
            // 
            this.E_X.Location = new System.Drawing.Point(20, 63);
            this.E_X.Name = "E_X";
            this.E_X.Size = new System.Drawing.Size(100, 20);
            this.E_X.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nord Süd:";
            // 
            // lYValue
            // 
            this.lYValue.AutoSize = true;
            this.lYValue.Location = new System.Drawing.Point(174, 47);
            this.lYValue.Name = "lYValue";
            this.lYValue.Size = new System.Drawing.Size(13, 13);
            this.lYValue.TabIndex = 5;
            this.lYValue.Text = "--";
            // 
            // lZValue
            // 
            this.lZValue.AutoSize = true;
            this.lZValue.Location = new System.Drawing.Point(300, 47);
            this.lZValue.Name = "lZValue";
            this.lZValue.Size = new System.Drawing.Size(13, 13);
            this.lZValue.TabIndex = 4;
            this.lZValue.Text = "--";
            // 
            // lXValue
            // 
            this.lXValue.AutoSize = true;
            this.lXValue.Location = new System.Drawing.Point(77, 47);
            this.lXValue.Name = "lXValue";
            this.lXValue.Size = new System.Drawing.Size(13, 13);
            this.lXValue.TabIndex = 3;
            this.lXValue.Text = "--";
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Location = new System.Drawing.Point(132, 47);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(36, 13);
            this.lY.TabIndex = 2;
            this.lY.Text = "Höhe:";
            // 
            // lx
            // 
            this.lx.AutoSize = true;
            this.lx.Location = new System.Drawing.Point(17, 47);
            this.lx.Name = "lx";
            this.lx.Size = new System.Drawing.Size(54, 13);
            this.lx.TabIndex = 1;
            this.lx.Text = "West Ost:";
            // 
            // lPos
            // 
            this.lPos.AutoSize = true;
            this.lPos.Location = new System.Drawing.Point(15, 13);
            this.lPos.Name = "lPos";
            this.lPos.Size = new System.Drawing.Size(44, 13);
            this.lPos.TabIndex = 0;
            this.lPos.Text = "Position";
            // 
            // TabServer
            // 
            this.TabServer.Controls.Add(this.panel1);
            this.TabServer.Controls.Add(this.Check_Immortal);
            this.TabServer.Controls.Add(this.L_HpValue);
            this.TabServer.Controls.Add(this.LHP);
            this.TabServer.Controls.Add(this.numSetHP);
            this.TabServer.Controls.Add(this.Set_HP);
            this.TabServer.Location = new System.Drawing.Point(4, 22);
            this.TabServer.Name = "TabServer";
            this.TabServer.Padding = new System.Windows.Forms.Padding(3);
            this.TabServer.Size = new System.Drawing.Size(639, 494);
            this.TabServer.TabIndex = 0;
            this.TabServer.Text = "Server";
            this.TabServer.UseVisualStyleBackColor = true;
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
            // E_1Item_Offset
            // 
            this.E_1Item_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_1Item_Offset.Location = new System.Drawing.Point(105, 247);
            this.E_1Item_Offset.Name = "E_1Item_Offset";
            this.E_1Item_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_1Item_Offset.TabIndex = 20;
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
            // E_Z_Offset
            // 
            this.E_Z_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_Z_Offset.Location = new System.Drawing.Point(105, 221);
            this.E_Z_Offset.Name = "E_Z_Offset";
            this.E_Z_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_Z_Offset.TabIndex = 18;
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
            // E_HP_Offset
            // 
            this.E_HP_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_HP_Offset.Location = new System.Drawing.Point(105, 143);
            this.E_HP_Offset.Name = "E_HP_Offset";
            this.E_HP_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_HP_Offset.TabIndex = 12;
            // 
            // E_Y_Offset
            // 
            this.E_Y_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_Y_Offset.Location = new System.Drawing.Point(105, 195);
            this.E_Y_Offset.Name = "E_Y_Offset";
            this.E_Y_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_Y_Offset.TabIndex = 16;
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
            // E_X_Offset
            // 
            this.E_X_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E_X_Offset.Location = new System.Drawing.Point(105, 169);
            this.E_X_Offset.Name = "E_X_Offset";
            this.E_X_Offset.Size = new System.Drawing.Size(100, 20);
            this.E_X_Offset.TabIndex = 14;
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
            // BUT_Copy
            // 
            this.BUT_Copy.Location = new System.Drawing.Point(348, 61);
            this.BUT_Copy.Name = "BUT_Copy";
            this.BUT_Copy.Size = new System.Drawing.Size(163, 23);
            this.BUT_Copy.TabIndex = 11;
            this.BUT_Copy.Text = "Kopiere von aktueller Position";
            this.BUT_Copy.UseVisualStyleBackColor = true;
            this.BUT_Copy.Click += new System.EventHandler(this.BUT_Copy_Click);
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
            this.TabClient.ResumeLayout(false);
            this.TabClient.PerformLayout();
            this.TabServer.ResumeLayout(false);
            this.TabServer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabServer;
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
        private System.Windows.Forms.CheckBox Check_Immortal;
        private System.Windows.Forms.Label L_HpValue;
        private System.Windows.Forms.Label LHP;
        private System.Windows.Forms.NumericUpDown numSetHP;
        private System.Windows.Forms.Button Set_HP;
        private System.Windows.Forms.TabPage TabClient;
        private System.Windows.Forms.Label lPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lYValue;
        private System.Windows.Forms.Label lZValue;
        private System.Windows.Forms.Label lXValue;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.Label lx;
        private System.Windows.Forms.TextBox E_Z;
        private System.Windows.Forms.TextBox E_Y;
        private System.Windows.Forms.Button BUT_SetPos;
        private System.Windows.Forms.TextBox E_X;
        private System.Windows.Forms.Button BUT_Copy;
    }
}

