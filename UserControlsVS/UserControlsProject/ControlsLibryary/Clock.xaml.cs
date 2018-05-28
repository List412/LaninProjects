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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ControlsLibryary
{
    /// <summary>
    /// Interaction logic for Clock.xaml
    /// </summary>
    public partial class Clock : UserControl
    {
        private DispatcherTimer timer = new DispatcherTimer();

        public Clock()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Tick += clock_Tick;
            timer.Start();
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            
        }

        void clock_Tick(object sender, EventArgs e)
        {
            double milsec = DateTime.Now.Millisecond;
            double sec = DateTime.Now.Second;
            double min = DateTime.Now.Minute;
            double hr = DateTime.Now.Hour;

            SecondsHand.RenderTransform = new RotateTransform(((sec / 60) * 360) + ((milsec / 1000) * 6));
            MinutesHand.RenderTransform = new RotateTransform((min * 360 / 60) + ((sec / 60) * 6));
            HoursHand.RenderTransform = new RotateTransform((hr * 360 / 12) + (min / 2));           
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            SecondsHand.Height =  Math.Min(backGrid.ActualHeight, backGrid.ActualWidth) / 2;
            MinutesHand.Height = Math.Min(backGrid.ActualHeight, backGrid.ActualWidth) / 2;
            HoursHand.Height = Math.Min(backGrid.ActualHeight, backGrid.ActualWidth) / 2;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SecondsHand.Height = Math.Min(backGrid.ActualHeight, backGrid.ActualWidth) / 2;
            MinutesHand.Height = Math.Min(backGrid.ActualHeight, backGrid.ActualWidth) / 2;
            HoursHand.Height = Math.Min(backGrid.ActualHeight, backGrid.ActualWidth) / 2;
        }
    }
}
