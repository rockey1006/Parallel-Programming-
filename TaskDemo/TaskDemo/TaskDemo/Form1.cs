using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskDemo
{
    public partial class Form1 : Form
    {

        DateTime _taskStartTime;
        /// <summary>
        /// task开始时间记录
        /// </summary>
        DateTime TaskStartTime
        {
            get
            {

                return _taskStartTime;

            }
            set
            {
                Monitor.Enter(this);
                _taskStartTime = value;
                Monitor.Exit(this);
            }
        }
        /// <summary>
        /// 显示时间Task取消
        /// </summary>
        CancellationTokenSource cancelTokenSource = null;
        /// <summary>
        /// 显示价格task取消
        /// </summary>
        CancellationTokenSource cancelTokenSourceShowStockPrice = null;
        /// <summary>
        /// 显示时间的弹窗
        /// </summary>
        Form2 showWindow;
        /// <summary>
        /// 显示价格的弹窗
        /// </summary>
        Form2 showPriceWindow;
        public Form1()
        {
            InitializeComponent();
        }

        #region 按钮点击事件
        private void newTask_Click(object sender, EventArgs e)
        {
            Task.Run(() => { MessageBox.Show("new Task Done"); });
        }
        private void computeTask_Click(object sender, EventArgs e)
        {
            MyCompute mc = new MyCompute();
            mc.Data1 = 24.22f;
            mc.Data2 = 11;
            Func<float, float, double> fptr = new Func<float, float, double>(mc.Compute2);
            var task = new Task<double>(() => mc.Compute2(23.67f, 12.66f));
            task.Start();
            var result = task.Result;
            MessageBox.Show(result.ToString());
        }
        private void secondTask_Click(object sender, EventArgs e)
        {
            Task.Run(() => { MessageBox.Show("second Task Done"); });
        }
        private void btnThreadLikeTask_Click(object sender, EventArgs e)
        {
            MyCompute mc = new MyCompute();
            mc.Data1 = 24.22f;
            mc.Data2 = 11;
            Action fCompute = new Action(mc.Compute3);
            Thread thCompute = new Thread(new ThreadStart(fCompute));
            thCompute.Start();
            thCompute.Join();
            MessageBox.Show("Result = " + mc.Res.ToString());

        }
        private void paralellInvoke_Click(object sender, EventArgs e)
        {
            Parallel.Invoke(
               () => MessageBox.Show("First Task.."),
               () => { Thread.Sleep(3000); MessageBox.Show("Second Task"); },
               () => MessageBox.Show("Third Task")
            );
        }
        private void taskAndAction_Click(object sender, EventArgs e)
        {
            MyCompute mc = new MyCompute();
            mc.Data1 = 24.22f;
            mc.Data2 = 11;
            Action fCompute = () => { MessageBox.Show("taskAndAction"); };
            Task.Run(fCompute);
        }
        private void btnStarTaskWithCancelToken_Click(object sender, EventArgs e)
        {
            showWindow = new Form2();
            showWindow.Show();
            cancelTokenSource = new CancellationTokenSource();
            CancellationToken cancelToken = cancelTokenSource.Token;
            Task.Run(() => ShowTime(cancelToken), cancelToken);
        }

        private void btnStopTaskWithCancelToken_Click(object sender, EventArgs e)
        {
            cancelTokenSource.Cancel();
            showWindow.Close();
            timeChanged("Task Stopped");
        }

        private void startTwoTasks_Click(object sender, EventArgs e)
        {
            showPriceWindow = new Form2();
            showWindow = new Form2();

            cancelTokenSource = new CancellationTokenSource();
            CancellationToken cancelToken = cancelTokenSource.Token;

            cancelTokenSourceShowStockPrice = new CancellationTokenSource();
            CancellationToken cancelToken2 = cancelTokenSourceShowStockPrice.Token;

            showPriceWindow.Show();
            showWindow.Show();
            Task.Run(() => { ShowStockPrice(cancelToken2); }, cancelToken2);
            Task.Run(() => { ShowTime(cancelToken); }, cancelToken);
        }

        private void CancelTwoTasks_Click(object sender, EventArgs e)
        {
            cancelTokenSource.Cancel();
            cancelTokenSourceShowStockPrice.Cancel();
            showWindow.ChangeText1("Task Stopped");
            showPriceWindow.ChangeText1("Task Stopped");
            showWindow.Close();
            showPriceWindow.Close();

            timeChanged("Task Stopped");
            priceChanged("Task Stopped");

            MessageBox.Show("Show Price Task has been Cancelled \r\n Task was Started at:"
                + TaskStartTime.ToLongDateString() + "  " + TaskStartTime.ToLongTimeString());
        }

        #endregion

        #region 私有方法
        /// <summary>
        /// 显示价格的方法
        /// </summary>
        /// <param name="canToken"></param>
        void ShowStockPrice(CancellationToken canToken)
        {
            TaskStartTime = DateTime.Now;
            while (true)
            {
                try
                {
                    WebClient wbc = new WebClient();
                    byte[] bdata = wbc.DownloadData("http://www.nasdaq.com/aspx/infoquotes.aspx?symbol=IBM&selected=IBM");
                    string pageText = new UTF8Encoding().GetString(bdata);
                    int pos1 = pageText.IndexOf("LastSale1'>");
                    int pos2 = pageText.IndexOf("</", pos1 + 1);
                    string price = "价格：" + pageText.Substring(pos1 + 52, pos2 - pos1 - 60);
                    showPriceWindow.ChangeText1(price);

                    priceChanged(price);
                    canToken.WaitHandle.WaitOne(30000);
                    canToken.ThrowIfCancellationRequested();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
        /// <summary>
        /// 显示时间的方法
        /// </summary>
        /// <param name="canToken"></param>
        void ShowTime(CancellationToken canToken)
        {

            while (true)
            {
                var time = DateTime.Now.ToLongTimeString();
                showWindow.ChangeText1(time);
                timeChanged(time);
                canToken.WaitHandle.WaitOne(1000);
                canToken.ThrowIfCancellationRequested();
            }
        }
        /// <summary>
        /// 改变状态栏的时间文字
        /// </summary>
        /// <param name="s"></param>
        private void timeChanged(string s)
        {
            Action act = () => { this.timelabel.Text = s; };
            this.Invoke(act);
        }
        /// <summary>
        /// 改变状态栏的价格文字
        /// </summary>
        /// <param name="s"></param>
        private void priceChanged(string s)
        {
            Action act = () => { this.pricelabel.Text = s; };
            this.Invoke(act);
        }
        #endregion
    }


    class MyCompute
    {
        object oLock = new object();

        double res;
        public double Res
        {
            get
            {
                double ress = 0;
                lock (oLock) { ress = res; }
                return ress;
            }
        }

        float data1;
        public float Data1
        {
            get { float d1 = 0; lock (oLock) { d1 = data1; } return d1; }
            set { lock (oLock) { data1 = value; } }
        }

        int data2;
        public int Data2
        {
            get { int d2 = 0; lock (oLock) { d2 = data2; } return d2; }
            set { lock (oLock) { data2 = value; } }
        }

        public void Compute3()
        {
            double result = 0;
            lock (oLock) { result = data1 * data2 - 23.33; }
            Thread.Sleep(1000);
            lock (oLock) { res = result; }
        }

        public double Compute2(float a, float b)
        {
            double result = a * b - 23.33;
            Thread.Sleep(1000);
            return result;
        }

    }

}
