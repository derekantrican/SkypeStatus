namespace SkypeStatus
{
    partial class Settings
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
            this.labelCustomTime = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBoxGFW = new System.Windows.Forms.CheckBox();
            this.linkLabelGFW = new System.Windows.Forms.LinkLabel();
            this.checkBoxBeep = new System.Windows.Forms.CheckBox();
            this.dateTimePickerLimit = new System.Windows.Forms.DateTimePicker();
            this.labelLimit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCustomTime
            // 
            this.labelCustomTime.AutoSize = true;
            this.labelCustomTime.Location = new System.Drawing.Point(13, 13);
            this.labelCustomTime.Name = "labelCustomTime";
            this.labelCustomTime.Size = new System.Drawing.Size(113, 13);
            this.labelCustomTime.TabIndex = 0;
            this.labelCustomTime.Text = "Set the timer manually:";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(115, 174);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(50, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(171, 174);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(140, 9);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2016, 7, 8, 0, 0, 0, 0);
            // 
            // checkBoxGFW
            // 
            this.checkBoxGFW.AutoSize = true;
            this.checkBoxGFW.Location = new System.Drawing.Point(16, 107);
            this.checkBoxGFW.Name = "checkBoxGFW";
            this.checkBoxGFW.Size = new System.Drawing.Size(183, 30);
            this.checkBoxGFW.TabIndex = 4;
            this.checkBoxGFW.Text = "Enable functionality for GFW\r\nChrome Extension (Coming Soon)\r\n";
            this.checkBoxGFW.UseVisualStyleBackColor = true;
            // 
            // linkLabelGFW
            // 
            this.linkLabelGFW.AutoSize = true;
            this.linkLabelGFW.Location = new System.Drawing.Point(197, 113);
            this.linkLabelGFW.Name = "linkLabelGFW";
            this.linkLabelGFW.Size = new System.Drawing.Size(24, 13);
            this.linkLabelGFW.TabIndex = 5;
            this.linkLabelGFW.TabStop = true;
            this.linkLabelGFW.Text = "info";
            this.linkLabelGFW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGFW_LinkClicked);
            // 
            // checkBoxBeep
            // 
            this.checkBoxBeep.AutoSize = true;
            this.checkBoxBeep.Checked = true;
            this.checkBoxBeep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBeep.Location = new System.Drawing.Point(16, 138);
            this.checkBoxBeep.Name = "checkBoxBeep";
            this.checkBoxBeep.Size = new System.Drawing.Size(165, 30);
            this.checkBoxBeep.TabIndex = 6;
            this.checkBoxBeep.Text = "Turn on \"warning beeps\"\r\n(beep when timer is near 1 hr)";
            this.checkBoxBeep.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerLimit
            // 
            this.dateTimePickerLimit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerLimit.Location = new System.Drawing.Point(140, 51);
            this.dateTimePickerLimit.Name = "dateTimePickerLimit";
            this.dateTimePickerLimit.ShowUpDown = true;
            this.dateTimePickerLimit.Size = new System.Drawing.Size(81, 20);
            this.dateTimePickerLimit.TabIndex = 8;
            this.dateTimePickerLimit.Value = new System.DateTime(2016, 7, 8, 0, 0, 0, 0);
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Location = new System.Drawing.Point(12, 36);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(189, 26);
            this.labelLimit.TabIndex = 7;
            this.labelLimit.Text = "\"Critical threshold\" (when timer is close\r\nto this, beeps will go off):";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(233, 209);
            this.Controls.Add(this.dateTimePickerLimit);
            this.Controls.Add(this.labelLimit);
            this.Controls.Add(this.checkBoxBeep);
            this.Controls.Add(this.linkLabelGFW);
            this.Controls.Add(this.checkBoxGFW);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelCustomTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomTime;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox checkBoxGFW;
        private System.Windows.Forms.LinkLabel linkLabelGFW;
        private System.Windows.Forms.CheckBox checkBoxBeep;
        private System.Windows.Forms.DateTimePicker dateTimePickerLimit;
        private System.Windows.Forms.Label labelLimit;
    }
}