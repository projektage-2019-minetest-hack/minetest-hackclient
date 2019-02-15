using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Memory;
using System.Threading;

namespace HackClient
{
    public partial class Form1 : Form
    {

        //public Mem mMemory = new Mem();
        private MemoryHandler mHandler = new MemoryHandler();
        //Player mPlayer = new Player();
        public BackgroundWorker backgroundWorker;
        private bool Closing = false;

        public Form1()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, mActionHotKeyIDLeft, alt, (int)Keys.Left);
            RegisterHotKey(this.Handle, mActionHotKeyIDRight, alt, (int)Keys.Right);
            RegisterHotKey(this.Handle, mActionHotKeyIDUp, alt, (int)Keys.Up);
            RegisterHotKey(this.Handle, mActionHotKeyIDDown, alt, (int)Keys.Down);
            RegisterHotKey(this.Handle, mActionHotKeyIDSPACE, alt, (int)Keys.Space);
            RegisterHotKey(this.Handle, mActionHotKeyIDSTRLeft, strg, (int)Keys.Left);
            RegisterHotKey(this.Handle, mActionHotKeyIDSTRRight, strg, (int)Keys.Right);
            RegisterHotKey(this.Handle, mActionHotKeyIDSTRUp, strg, (int)Keys.Up);
            RegisterHotKey(this.Handle, mActionHotKeyIDSTRDown, strg, (int)Keys.Down);
            RegisterHotKey(this.Handle, mActionHotKeyIDSTRSPACE, strg, (int)Keys.Space);

        }
        const int alt = 1;
        const int strg = 2;
        const int mActionHotKeyIDLeft = 1;
        const int mActionHotKeyIDRight = 2;
        const int mActionHotKeyIDUp = 3;
        const int mActionHotKeyIDDown = 4;
        const int mActionHotKeyIDSPACE = 5;
        const int mActionHotKeyIDSTRLeft = 11;
        const int mActionHotKeyIDSTRRight = 12;
        const int mActionHotKeyIDSTRUp = 13;
        const int mActionHotKeyIDSTRDown = 14;
        const int mActionHotKeyIDSTRSPACE = 15;
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWd, int id, int fsModifiers, int key);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hwnd, int id);

        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            object userObject = e.UserState;
            int percentage = e.ProgressPercentage;
        }

        private void BackgroundWorkerOnDoWork(object sender, DoWorkEventArgs e)
        {

            while (!backgroundWorker.CancellationPending && !Closing)
            {
                Thread.Sleep(1);
                try
                {
                    this.Invoke((MethodInvoker)delegate ()
                        {
                            if (tabControl1.SelectedIndex == 0)
                            {
                                string[] pos = mHandler.getPosition();
                                lXValue.Text = pos[0];
                                lYValue.Text = pos[1];
                                lZValue.Text = pos[2];
                            }
                            else
                            {
                                if (ComboPlayer.SelectedIndex != -1 && ComboPlayer.Items.Count > 0)
                                {
                                    //LHP.Text = MemoryHandler.GetHP();
                                    // worker.ReportProgress(0, "AN OBJECT TO PASS TO THE UI-THREAD");
                                    L_HpValue.Text = mHandler.getHp();
                                }
                            }
                        });
                }
                catch
                {

                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            Scan();





            backgroundWorker.DoWork += BackgroundWorkerOnDoWork;
            backgroundWorker.ProgressChanged += BackgroundWorkerOnProgressChanged;
            backgroundWorker.RunWorkerAsync();

            /*
            if (ComboPlayer.Items.Count > 0)
            {
                
                E_HP_Offset.Text = mHandler.playerlist[ComboPlayer.SelectedIndex].offsetLeben;
                E_1Item_Offset.Text = mHandler.playerlist[ComboPlayer.SelectedIndex].offsetFirstItem;
                E_X_Offset.Text = mHandler.playerlist[ComboPlayer.SelectedIndex].offsetx;
                E_Y_Offset.Text = mHandler.playerlist[ComboPlayer.SelectedIndex].offsety;
                E_Z_Offset.Text = mHandler.playerlist[ComboPlayer.SelectedIndex].offsetz;
            }
            */
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mHandler = new MemoryHandler();
            Scan();
        }

        private void Set_HP_Click(object sender, EventArgs e)
        {
            //mPlayer.offsetLeben =Convert.ToInt32( numericUpDown1.Value);
            mHandler.setHP(numSetHP.Value.ToString());

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker.CancelAsync();
            Closing = true;
        }

        private void Check_Immortal_CheckedChanged(object sender, EventArgs e)
        {
            mHandler.toggleGodmode(Check_Immortal.Checked);
            //mHandler.toggleGodmode();
        }

        //private void BUT_SaveOffsets_Click(object sender, EventArgs e)
        //{
        //    mHandler.playerlist[ComboPlayer.SelectedIndex].offsetLeben = E_HP_Offset.Text;
        //    mHandler.playerlist[ComboPlayer.SelectedIndex].offsetFirstItem = E_1Item_Offset.Text;
        //    mHandler.playerlist[ComboPlayer.SelectedIndex].offsetx= E_X_Offset.Text;
        //    mHandler.playerlist[ComboPlayer.SelectedIndex].offsety = E_Y_Offset.Text;
        //    mHandler.playerlist[ComboPlayer.SelectedIndex].offsetz = E_Z_Offset.Text;

        //}

        private void BUT_PlayerLoad_Click(object sender, EventArgs e)
        {
            Scan();
        }

        private void Scan()
        {

            ComboPlayer.Items.Clear();

            mHandler.getPlayerList();





            for (int i = 0; i < mHandler.playerlist.Count; i++)
            {
                ComboPlayer.Items.Add(/*mHandler.playerlist[i].name*/ "Player " + i);//Später name aus dem jeweiligen Player
            }


            mHandler.setChosenPlayer(-1);
            L_Playername.Text = mHandler.getName();
        }

        private void ComboPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboPlayer.Items.Count > 0 && ComboPlayer.SelectedIndex != -1)
            {
                mHandler.setChosenPlayer(ComboPlayer.SelectedIndex);
            }
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                mHandler.setChosenPlayer(-1);
            }
            else
            {
                mHandler.setChosenPlayer(ComboPlayer.SelectedIndex);
            }

        }

        private void BUT_SetPos_Click(object sender, EventArgs e)
        {
            mHandler.setPosition(E_X.Text, E_Y.Text, E_Z.Text);
        }

        private void BUT_Copy_Click(object sender, EventArgs e)
        {
            E_X.Text = lXValue.Text;
            E_Y.Text = lYValue.Text;
            E_Z.Text = lZValue.Text;
        }

        private void BUT_Ghost_Click(object sender, EventArgs e)
        {
            mHandler.ghostmode();
        }

        protected override void WndProc(ref Message m)
        {

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyIDLeft)
            {
                string newX = (Convert.ToDouble(lXValue.Text) + Convert.ToDouble(numTeleportLenght.Value)).ToString();
                mHandler.setPosition(newX, lYValue.Text, lZValue.Text);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyIDRight)
            {
                string newX = (Convert.ToDouble(lXValue.Text) - Convert.ToDouble(numTeleportLenght.Value)).ToString();
                mHandler.setPosition(newX, lYValue.Text, lZValue.Text);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyIDUp)
            {
                string newZ = (Convert.ToDouble(lZValue.Text) + Convert.ToDouble(numTeleportLenght.Value)).ToString();
                mHandler.setPosition(lXValue.Text, lYValue.Text, newZ);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyIDDown)
            {
                string newZ = (Convert.ToDouble(lZValue.Text) - Convert.ToDouble(numTeleportLenght.Value)).ToString();
                mHandler.setPosition(lXValue.Text, lYValue.Text, newZ);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyIDSPACE)
            {
                string newY = (Convert.ToDouble(lYValue.Text) + Convert.ToDouble(numTeleportLenght.Value)).ToString();
                mHandler.setPosition(lXValue.Text, newY, lZValue.Text);
            }


            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyIDSTRLeft)
            {
                string newX = (Convert.ToDouble(lXValue.Text) - Convert.ToDouble(numTeleportLenght.Value)).ToString();
                mHandler.setPosition(newX, lYValue.Text, lZValue.Text);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyIDSTRRight)
            {
                string newX = (Convert.ToDouble(lXValue.Text) + Convert.ToDouble(numTeleportLenght.Value)).ToString();
                mHandler.setPosition(newX, lYValue.Text, lZValue.Text);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyIDSTRUp)
            {
                string newZ = (Convert.ToDouble(lZValue.Text) - Convert.ToDouble(numTeleportLenght.Value)).ToString();
                mHandler.setPosition(lXValue.Text, lYValue.Text, newZ);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyIDSTRDown)
            {
                string newZ = (Convert.ToDouble(lZValue.Text) + Convert.ToDouble(numTeleportLenght.Value)).ToString();
                mHandler.setPosition(lXValue.Text, lYValue.Text, newZ);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyIDSTRSPACE)
            {
                string newY = (Convert.ToDouble(lYValue.Text) - Convert.ToDouble(numTeleportLenght.Value)).ToString();
                mHandler.setPosition(lXValue.Text, newY, lZValue.Text);
            }


            base.WndProc(ref m);
        }
        /*  //STR
        private void checkTeleport_CheckedChanged(object sender, EventArgs e)
        {
            if(checkTeleport.Checked)
            {
                 RegisterHotKey(this.Handle, mActionHotKeyIDLeft, 0, (int)Keys.Left);
            RegisterHotKey(this.Handle, mActionHotKeyIDRight, 0, (int)Keys.Right);
            RegisterHotKey(this.Handle, mActionHotKeyIDUp, 0, (int)Keys.Up);
            RegisterHotKey(this.Handle, mActionHotKeyIDDown, 0, (int)Keys.Down);
            RegisterHotKey(this.Handle, mActionHotKeyIDSPACE, 0, (int)Keys.Space);
            }
            else
            {
                UnregisterHotKey(this.Handle, mActionHotKeyIDLeft);
                UnregisterHotKey(this.Handle, mActionHotKeyIDRight);
                UnregisterHotKey(this.Handle, mActionHotKeyIDUp);
                UnregisterHotKey(this.Handle, mActionHotKeyIDDown);
                UnregisterHotKey(this.Handle, mActionHotKeyIDSPACE);

            }
        }
        */
    }
}
