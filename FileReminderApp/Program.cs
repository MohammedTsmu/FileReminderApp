//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Microsoft.Win32;


//namespace FileReminderApp
//{
//    internal static class Program
//    {
//        /// <summary>
//        /// The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new Form1());
//        }
//    }
//}

using System;
using System.Threading;
using System.Windows.Forms;

namespace FileReminderApp
{
    internal static class Program
    {
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {
            const string appName = "FileReminderApp_SingleInstance"; // اسم مميز للتطبيق
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                // البرنامج مفتوح بالفعل
                MessageBox.Show("البرنامج يعمل بالفعل!", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // عند الخروج، نفرغ الـ Mutex
            mutex.ReleaseMutex();
        }
    }
}
