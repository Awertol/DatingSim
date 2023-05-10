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
    /// Interakční logika pro FinishWindow.xaml
    /// </summary>
    public partial class FinishWindow : Window
    {
        public FinishWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            this.Cursor = Kurzor.C1;
            if (VyberyUz.MacekMichal == "A")
            {
                prehravacVideo.Source = new Uri("videa/8SA.mp4", UriKind.Relative);
            }
            else
            {
                prehravacVideo.Source = new Uri("videa/8SB.mp4", UriKind.Relative);
            }
            if (VyberyUz.Prizen >= -20 && VyberyUz.Prizen < -6)
            {
                prehravacVideo.Source = new Uri($"videa/9S{VyberyUz.MacekMichal}1.mp4", UriKind.Relative);
                lbEnding.Content = "BAD ENDING";
            }
            else if(VyberyUz.Prizen >= -6 && VyberyUz.Prizen <= 6)
            {
                prehravacVideo.Source = new Uri($"videa/9S{VyberyUz.MacekMichal}2.mp4", UriKind.Relative);
                lbEnding.Content = "FRIEND ENDING";
            }
            else if(VyberyUz.Prizen > 6 && VyberyUz.Prizen <= 20)
            {
                prehravacVideo.Source = new Uri($"videa/9S{VyberyUz.MacekMichal}3.mp4", UriKind.Relative);
                lbEnding.Content = "ROMANTIC ENDING ♥️";
            }
            prizenBar.Value = Convert.ToDouble(VyberyUz.Prizen);
            prehravacVideo.Play();
        }

        private void prehravacVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            btnEnd.Visibility = Visibility.Visible;
            lbEnding.Visibility = Visibility.Visible;
            prizenBar.Visibility = Visibility.Visible;

        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("M & M\n Ti děkují za zahrání!", "KONEC HRY");
            this.Close();
        }
    }
}
