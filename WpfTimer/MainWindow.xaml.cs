using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WpfTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TimeNow();
            btnOff.Click += BtnOffClick;
        }

        private void BtnOffClick(object sender, RoutedEventArgs e)
        {
            TimeSpan showTimeOff = new TimeSpan(0, 0, 0);
            DateTime timeOff = DateTime.Parse(txtBoxForInputTime.Text);
            TimeSpan oneSecond = new TimeSpan(0,0,1);
            DispatcherTimer _offTimer = new DispatcherTimer(TimeSpan.FromMilliseconds(1.0f), DispatcherPriority.Normal, delegate
            {
                try
                {
                    showTimeOff = timeOff - DateTime.Now + oneSecond;
                    lblForRemainingTime.Content = DateTime.Parse(showTimeOff.ToString()).ToString("HH:mm:ss");
                }
                catch (Exception)
                {
                    ComputerOff();
                }
            }, Dispatcher);
        }

        private void ComputerOff()
        {
            lblForRemainingTime.Content = "shutdown.exe";
            //Process.Start("shutdown.exe", "-h");
        }

        private void TimeNow()
        {
            DispatcherTimer showTimeNow = new DispatcherTimer(TimeSpan.FromMilliseconds(0.5f), DispatcherPriority.Normal, delegate
             {
                 lblForTime.Content = DateTime.Now.ToString("HH:mm:ss");
             }, Dispatcher);
        }
    }
}
