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
    /// Логика взаимодействия для MenuK.xaml
    /// </summary>
    public partial class MenuK : Window
    {
        public MenuK()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Kabinet_Click(object sender, RoutedEventArgs e)
        {
            KabinetK mw = new KabinetK();
            mw.Show();
            this.Close();
        }

        private void Matchi_Click(object sender, RoutedEventArgs e)
        {
            MatchK mw = new MatchK();
            mw.Show();
            this.Close();
        }

        private void Turnir_Click(object sender, RoutedEventArgs e)
        {
            TurnirK mw = new TurnirK();
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

        private void Soobsheniya_Click(object sender, RoutedEventArgs e)
        {
            Soobsheniya mw = new Soobsheniya();
            mw.Show();
            this.Close();
        }
    }
}
