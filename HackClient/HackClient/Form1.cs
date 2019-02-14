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
                Thread.Sleep(1);
                try
                {
                    this.Invoke((MethodInvoker)delegate ()
                        {
                            if (tabControl1.SelectedIndex == 0)
                            {
                                string[] pos= mHandler.getPosition();
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
                                    LHP.Text = mHandler.getHp();
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
            LoadPlayerListwithScan();
            
            
                
            
            
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
            LoadPlayerListwithScan();
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





            for (int i = 0; i < mHandler.playerlist.Count; i++)
            {
                ComboPlayer.Items.Add(/*mHandler.playerlist[i].name*/ "Player "+ i);//Später name aus dem jeweiligen Player
            }


            mHandler.setChosenPlayer(-1);
        }

        private void ComboPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboPlayer.Items.Count > 0 && ComboPlayer.SelectedIndex != -1)
            {
                mHandler.setChosenPlayer(ComboPlayer.SelectedIndex);
            }
        }

        private void BUT_SetName_Click(object sender, EventArgs e)
        {
            mHandler.SetName();
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
    }
}
