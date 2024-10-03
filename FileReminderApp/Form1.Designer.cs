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
            this.lstTimes = new System.Windows.Forms.ListBox();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.timePickerReminder = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteTime = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.btnUploadFiles = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTimes
            // 
            this.lstTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTimes.ForeColor = System.Drawing.SystemColors.Control;
            this.lstTimes.FormattingEnabled = true;
            this.lstTimes.ItemHeight = 20;
            this.lstTimes.Location = new System.Drawing.Point(7, 114);
            this.lstTimes.Name = "lstTimes";
            this.lstTimes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTimes.Size = new System.Drawing.Size(544, 324);
            this.lstTimes.TabIndex = 2;
            // 
            // btnAddTime
            // 
            this.btnAddTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTime.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddTime.Location = new System.Drawing.Point(451, 444);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(216, 114);
            this.btnAddTime.TabIndex = 4;
            this.btnAddTime.Text = "Add Time (Selected Files)";
            this.btnAddTime.UseVisualStyleBackColor = false;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveSettings.Location = new System.Drawing.Point(673, 444);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(216, 114);
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // timePickerReminder
            // 
            this.timePickerReminder.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerReminder.Location = new System.Drawing.Point(12, 18);
            this.timePickerReminder.Name = "timePickerReminder";
            this.timePickerReminder.ShowUpDown = true;
            this.timePickerReminder.Size = new System.Drawing.Size(539, 22);
            this.timePickerReminder.TabIndex = 6;
            // 
            // btnDeleteTime
            // 
            this.btnDeleteTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTime.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteTime.Location = new System.Drawing.Point(895, 444);
            this.btnDeleteTime.Name = "btnDeleteTime";
            this.btnDeleteTime.Size = new System.Drawing.Size(216, 114);
            this.btnDeleteTime.TabIndex = 7;
            this.btnDeleteTime.Text = "Delete Selected Time";
            this.btnDeleteTime.UseVisualStyleBackColor = false;
            this.btnDeleteTime.Click += new System.EventHandler(this.btnDeleteTime_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listViewFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(567, 114);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(544, 324);
            this.listViewFiles.TabIndex = 9;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.List;
            // 
            // btnUploadFiles
            // 
            this.btnUploadFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUploadFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUploadFiles.Location = new System.Drawing.Point(7, 444);
            this.btnUploadFiles.Name = "btnUploadFiles";
            this.btnUploadFiles.Size = new System.Drawing.Size(216, 114);
            this.btnUploadFiles.TabIndex = 10;
            this.btnUploadFiles.Text = "Upload File/s";
            this.btnUploadFiles.UseVisualStyleBackColor = false;
            this.btnUploadFiles.Click += new System.EventHandler(this.btnUploadFiles_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteFile.Location = new System.Drawing.Point(229, 444);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(216, 114);
            this.btnDeleteFile.TabIndex = 11;
            this.btnDeleteFile.Text = "Delete Selected Files";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reminders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Uploaded Files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1123, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnUploadFiles);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.btnDeleteTime);
            this.Controls.Add(this.timePickerReminder);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.lstTimes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstTimes;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.DateTimePicker timePickerReminder;
        private System.Windows.Forms.Button btnDeleteTime;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Button btnUploadFiles;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

