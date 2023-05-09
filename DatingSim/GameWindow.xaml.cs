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
    /// Interakční logika pro GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        Random gnč = new Random();
        public GameWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            this.Cursor = Kurzor.C1;
            prehravacVideo.Source = new Uri(Sceny.Pole[VyberyUz.Scena].Cesta, UriKind.Relative);
            prehravacVideo.Play();
        }

        private void btnOdp1_Click(object sender, RoutedEventArgs e)
        {
           
            var zmacknute = sender as Button;
            string odpoved = zmacknute.Content.ToString();
            int volba = 0;
            if (VyberyUz.MacekMichal == "A")
            {
                volba = 1;
            }
            else if (VyberyUz.MacekMichal == "B")
            {
                volba = 2;
            }
            var matches = Sceny.Pole[VyberyUz.Scena].Odpovedi.Where(pair => pair.Key == odpoved && pair.Value.Postava == volba)
                        .Select(pair => pair.Value.Body);
                
            int[] bodiky = matches.ToArray();
            VyberyUz.Prizen += bodiky[0];
            if (VyberyUz.Scena != 5)
            {
                VyberyUz.Scena++;
                prehravacVideo.Source = new Uri(Sceny.Pole[VyberyUz.Scena].Cesta, UriKind.Relative);
                prehravacVideo.Play();
                stackOdpovedi.Visibility = Visibility.Hidden;
            }

            else if (VyberyUz.Scena >= 5)
            {
                PreFinishWindow preFinishWindow = new PreFinishWindow();
                preFinishWindow.ShowDialog();
                this.Close();
            }
        }

        private void prehravacVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (VyberyUz.Scena < 6)
            {
                stackOdpovedi.Visibility = Visibility.Visible;
                int volba = 0;
                if (VyberyUz.MacekMichal == "A")
                {
                    volba = 1;
                }
                else if (VyberyUz.MacekMichal == "B")
                {
                    volba = 2;
                }
                try
                {
                    var matches = Sceny.Pole[VyberyUz.Scena].Odpovedi.Where(pair => pair.Value.Postava == volba)
                          .Select(pair => pair.Key);
                    var shuffledArray = matches.OrderBy(e => gnč.NextDouble()).ToArray();
                    string[] pole = shuffledArray.ToArray();
                    btnOdp1.Content = pole[0];
                    btnOdp2.Content = pole[1];
                    btnOdp3.Content = pole[2];
                }
                catch
                {
                    MessageBox.Show("Konec hry");
                }
            }
            
        }
    }
}
