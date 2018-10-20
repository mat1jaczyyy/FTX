﻿namespace PPTTools {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelDelimiter = new System.Windows.Forms.Label();
            this.ScanTimer = new System.Windows.Forms.Timer(this.components);
            this.labelPPS = new System.Windows.Forms.Label();
            this.labelAPM = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelKPP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelP1
            // 
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelP1.Location = new System.Drawing.Point(26, 11);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(78, 26);
            this.labelP1.TabIndex = 0;
            this.labelP1.Text = "0";
            this.labelP1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelP2
            // 
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelP2.Location = new System.Drawing.Point(117, 11);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(76, 26);
            this.labelP2.TabIndex = 0;
            this.labelP2.Text = "0";
            // 
            // labelDelimiter
            // 
            this.labelDelimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelimiter.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDelimiter.Location = new System.Drawing.Point(81, 11);
            this.labelDelimiter.Name = "labelDelimiter";
            this.labelDelimiter.Size = new System.Drawing.Size(59, 26);
            this.labelDelimiter.TabIndex = 0;
            this.labelDelimiter.Text = "-";
            this.labelDelimiter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScanTimer
            // 
            this.ScanTimer.Enabled = true;
            this.ScanTimer.Interval = 3;
            this.ScanTimer.Tick += new System.EventHandler(this.ScanTimer_Tick);
            // 
            // labelPPS
            // 
            this.labelPPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPPS.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPPS.Location = new System.Drawing.Point(37, 47);
            this.labelPPS.Name = "labelPPS";
            this.labelPPS.Size = new System.Drawing.Size(165, 26);
            this.labelPPS.TabIndex = 1;
            this.labelPPS.Text = "0.000 PPS";
            this.labelPPS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAPM
            // 
            this.labelAPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPM.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAPM.Location = new System.Drawing.Point(40, 83);
            this.labelAPM.Name = "labelAPM";
            this.labelAPM.Size = new System.Drawing.Size(165, 26);
            this.labelAPM.TabIndex = 1;
            this.labelAPM.Text = "0.000 APM";
            this.labelAPM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelRating
            // 
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRating.Location = new System.Drawing.Point(17, 149);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(181, 26);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "2000 > 50000";
            this.labelRating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelKPP
            // 
            this.labelKPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKPP.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelKPP.Location = new System.Drawing.Point(37, 116);
            this.labelKPP.Name = "labelKPP";
            this.labelKPP.Size = new System.Drawing.Size(165, 26);
            this.labelKPP.TabIndex = 2;
            this.labelKPP.Text = "0.000 KPP";
            this.labelKPP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(218, 187);
            this.Controls.Add(this.labelKPP);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelAPM);
            this.Controls.Add(this.labelPPS);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.labelDelimiter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PPT Tools";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelDelimiter;
        private System.Windows.Forms.Timer ScanTimer;
        private System.Windows.Forms.Label labelPPS;
        private System.Windows.Forms.Label labelAPM;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelKPP;
    }
}

