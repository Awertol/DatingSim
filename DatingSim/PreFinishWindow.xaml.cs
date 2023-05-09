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

namespace DatingSim
{
    /// <summary>
    /// Interakční logika pro PreFinishWindow.xaml
    /// </summary>
    public partial class PreFinishWindow : Window
    {
        public PreFinishWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            this.Cursor = Kurzor.C1;
            prehravacVideo.Source = new Uri($"videa/8S{VyberyUz.MacekMichal}.mp4", UriKind.Relative);
            prehravacVideo.Play();
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            FinishWindow finalOkno = new FinishWindow();
            finalOkno.ShowDialog();
            this.Close();
        }

        private void prehravacVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            btnEnd.Visibility = Visibility.Visible;
        }
    }
}
