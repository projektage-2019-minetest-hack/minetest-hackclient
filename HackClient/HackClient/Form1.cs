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

namespace HackClient
{
    public partial class Form1 : Form
    {
        //public Mem mMemory = new Mem();
        private MemoryHandler mHandler = new MemoryHandler();
        Player mPlayer = new Player();
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
                            //LHP.Text = MemoryHandler.GetHP();
                            // worker.ReportProgress(0, "AN OBJECT TO PASS TO THE UI-THREAD");
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
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Set_HP_Click(object sender, EventArgs e)
        {
            //mPlayer.offsetLeben =Convert.ToInt32( numericUpDown1.Value);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker.CancelAsync();
            Closing = true;
        }

        private void Check_Immortal_CheckedChanged(object sender, EventArgs e)
        {
            //mHandler.toggleGodmode(Check_Immortal.Checked);
            mHandler.toggleGodmode();
        }

        private void BUT_SaveOffsets_Click(object sender, EventArgs e)
        {

        }
    }
}
