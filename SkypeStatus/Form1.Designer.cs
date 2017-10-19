namespace SkypeStatus
{
    partial class SkypeStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkypeStatus));
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.pictureBoxAway = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAway)).BeginInit();
            this.SuspendLayout();
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.AutoSize = true;
            this.labelElapsedTime.Location = new System.Drawing.Point(122, 213);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(74, 13);
            this.labelElapsedTime.TabIndex = 2;
            this.labelElapsedTime.Text = "Elapsed Time:";
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(202, 213);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(49, 13);
            this.labelClock.TabIndex = 3;
            this.labelClock.Text = "00:00:00";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(8, 208);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(44, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkypeStatus.Properties.Resources.gear;
            this.pictureBox1.Location = new System.Drawing.Point(238, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxReturn
            // 
            this.pictureBoxReturn.Image = global::SkypeStatus.Properties.Resources.SkypeAvailable;
            this.pictureBoxReturn.Location = new System.Drawing.Point(150, 44);
            this.pictureBoxReturn.Name = "pictureBoxReturn";
            this.pictureBoxReturn.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReturn.TabIndex = 1;
            this.pictureBoxReturn.TabStop = false;
            this.pictureBoxReturn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxReturn_MouseDown);
            this.pictureBoxReturn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxReturn_MouseUp);
            // 
            // pictureBoxAway
            // 
            this.pictureBoxAway.Image = global::SkypeStatus.Properties.Resources.SkypeBusy;
            this.pictureBoxAway.Location = new System.Drawing.Point(15, 44);
            this.pictureBoxAway.Name = "pictureBoxAway";
            this.pictureBoxAway.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAway.TabIndex = 0;
            this.pictureBoxAway.TabStop = false;
            this.pictureBoxAway.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAway_MouseDown);
            this.pictureBoxAway.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAway_MouseUp);
            // 
            // SkypeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(259, 235);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.labelElapsedTime);
            this.Controls.Add(this.pictureBoxReturn);
            this.Controls.Add(this.pictureBoxAway);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SkypeStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SkypeStatus";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAway;
        private System.Windows.Forms.PictureBox pictureBoxReturn;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

