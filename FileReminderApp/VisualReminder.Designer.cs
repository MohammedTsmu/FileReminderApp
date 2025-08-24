namespace FileReminderApp
{
    partial class VisualReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualReminder));
            this.lblVisualReminder = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisualReminder
            // 
            this.lblVisualReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVisualReminder.Appearance.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualReminder.Appearance.Options.UseFont = true;
            this.lblVisualReminder.Location = new System.Drawing.Point(136, 204);
            this.lblVisualReminder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblVisualReminder.Name = "lblVisualReminder";
            this.lblVisualReminder.Size = new System.Drawing.Size(838, 43);
            this.lblVisualReminder.TabIndex = 0;
            this.lblVisualReminder.Text = "File Reminder has opened a new file. Check it now!";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Georgia", 22.2F);
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(0, 332);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1031, 118);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close This Window";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.svgImageBox1.Location = new System.Drawing.Point(56, 190);
            this.svgImageBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(70, 70);
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 2;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // VisualReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblVisualReminder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualReminder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Reminder";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblVisualReminder;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
    }
}