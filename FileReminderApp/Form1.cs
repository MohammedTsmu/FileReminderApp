using System;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace FileReminderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Load += new System.EventHandler(this.Form1_Load);
            LoadSettings();

            // ربط زر الحفظ بحدث الحفظ
            //btnSaveSettings.Click += new EventHandler(this.btnSaveSettings_Click);
        }


        // هذا الحدث يتم استدعاؤه عند تحميل النموذج
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings(); // تحميل الإعدادات المحفوظة
            SetupReminderTimer(); // تشغيل المؤقت
        }


        // كود اختيار الملف
        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|Word Documents|*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
                MessageBox.Show("تم تحميل الملف بنجاح!", "تحميل الملف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في تحميل الملف!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // كود إضافة وقت تذكير جديد
        // كود إضافة وقت تذكير جديد باستخدام TimePicker
        private void btnAddTime_Click(object sender, EventArgs e)
        {
            string selectedTime = timePickerReminder.Value.ToString("HH:mm");

            if (!lstTimes.Items.Contains(selectedTime)) // التأكد من أن الوقت غير مكرر
            {
                lstTimes.Items.Add(selectedTime);
                MessageBox.Show("تم إضافة الوقت بنجاح!", "إضافة وقت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("الوقت موجود بالفعل في القائمة!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //Timer Settings
        private Timer reminderTimer = new Timer();

        private void SetupReminderTimer()
        {
            reminderTimer.Interval = 60000; // يتم الفحص كل دقيقة
            reminderTimer.Tick += ReminderTimer_Tick;
            reminderTimer.Start();
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            foreach (string time in lstTimes.Items)
            {
                if (DateTime.TryParse(time, out DateTime reminderTime))
                {
                    if (currentTime.Hour == reminderTime.Hour && currentTime.Minute == reminderTime.Minute)
                    {
                        ShowReminder();
                    }
                }
            }
        }


        private void ShowReminder()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtFilePath.Text)) // التحقق من وجود مسار الملف
                {
                    // إشعار المستخدم وفتح الملف
                    MessageBox.Show("تذكير بالملف!", "تذكير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(txtFilePath.Text);
                }
                else
                {
                    MessageBox.Show("لم يتم تحميل أي ملف!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"فشل في فتح الملف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // حفظ الإعدادات
        private void SaveSettings()
        {
            try
            {
                // حفظ مسار الملف
                Properties.Settings.Default.FilePath = txtFilePath.Text;

                // التأكد من وجود مجموعة لحفظ الأوقات
                if (Properties.Settings.Default.ReminderTimes == null)
                {
                    Properties.Settings.Default.ReminderTimes = new System.Collections.Specialized.StringCollection();
                }

                // مسح الأوقات القديمة
                Properties.Settings.Default.ReminderTimes.Clear();

                // إضافة الأوقات الجديدة من القائمة
                foreach (string time in lstTimes.Items)
                {
                    Properties.Settings.Default.ReminderTimes.Add(time);
                }

                // حفظ الإعدادات
                Properties.Settings.Default.Save();

                MessageBox.Show("تم حفظ الإعدادات بنجاح!", "حفظ الإعدادات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"فشل في حفظ الإعدادات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // تحميل الإعدادات
        private void LoadSettings()
        {
            // تحميل مسار الملف
            txtFilePath.Text = Properties.Settings.Default.FilePath;

            // تحميل أوقات التذكير إذا كانت محفوظة
            if (Properties.Settings.Default.ReminderTimes != null)
            {
                foreach (string time in Properties.Settings.Default.ReminderTimes)
                {
                    if (!lstTimes.Items.Contains(time)) // التأكد من أن الوقت غير مكرر
                    {
                        lstTimes.Items.Add(time);
                    }
                }
            }
        }



        // حدث الحفظ عند الضغط على زر الحفظ
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings(); // استدعاء دالة حفظ الإعدادات
        }

        // كود حذف الوقت المحدد من القائمة
        private void btnDeleteTime_Click(object sender, EventArgs e)
        {
            if (lstTimes.SelectedItem != null) // التأكد من تحديد وقت
            {
                lstTimes.Items.Remove(lstTimes.SelectedItem);
                MessageBox.Show("تم حذف الوقت بنجاح!", "حذف الوقت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("الرجاء تحديد وقت لحذفه!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // كود إزالة مسار الملف
        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilePath.Text)) // التأكد من وجود مسار ملف
            {
                txtFilePath.Clear(); // مسح مسار الملف
                MessageBox.Show("تم إزالة الملف بنجاح!", "إزالة الملف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لا يوجد ملف لإزالته!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
