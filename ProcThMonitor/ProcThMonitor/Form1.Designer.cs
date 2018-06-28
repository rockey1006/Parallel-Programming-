namespace ProcThMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnListProcesses = new System.Windows.Forms.Button();
            this.lbProcs = new System.Windows.Forms.ListBox();
            this.lblProcessInfo = new System.Windows.Forms.Label();
            this.txtThreadsInfo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnListProcesses
            // 
            this.btnListProcesses.Location = new System.Drawing.Point(80, 58);
            this.btnListProcesses.Name = "btnListProcesses";
            this.btnListProcesses.Size = new System.Drawing.Size(228, 98);
            this.btnListProcesses.TabIndex = 0;
            this.btnListProcesses.Text = "List Processes";
            this.btnListProcesses.UseVisualStyleBackColor = true;
            this.btnListProcesses.Click += new System.EventHandler(this.btnListProcesses_Click);
            // 
            // lbProcs
            // 
            this.lbProcs.FormattingEnabled = true;
            this.lbProcs.ItemHeight = 20;
            this.lbProcs.Location = new System.Drawing.Point(89, 190);
            this.lbProcs.Name = "lbProcs";
            this.lbProcs.Size = new System.Drawing.Size(196, 124);
            this.lbProcs.TabIndex = 1;
            // 
            // lblProcessInfo
            // 
            this.lblProcessInfo.Location = new System.Drawing.Point(589, 75);
            this.lblProcessInfo.Name = "lblProcessInfo";
            this.lblProcessInfo.Size = new System.Drawing.Size(149, 66);
            this.lblProcessInfo.TabIndex = 2;
            this.lblProcessInfo.Text = "label1";
            // 
            // txtThreadsInfo
            // 
            this.txtThreadsInfo.Location = new System.Drawing.Point(543, 190);
            this.txtThreadsInfo.Multiline = true;
            this.txtThreadsInfo.Name = "txtThreadsInfo";
            this.txtThreadsInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtThreadsInfo.Size = new System.Drawing.Size(100, 26);
            this.txtThreadsInfo.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 537);
            this.Controls.Add(this.txtThreadsInfo);
            this.Controls.Add(this.lblProcessInfo);
            this.Controls.Add(this.lbProcs);
            this.Controls.Add(this.btnListProcesses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListProcesses;
        private System.Windows.Forms.ListBox lbProcs;
        private System.Windows.Forms.Label lblProcessInfo;
        private System.Windows.Forms.TextBox txtThreadsInfo;
        private System.Windows.Forms.Timer timer1;
    }
}

