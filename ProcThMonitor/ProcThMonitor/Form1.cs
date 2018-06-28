using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcThMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListProcesses_Click(object sender, EventArgs e)
        {
            lbProcs.Items.Clear();
            Process[] procs = Process.GetProcesses();
            foreach (Process pr in procs)
                lbProcs.Items.Add(pr.ProcessName + ":" + pr.Id.ToString());

        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            btnListProcesses_Click(null, null);
        }
        private void lbProcs_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            char[] sep = { ':' };
            string pnameId = lbProcs.SelectedItem.ToString();
            int Id = int.Parse((pnameId.Split(sep, 2))[1]);
            Process pr = Process.GetProcessById(Id);
            lblProcessInfo.Text = "Process name: Id = " + pnameId + "\n" +
            "Priority Class = " + pr.PriorityClass.ToString() + "\n" +
             "Base Priority = " + pr.BasePriority.ToString() + "\n" +
             "Start Time = " + pr.StartTime.ToString() + "\n" +
             "Processor Time = " + pr.TotalProcessorTime.ToString() + "\n" +
             "physical Memory = " + pr.WorkingSet64.ToString() + "\n" +
             "Virtual Memory = " + pr.VirtualMemorySize64.ToString() + "\n";
            ProcessThreadCollection threads = pr.Threads;
            StringBuilder sb = new StringBuilder();
            foreach (ProcessThread pth in threads)
            {
                string tinfo = "Thread ID = " + pth.Id.ToString() + "\r\n" +
                   "Thread State = " + pth.ThreadState.ToString() + "\r\n" +
                   "Base Priority = " + pth.BasePriority.ToString() + "\r\n" +
                   "Thread Priority = " + pth.PriorityLevel.ToString() + "\r\n" +
                   "Start Time = " + pth.StartTime.ToString() + "\r\n" +
                   "CPU time = " + pth.TotalProcessorTime.ToString() + "\r\n\r\n";
                sb.Append(tinfo);
            }
            txtThreadsInfo.Text = "Total Threads in this Process = " +
                threads.Count.ToString() +
                "\r\n" + sb.ToString();
        }
    }
}






    