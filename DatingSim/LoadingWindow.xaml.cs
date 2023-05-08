using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace DatingSim
{
    /// <summary>
    /// Interakční logika pro LoadingWindow.xaml
    /// </summary>
    public partial class LoadingWindow : Window
    {
        System.Timers.Timer casovac = new System.Timers.Timer(5000);
        Random gnč = new Random();
        BitmapImage obrazekSrceBig = new BitmapImage(new Uri(@"/obrazky/srceBig.png", UriKind.Relative));
        BitmapImage obrazekSrceSmall = new BitmapImage(new Uri(@"/obrazky/srceSmall.png", UriKind.Relative));
        bool srdceBig = true;
        public LoadingWindow()
        {
            InitializeComponent();
            this.Cursor = Kurzor.C1;
            this.WindowState = WindowState.Maximized;
            casovac.Elapsed += Casovac_Elapsed;
            casovac.Start();
        }

        private void Casovac_Elapsed(object? sender, ElapsedEventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke((ThreadStart)delegate
            {
                this.Close();
            });
        }

        
    }
}
