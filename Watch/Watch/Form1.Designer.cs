﻿namespace Watch
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
            this.label1 = new System.Windows.Forms.Label();
            this.START = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(361, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(253, 165);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(75, 23);
            this.START.TabIndex = 1;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(351, 165);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(75, 23);
            this.RESET.TabIndex = 2;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // STOP
            // 
            this.STOP.BackColor = System.Drawing.Color.IndianRed;
            this.STOP.Location = new System.Drawing.Point(451, 165);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(75, 23);
            this.STOP.TabIndex = 3;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = false;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(253, 209);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(273, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(347, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "StopWatch OP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.START);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
    }
}

