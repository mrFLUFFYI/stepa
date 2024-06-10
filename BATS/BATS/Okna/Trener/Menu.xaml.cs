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

namespace BATS
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Igroki_Click(object sender, RoutedEventArgs e)
        {
            Igroki mw = new Igroki();
            mw.Show();
            this.Close();
        }

        private void Matchi_Click(object sender, RoutedEventArgs e)
        {
            Match mw = new Match();
            mw.Show();
            this.Close();
        }

        private void Sostav_Click(object sender, RoutedEventArgs e)
        {
            SostavNaMatch mw = new SostavNaMatch();
            mw.Show();
            this.Close();
        }

        private void Vihod_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите выйти из аккаунта?", "Сообщение", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
                Class1.idclass = 0;
            }
        }

        private void Turnir_Click(object sender, RoutedEventArgs e)
        {
            Turnir mw = new Turnir();
            mw.Show();
            this.Close();
        }

        private void Kabinet_Click(object sender, RoutedEventArgs e)
        {
            Kabinet mw = new Kabinet();
            mw.Show();
            this.Close();
        }

        private void Stats_Click(object sender, RoutedEventArgs e)
        {
            Statistika mw = new Statistika();
            mw.Show();
            this.Close();
        }
    }
}