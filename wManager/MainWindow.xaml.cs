using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        public static extern int mciSendString(string strCommand, StringBuilder strReturnString, int cchReturn, IntPtr hwndCallback);


        Process myProcess;
        Process[] procs;
        Notice notice = new Notice();

        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer getPTimer = new System.Windows.Threading.DispatcherTimer();

            getPTimer.Tick += new EventHandler(getPTimerTick);
            getPTimer.Interval = new TimeSpan(0, 0, 1);
            getPTimer.Start();
            
            notice.Show();



        }

        private void getP_Click(object sender, RoutedEventArgs e)
        {
            procs = Process.GetProcesses();
            foreach (Process p in procs)
            {
                if (!string.IsNullOrWhiteSpace(p.MainWindowTitle))
                    procTB.AppendText(p.MainWindowTitle + "\n");
            }
        }

        private void getPTimerTick(object sender, EventArgs e)
        {
            procTB.Text = null; 
            procs = Process.GetProcesses();
            foreach (Process p in procs)
            {
                if (!string.IsNullOrWhiteSpace(p.MainWindowTitle))
                {
                    procTB.AppendText(p.MainWindowTitle + "  -   ");
                    procTB.AppendText(p.StartTime + "\n");
                    procTB.AppendText(p.TotalProcessorTime + "\n");
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            notice.show();
            
        }
    }
}
