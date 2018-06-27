namespace Threading2
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnGettemperature = new System.Windows.Forms.Button();
            this.btnGetStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(43, 46);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(153, 74);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnGettemperature
            // 
            this.btnGettemperature.Location = new System.Drawing.Point(43, 149);
            this.btnGettemperature.Name = "btnGettemperature";
            this.btnGettemperature.Size = new System.Drawing.Size(153, 64);
            this.btnGettemperature.TabIndex = 1;
            this.btnGettemperature.Text = "Get temperature";
            this.btnGettemperature.UseVisualStyleBackColor = true;
            this.btnGettemperature.Click += new System.EventHandler(this.btnGettemperature_Click);
            // 
            // btnGetStock
            // 
            this.btnGetStock.Location = new System.Drawing.Point(43, 254);
            this.btnGetStock.Name = "btnGetStock";
            this.btnGetStock.Size = new System.Drawing.Size(153, 70);
            this.btnGetStock.TabIndex = 2;
            this.btnGetStock.Text = "Get Stock Price";
            this.btnGetStock.UseVisualStyleBackColor = true;
            this.btnGetStock.Click += new System.EventHandler(this.btnGetStock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 613);
            this.Controls.Add(this.btnGetStock);
            this.Controls.Add(this.btnGettemperature);
            this.Controls.Add(this.btnCompute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnGettemperature;
        private System.Windows.Forms.Button btnGetStock;
    }
}