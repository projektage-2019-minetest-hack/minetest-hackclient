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
        public Mem mMemory = new Mem();
        public int ProcessID = -1;
        public Form1()
        {
            InitializeComponent();
            ProcessID=mMemory.getProcIDFromName("Minetest engine (32 Bit)");
            BackgroundWorker backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            backgroundWorker.DoWork += BackgroundWorkerOnDoWork;
            backgroundWorker.ProgressChanged += BackgroundWorkerOnProgressChanged;
        }

        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            object userObject = e.UserState;
            int percentage = e.ProgressPercentage;
        }

        private void BackgroundWorkerOnDoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {

                //Do your stuff here
                mMemory.OpenProcess(ProcessID);
                mMemory.readUInt(,null)
        // worker.ReportProgress(0, "AN OBJECT TO PASS TO THE UI-THREAD");
    }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
