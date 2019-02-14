using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        }

        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            object userObject = e.UserState;
            int percentage = e.ProgressPercentage;
        }

        private void BackgroundWorkerOnDoWork(object sender, DoWorkEventArgs e)
        {

            while (!backgroundWorker.CancellationPending && !Closing)
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate ()
                        {
                            if (ComboPlayer.SelectedIndex != -1 && ComboPlayer.Items.Count > 0)
                            {
                                //LHP.Text = MemoryHandler.GetHP();
                                // worker.ReportProgress(0, "AN OBJECT TO PASS TO THE UI-THREAD");
                                LHP.Text = mHandler.getHp();
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
            backgroundWorker.DoWork += BackgroundWorkerOnDoWork;
            backgroundWorker.ProgressChanged += BackgroundWorkerOnProgressChanged;
            backgroundWorker.RunWorkerAsync();
            LoadPlayerListwithScan();
            if (ComboPlayer.Items.Count > 0)
            {
                ComboPlayer.SelectedIndex = 0;
                E_HP_Offset.Text = mHandler.playerlist[ComboPlayer.SelectedIndex].offsetLeben;
                E_1Item_Offset.Text = mHandler.playerlist[ComboPlayer.SelectedIndex].offsetFirstItem;
                E_X_Offset.Text = mHandler.playerlist[ComboPlayer.SelectedIndex].offsetx;
                E_Y_Offset.Text = mHandler.playerlist[ComboPlayer.SelectedIndex].offsety;
                E_Z_Offset.Text = mHandler.playerlist[ComboPlayer.SelectedIndex].offsetz;
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mHandler = new MemoryHandler();
        }

        private void Set_HP_Click(object sender, EventArgs e)
        {
            //mPlayer.offsetLeben =Convert.ToInt32( numericUpDown1.Value);
            mHandler.setHP(numericUpDown1.Value.ToString());

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

        private void BUT_SaveOffsets_Click(object sender, EventArgs e)
        {
            mHandler.playerlist[ComboPlayer.SelectedIndex].offsetLeben = E_HP_Offset.Text;
            mHandler.playerlist[ComboPlayer.SelectedIndex].offsetFirstItem = E_1Item_Offset.Text;
            mHandler.playerlist[ComboPlayer.SelectedIndex].offsetx= E_X_Offset.Text;
            mHandler.playerlist[ComboPlayer.SelectedIndex].offsety = E_Y_Offset.Text;
            mHandler.playerlist[ComboPlayer.SelectedIndex].offsetz = E_Z_Offset.Text;
          
        }

        private void BUT_PlayerLoad_Click(object sender, EventArgs e)
        {
            LoadPlayerListwithScan();
        }

        private void LoadPlayerListwithScan()
        {
            
            ComboPlayer.Items.Clear();

            mHandler.getPlayerList();

            



            for (int i =0; i<mHandler.playerlist.Count;i++)
            {
                ComboPlayer.Items.Add("Player1");//Später name aus dem jeweiligen Player
            }
        }

        private void ComboPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboPlayer.Items.Count > 0 && ComboPlayer.SelectedIndex != -1)
            {
                mHandler.playerId = ComboPlayer.SelectedIndex;
            }
        }
    }
}
