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
                lbPrizen.Content = "Macek - přízeň";
                prehravacVideo.Source = new Uri("videa/2SA.mp4", UriKind.Relative);
            }
            else
            {
                lbPrizen.Content = "Michal - přízeň";
                prehravacVideo.Source = new Uri("videa/2SB.mp4", UriKind.Relative);
            }
            if (VyberyUz.Prizen >= -20 && VyberyUz.Prizen < -6)
            {
                //prehravacVideo.Source = 
                lbEnding.Content = "BAD ENDING";
            }
            else if(VyberyUz.Prizen >= -6 && VyberyUz.Prizen <= 6)
            {
                //prehravacVideo.Source = 
                lbEnding.Content = "FRIEND ENDING";
            }
            else if(VyberyUz.Prizen > 6 && VyberyUz.Prizen <= 20)
            {
                //prehravacVideo.Source = 
                lbEnding.Content = "ROMANTIC ENDING ♥️";
            }
            prizenBar.Value = Convert.ToDouble(VyberyUz.Prizen);
            prehravacVideo.Play();
        }

        private void prehravacVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            btnEnd.Visibility = Visibility.Visible;
            lbPrizen.Visibility = Visibility.Visible;
            lbEnding.Visibility = Visibility.Visible;
            prizenBar.Visibility = Visibility.Visible;

        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
