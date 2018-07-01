namespace TaskDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.newTask = new System.Windows.Forms.Button();
            this.computeTask = new System.Windows.Forms.Button();
            this.secondTask = new System.Windows.Forms.Button();
            this.paralellInvoke = new System.Windows.Forms.Button();
            this.taskAndAction = new System.Windows.Forms.Button();
            this.btnThreadLikeTask = new System.Windows.Forms.Button();
            this.btnStarTaskWithCancelToken = new System.Windows.Forms.Button();
            this.btnStopTaskWithCancelToken = new System.Windows.Forms.Button();
            this.startTwoTasks = new System.Windows.Forms.Button();
            this.CancelTwoTasks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timelabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.btnstart2TasksWSepTokenSource = new System.Windows.Forms.Button();
            this.btnCancelShowStockPrice = new System.Windows.Forms.Button();
            this.btnCancelShowTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTask
            // 
            this.newTask.Location = new System.Drawing.Point(21, 27);
            this.newTask.Name = "newTask";
            this.newTask.Size = new System.Drawing.Size(168, 36);
            this.newTask.TabIndex = 0;
            this.newTask.Text = "Task StartNew";
            this.newTask.UseVisualStyleBackColor = true;
            this.newTask.Click += new System.EventHandler(this.newTask_Click);
            // 
            // computeTask
            // 
            this.computeTask.Location = new System.Drawing.Point(21, 103);
            this.computeTask.Name = "computeTask";
            this.computeTask.Size = new System.Drawing.Size(168, 36);
            this.computeTask.TabIndex = 1;
            this.computeTask.Text = "Compute Via Task";
            this.computeTask.UseVisualStyleBackColor = true;
            this.computeTask.Click += new System.EventHandler(this.computeTask_Click);
            // 
            // secondTask
            // 
            this.secondTask.Location = new System.Drawing.Point(21, 169);
            this.secondTask.Name = "secondTask";
            this.secondTask.Size = new System.Drawing.Size(168, 36);
            this.secondTask.TabIndex = 2;
            this.secondTask.Text = "Task2";
            this.secondTask.UseVisualStyleBackColor = true;
            this.secondTask.Click += new System.EventHandler(this.secondTask_Click);
            // 
            // paralellInvoke
            // 
            this.paralellInvoke.Location = new System.Drawing.Point(21, 239);
            this.paralellInvoke.Name = "paralellInvoke";
            this.paralellInvoke.Size = new System.Drawing.Size(168, 36);
            this.paralellInvoke.TabIndex = 3;
            this.paralellInvoke.Text = "Paralell Invoke";
            this.paralellInvoke.UseVisualStyleBackColor = true;
            this.paralellInvoke.Click += new System.EventHandler(this.paralellInvoke_Click);
            // 
            // taskAndAction
            // 
            this.taskAndAction.Location = new System.Drawing.Point(21, 304);
            this.taskAndAction.Name = "taskAndAction";
            this.taskAndAction.Size = new System.Drawing.Size(168, 36);
            this.taskAndAction.TabIndex = 4;
            this.taskAndAction.Text = "Task And Action";
            this.taskAndAction.UseVisualStyleBackColor = true;
            this.taskAndAction.Click += new System.EventHandler(this.taskAndAction_Click);
            // 
            // btnThreadLikeTask
            // 
            this.btnThreadLikeTask.Location = new System.Drawing.Point(21, 367);
            this.btnThreadLikeTask.Name = "btnThreadLikeTask";
            this.btnThreadLikeTask.Size = new System.Drawing.Size(168, 36);
            this.btnThreadLikeTask.TabIndex = 5;
            this.btnThreadLikeTask.Text = "ThreadLike Task";
            this.btnThreadLikeTask.UseVisualStyleBackColor = true;
            this.btnThreadLikeTask.Click += new System.EventHandler(this.btnThreadLikeTask_Click);
            // 
            // btnStarTaskWithCancelToken
            // 
            this.btnStarTaskWithCancelToken.Location = new System.Drawing.Point(274, 27);
            this.btnStarTaskWithCancelToken.Name = "btnStarTaskWithCancelToken";
            this.btnStarTaskWithCancelToken.Size = new System.Drawing.Size(168, 67);
            this.btnStarTaskWithCancelToken.TabIndex = 6;
            this.btnStarTaskWithCancelToken.Text = "Start With CancelToken";
            this.btnStarTaskWithCancelToken.UseVisualStyleBackColor = true;
            this.btnStarTaskWithCancelToken.Click += new System.EventHandler(this.btnStarTaskWithCancelToken_Click);
            // 
            // btnStopTaskWithCancelToken
            // 
            this.btnStopTaskWithCancelToken.Location = new System.Drawing.Point(274, 130);
            this.btnStopTaskWithCancelToken.Name = "btnStopTaskWithCancelToken";
            this.btnStopTaskWithCancelToken.Size = new System.Drawing.Size(168, 59);
            this.btnStopTaskWithCancelToken.TabIndex = 7;
            this.btnStopTaskWithCancelToken.Text = "Stop With CancelToken";
            this.btnStopTaskWithCancelToken.UseVisualStyleBackColor = true;
            this.btnStopTaskWithCancelToken.Click += new System.EventHandler(this.btnStopTaskWithCancelToken_Click);
            // 
            // startTwoTasks
            // 
            this.startTwoTasks.Location = new System.Drawing.Point(274, 214);
            this.startTwoTasks.Name = "startTwoTasks";
            this.startTwoTasks.Size = new System.Drawing.Size(168, 36);
            this.startTwoTasks.TabIndex = 8;
            this.startTwoTasks.Text = "Start Two Tasks";
            this.startTwoTasks.UseVisualStyleBackColor = true;
            this.startTwoTasks.Click += new System.EventHandler(this.startTwoTasks_Click);
            // 
            // CancelTwoTasks
            // 
            this.CancelTwoTasks.Location = new System.Drawing.Point(274, 264);
            this.CancelTwoTasks.Name = "CancelTwoTasks";
            this.CancelTwoTasks.Size = new System.Drawing.Size(168, 36);
            this.CancelTwoTasks.TabIndex = 9;
            this.CancelTwoTasks.Text = "Cancel Two Tasks";
            this.CancelTwoTasks.UseVisualStyleBackColor = true;
            this.CancelTwoTasks.Click += new System.EventHandler(this.CancelTwoTasks_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(837, 53);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(76, 473);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(0, 20);
            this.timelabel.TabIndex = 14;
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(476, 474);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(0, 20);
            this.pricelabel.TabIndex = 15;
            // 
            // btnstart2TasksWSepTokenSource
            // 
            this.btnstart2TasksWSepTokenSource.Location = new System.Drawing.Point(517, 27);
            this.btnstart2TasksWSepTokenSource.Name = "btnstart2TasksWSepTokenSource";
            this.btnstart2TasksWSepTokenSource.Size = new System.Drawing.Size(211, 67);
            this.btnstart2TasksWSepTokenSource.TabIndex = 16;
            this.btnstart2TasksWSepTokenSource.Text = "start2TasksWSepTokenSource";
            this.btnstart2TasksWSepTokenSource.UseVisualStyleBackColor = true;
            this.btnstart2TasksWSepTokenSource.Click += new System.EventHandler(this.btnstart2TasksWSepTokenSource_Click);
            // 
            // btnCancelShowStockPrice
            // 
            this.btnCancelShowStockPrice.Location = new System.Drawing.Point(526, 130);
            this.btnCancelShowStockPrice.Name = "btnCancelShowStockPrice";
            this.btnCancelShowStockPrice.Size = new System.Drawing.Size(202, 59);
            this.btnCancelShowStockPrice.TabIndex = 17;
            this.btnCancelShowStockPrice.Text = "Cancel Show Stock Price";
            this.btnCancelShowStockPrice.UseVisualStyleBackColor = true;
            this.btnCancelShowStockPrice.Click += new System.EventHandler(this.btnCancelShowStockPrice_Click);
            // 
            // btnCancelShowTime
            // 
            this.btnCancelShowTime.Location = new System.Drawing.Point(517, 239);
            this.btnCancelShowTime.Name = "btnCancelShowTime";
            this.btnCancelShowTime.Size = new System.Drawing.Size(211, 61);
            this.btnCancelShowTime.TabIndex = 18;
            this.btnCancelShowTime.Text = "Cancel Show Time";
            this.btnCancelShowTime.UseVisualStyleBackColor = true;
            this.btnCancelShowTime.Click += new System.EventHandler(this.btnCancelShowTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 506);
            this.Controls.Add(this.btnCancelShowTime);
            this.Controls.Add(this.btnCancelShowStockPrice);
            this.Controls.Add(this.btnstart2TasksWSepTokenSource);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelTwoTasks);
            this.Controls.Add(this.startTwoTasks);
            this.Controls.Add(this.btnStopTaskWithCancelToken);
            this.Controls.Add(this.btnStarTaskWithCancelToken);
            this.Controls.Add(this.btnThreadLikeTask);
            this.Controls.Add(this.taskAndAction);
            this.Controls.Add(this.paralellInvoke);
            this.Controls.Add(this.secondTask);
            this.Controls.Add(this.computeTask);
            this.Controls.Add(this.newTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newTask;
        private System.Windows.Forms.Button computeTask;
        private System.Windows.Forms.Button secondTask;
        private System.Windows.Forms.Button paralellInvoke;
        private System.Windows.Forms.Button taskAndAction;
        private System.Windows.Forms.Button btnThreadLikeTask;
        private System.Windows.Forms.Button btnStarTaskWithCancelToken;
        private System.Windows.Forms.Button btnStopTaskWithCancelToken;
        private System.Windows.Forms.Button startTwoTasks;
        private System.Windows.Forms.Button CancelTwoTasks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Button btnstart2TasksWSepTokenSource;
        private System.Windows.Forms.Button btnCancelShowStockPrice;
        private System.Windows.Forms.Button btnCancelShowTime;
    }
}

