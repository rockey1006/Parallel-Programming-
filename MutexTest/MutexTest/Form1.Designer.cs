namespace MutexTest
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
            this.btnMutexTest = new System.Windows.Forms.Button();
            this.sb1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMutexTest
            // 
            this.btnMutexTest.Location = new System.Drawing.Point(101, 96);
            this.btnMutexTest.Name = "btnMutexTest";
            this.btnMutexTest.Size = new System.Drawing.Size(199, 67);
            this.btnMutexTest.TabIndex = 0;
            this.btnMutexTest.Text = "Mutex Test";
            this.btnMutexTest.UseVisualStyleBackColor = true;
            this.btnMutexTest.Click += new System.EventHandler(this.btnMutexTest_Click);
            // 
            // sb1
            // 
            this.sb1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sb1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.sb1.Location = new System.Drawing.Point(0, 522);
            this.sb1.Name = "sb1";
            this.sb1.Size = new System.Drawing.Size(762, 30);
            this.sb1.TabIndex = 1;
            this.sb1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 552);
            this.Controls.Add(this.sb1);
            this.Controls.Add(this.btnMutexTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sb1.ResumeLayout(false);
            this.sb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMutexTest;
        private System.Windows.Forms.StatusStrip sb1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

