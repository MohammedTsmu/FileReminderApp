using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;

namespace FileReminderApp
{
    public partial class Form1 : Form
    {
        // Dictionary لتخزين الملفات والتذكيرات
        private Dictionary<string, List<string>> fileReminders = new Dictionary<string, List<string>>();

        // إضافة كائن NotifyIcon لعرض أيقونة التطبيق في System Tray
        private NotifyIcon trayIcon;

        public Form1()
        {
            InitializeComponent();
            LoadSettings();

            // إعداد NotifyIcon
            trayIcon = new NotifyIcon
            {
                Icon = this.Icon, // استخدام أيقونة التطبيق
                Text = "File Reminder App", // النص الذي يظهر عند وضع المؤشر على الأيقونة في System Tray
                Visible = true // التأكد من إظهار الأيقونة في System Tray
            };

            // إضافة خيار للنقر المزدوج على الأيقونة لإظهار التطبيق مرة أخرى
            trayIcon.DoubleClick += (sender, e) =>
            {
                this.Show();
                this.WindowState = FormWindowState.Normal; // إعادة النافذة لحالتها الطبيعية
                this.ShowInTaskbar = true; // إظهار النافذة في شريط المهام
            };
        }

        // هذا الحدث يتم استدعاؤه عند تحميل النموذج
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings(); // تحميل الإعدادات المحفوظة
            SetupReminderTimer(); // تشغيل المؤقت
        }

