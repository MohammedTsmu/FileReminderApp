namespace FileReminderApp
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
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lstTimes = new System.Windows.Forms.ListBox();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.timePickerReminder = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteTime = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(568, 76);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(152, 54);
            this.btnUploadFile.TabIndex = 0;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(68, 76);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(477, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // lstTimes
            // 
            this.lstTimes.FormattingEnabled = true;
            this.lstTimes.ItemHeight = 16;
            this.lstTimes.Location = new System.Drawing.Point(68, 116);
            this.lstTimes.Name = "lstTimes";
            this.lstTimes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTimes.Size = new System.Drawing.Size(477, 260);
            this.lstTimes.TabIndex = 2;
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(568, 136);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(152, 54);
            this.btnAddTime.TabIndex = 4;
            this.btnAddTime.Text = "Add Time";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(568, 196);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(152, 54);
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // timePickerReminder
            // 
            this.timePickerReminder.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerReminder.Location = new System.Drawing.Point(68, 48);
            this.timePickerReminder.Name = "timePickerReminder";
            this.timePickerReminder.ShowUpDown = true;
            this.timePickerReminder.Size = new System.Drawing.Size(477, 22);
            this.timePickerReminder.TabIndex = 6;
            // 
            // btnDeleteTime
            // 
            this.btnDeleteTime.Location = new System.Drawing.Point(568, 256);
            this.btnDeleteTime.Name = "btnDeleteTime";
            this.btnDeleteTime.Size = new System.Drawing.Size(152, 54);
            this.btnDeleteTime.TabIndex = 7;
            this.btnDeleteTime.Text = "Delete Selected Time";
            this.btnDeleteTime.UseVisualStyleBackColor = true;
            this.btnDeleteTime.Click += new System.EventHandler(this.btnDeleteTime_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(568, 316);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(152, 54);
            this.btnRemoveFile.TabIndex = 8;
            this.btnRemoveFile.Text = "Remove Uploaded File";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.btnDeleteTime);
            this.Controls.Add(this.timePickerReminder);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.lstTimes);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnUploadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.ListBox lstTimes;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.DateTimePicker timePickerReminder;
        private System.Windows.Forms.Button btnDeleteTime;
        private System.Windows.Forms.Button btnRemoveFile;
    }
}

