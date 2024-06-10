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
    /// Логика взаимодействия для TurnirK.xaml
    /// </summary>
    public partial class TurnirK : Window
    {
        user154_dbEntities db = new user154_dbEntities();

        public TurnirK()
        {
            InitializeComponent();
        }

        private void Vihod_Click(object sender, RoutedEventArgs e)
        {
            MenuK a = new MenuK();
            a.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            table.ItemsSource = db.batsmatch.ToList();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        public int sort = 0;
        private void SortA_Click(object sender, RoutedEventArgs e)
        {
            if (sort == 0)
            {
                table.ItemsSource = db.batsmatch.OrderByDescending(i => i.data_provedenia).ToList();
                sort = 1;
            }
            else
            {
                table.ItemsSource = db.batsmatch.OrderBy(a => a.data_provedenia).ToList();
                sort = 0;
            }
        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            table.ItemsSource = db.batsmatch.Where(
                  w => w.nazvanie_turnira.ToLower().Contains(Poisk.Text.ToLower())
               || w.mesto_provedenia.ToLower().Contains(Poisk.Text.ToLower())
               || w.data_provedenia.ToString().Contains(Poisk.Text.ToLower())
               || w.protivnik.ToLower().Contains(Poisk.Text.ToLower())
               ).ToList();

            if (Poisk.Text == "")
            {
                table.ItemsSource = db.batsmatch.ToList();
            }
        }

        private void Obnov_Click(object sender, RoutedEventArgs e)
        {
            table.ItemsSource = db.batsmatch.ToList();

            Poisk.Text = "";
        }
    }
}