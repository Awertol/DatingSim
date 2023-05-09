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

namespace DatingSim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            LoadingWindow nacitaciOkno = new LoadingWindow();
            nacitaciOkno.ShowDialog();
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            this.Cursor = Kurzor.C1;
            prehravacUvodu.MouseLeftButtonDown -= prehravacUvodu_MouseLeftButtonDown;
        }

        private void prehravacUvodu_MediaEnded(object sender, RoutedEventArgs e)
        {
            lbOtazka.Visibility = Visibility.Visible;
            lbOtazka.Content = "Kdo bude tvůj vyvolený?";
            prehravacUvodu.MouseLeftButtonDown += prehravacUvodu_MouseLeftButtonDown;
        }

        private void prehravacUvodu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            double x = Mouse.GetPosition(this).X;
            double y = Mouse.GetPosition(this).Y;

            x = Math.Truncate(x);
            y = Math.Truncate(y);
            if(x > this.Width/2)
            {
                MessageBox.Show("Michal");
                VyberyUz.MacekMichal = "B";
            }
            else
            {
                MessageBox.Show("Macek");
                VyberyUz.MacekMichal = "A";
            }
            GameWindow oknoHra = new GameWindow();
            oknoHra.ShowDialog();
            this.Close();
        }
    }
}
