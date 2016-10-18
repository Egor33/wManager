using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace wManager
{
    /// <summary>
    /// Логика взаимодействия для Notice.xaml
    /// </summary>
    public partial class Notice : Window
    {
        private DoubleAnimation my; 

        public Notice()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Top = SystemParameters.FullPrimaryScreenHeight;
            this.Left = SystemParameters.FullPrimaryScreenWidth - 300;
            RepeatBehavior ejje = new RepeatBehavior();

            my = new DoubleAnimation();
            my.From = Top;
            my.To = 500;
            my.RepeatBehavior = RepeatBehavior.Forever;
            my.Duration = new Duration(TimeSpan.FromMilliseconds(999));
        }

        public void show()
        {
            //this.Top-=100;
            BeginAnimation(TopProperty, my);
        }
    }
}