        // كود التعامل مع زر Minimize
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide(); // إخفاء النافذة
                this.ShowInTaskbar = false; // إخفاء النافذة من شريط المهام
            }
        }

        // كود التعامل مع زر Close (X) لمنع إغلاق التطبيق
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true; // إلغاء عملية الإغلاق
            this.Hide(); // إخفاء النافذة
            this.ShowInTaskbar = false; // إخفاء النافذة من شريط المهام
            base.OnFormClosing(e);
        }

        // كود إضافة ملفات متعددة
        private void btnUploadFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files|*.txt|Word Documents|*.docx",
                Multiselect = true // السماح بتحميل ملفات متعددة
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    // Get only the file name from the full path
                    string fileName = System.IO.Path.GetFileName(filePath);
                    var listViewItem = new ListViewItem(fileName)
                    {
                        // Store the full path in the Tag property for future reference
                        Tag = filePath
                    };
                    listViewFiles.Items.Add(listViewItem);
                }

                MessageBox.Show("تم تحميل الملفات بنجاح!", "تحميل الملفات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في تحميل الملفات!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // كود إضافة وقت تذكير جديد باستخدام TimePicker
        private void btnAddTime_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                string selectedTime = timePickerReminder.Value.ToString("HH:mm");
                string selectedFile = listViewFiles.SelectedItems[0].Tag.ToString(); // الحصول على المسار الكامل للملف

                // تحقق من عدم وجود التذكير مسبقًا في fileReminders
                if (fileReminders.ContainsKey(selectedFile))
                {
                    if (!fileReminders[selectedFile].Contains(selectedTime)) // التأكد من عدم تكرار التذكير
                    {
                        fileReminders[selectedFile].Add(selectedTime); // إضافة التذكير إلى الملف
                        lstTimes.Items.Add($"{selectedFile} - {selectedTime}"); // إضافة التذكير إلى القائمة لعرضه
                        MessageBox.Show("تم إضافة التذكير بنجاح!", "إضافة تذكير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("هذا التذكير موجود مسبقًا!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // إضافة الملف الجديد مع التذكير
                    fileReminders[selectedFile] = new List<string> { selectedTime };
                    lstTimes.Items.Add($"{selectedFile} - {selectedTime}"); // إضافة التذكير إلى القائمة لعرضه
                    MessageBox.Show("تم إضافة التذكير بنجاح!", "إضافة تذكير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("الرجاء تحديد ملف لإضافة التذكير إليه!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        // كود التذكير بناءً على الملفات المرفوعة
        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            foreach (var fileReminder in fileReminders)
            {
                string filePath = fileReminder.Key; // المسار الكامل للملف
                List<string> reminders = fileReminder.Value; // التذكيرات الخاصة بهذا الملف

                foreach (string time in reminders)
                {
                    if (DateTime.TryParse(time, out DateTime reminderTime))
                    {
                        if (currentTime.Hour == reminderTime.Hour && currentTime.Minute == reminderTime.Minute)
                        {
                            ShowReminder(filePath); // تمرير المسار الكامل للملف
                        }
                    }
                }
            }
        }

        //تعديل دالة ShowReminder للتعامل مع ملفات متعددة
        // تعديل ShowReminder لفتح الملف باستخدام المسار الكامل
        private void ShowReminder(string filePath)
        {
            try
            {
                // عرض المسار الكامل في رسالة للتأكد من أن المسار صحيح
                MessageBox.Show($"فتح الملف: {filePath}", "تذكير", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // فتح الملف باستخدام المسار الكامل
                System.Diagnostics.Process.Start(filePath);
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
                if (Properties.Settings.Default.UploadedFiles == null)
                {
                    Properties.Settings.Default.UploadedFiles = new StringCollection();
                }

                if (Properties.Settings.Default.ReminderTimes == null)
                {
                    Properties.Settings.Default.ReminderTimes = new StringCollection();
                }

                // مسح الملفات القديمة والتذكيرات القديمة
                Properties.Settings.Default.UploadedFiles.Clear();
                Properties.Settings.Default.ReminderTimes.Clear();

                // حفظ الملفات والتذكيرات في الإعدادات
                foreach (var fileReminder in fileReminders)
                {
                    string filePath = fileReminder.Key;
                    List<string> reminders = fileReminder.Value;

                    // حفظ المسار الكامل للملف
                    Properties.Settings.Default.UploadedFiles.Add(filePath);

                    // حفظ التذكيرات المرتبطة بهذا الملف
                    foreach (var reminder in reminders)
                    {
                        Properties.Settings.Default.ReminderTimes.Add($"{filePath}|{reminder}"); // نستخدم | للفصل بين المسار والوقت
                    }
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings(); // حفظ الإعدادات عند إغلاق التطبيق
        }

        // تحميل الإعدادات
        private void LoadSettings()
        {
            // تحميل الملفات المحفوظة إذا كانت موجودة
            if (Properties.Settings.Default.UploadedFiles != null)
            {
                foreach (string filePath in Properties.Settings.Default.UploadedFiles)
                {
                    // التأكد من تحميل المسار الكامل للملف وليس فقط الاسم
                    if (!listViewFiles.Items.Cast<ListViewItem>().Any(item => item.Tag != null && item.Tag.ToString() == filePath))
                    {
                        var listViewItem = new ListViewItem(System.IO.Path.GetFileName(filePath))
                        {
                            Tag = filePath // تخزين المسار الكامل في Tag
                        };

                        listViewFiles.Items.Add(listViewItem);
                    }
                }
            }

            // تحميل التذكيرات إذا كانت موجودة
            if (Properties.Settings.Default.ReminderTimes != null)
            {
                foreach (string reminder in Properties.Settings.Default.ReminderTimes)
                {
                    // تقسيم السلسلة إلى مسار الملف والتذكير باستخدام |
                    string[] parts = reminder.Split('|');
                    if (parts.Length == 2)
                    {
                        string filePath = parts[0];
                        string time = parts[1];

                        // التأكد من أن الملف موجود
                        string fileName = System.IO.Path.GetFileName(filePath);
                        if (!fileReminders.ContainsKey(filePath))
                        {
                            fileReminders[filePath] = new List<string>();
                        }

                        // تأكد من عدم إضافة التذكير مرة أخرى إذا كان موجودًا بالفعل
                        if (!fileReminders[filePath].Contains(time))
                        {
                            fileReminders[filePath].Add(time);
                            lstTimes.Items.Add($"{fileName} - {time}");
                        }
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
            if (lstTimes.SelectedItems.Count > 0)
            {
                // جمع الأوقات المحددة في قائمة مؤقتة لحذفها
                var selectedTimes = lstTimes.SelectedItems.Cast<string>().ToList();

                foreach (var time in selectedTimes)
                {
                    lstTimes.Items.Remove(time);

                    // تقسيم السلسلة إلى اسم الملف والوقت
                    string[] parts = time.Split('-');
                    if (parts.Length == 2)
                    {
                        string filePath = parts[0].Trim();
                        string reminderTime = parts[1].Trim();

                        // حذف التذكير من fileReminders
                        if (fileReminders.ContainsKey(filePath))
                        {
                            fileReminders[filePath].Remove(reminderTime);

                            // إذا لم يعد هناك تذكيرات للملف، قم بحذفه من fileReminders
                            if (fileReminders[filePath].Count == 0)
                            {
                                fileReminders.Remove(filePath);
                            }
                        }
                    }
                }

                MessageBox.Show("تم حذف الأوقات المحددة بنجاح!", "حذف الأوقات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("الرجاء تحديد الأوقات المراد حذفها!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // كود تحديث قائمة التذكيرات
        private void UpdateTimesList()
        {
            // مسح القائمة الحالية
            lstTimes.Items.Clear();

            // إعادة إضافة التذكيرات المتبقية في fileReminders إلى lstTimes
            foreach (var fileReminder in fileReminders)
            {
                string fileName = fileReminder.Key;
                List<string> reminders = fileReminder.Value;

                foreach (string reminder in reminders)
                {
                    lstTimes.Items.Add($"{fileName} - {reminder}");
                }
            }
        }

        // كود حذف الملف المحدد
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewFiles.SelectedItems)
                {
                    string filePath = selectedItem.Tag.ToString();

                    // حذف الملف من ListView
                    listViewFiles.Items.Remove(selectedItem);

                    // حذف التذكيرات المرتبطة بهذا الملف من fileReminders
                    if (fileReminders.ContainsKey(filePath))
                    {
                        fileReminders.Remove(filePath);
                    }

                    // تحديث قائمة التذكيرات (lstTimes) بعد حذف الملف
                    UpdateTimesList();
                }

                MessageBox.Show("تم حذف الملف بنجاح!", "حذف الملف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("الرجاء تحديد ملف لحذفه!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
