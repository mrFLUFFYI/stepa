using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для MatchK.xaml
    /// </summary>
    public partial class MatchK : Window
    {
        user154_dbEntities db = new user154_dbEntities();
        public MatchK()
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

            var poiskData = db.batsmatch.Select(w => w.nazvanie_turnira).Distinct().ToList();
            Poisk.Items.Add("Турнир");
            foreach (string item in poiskData)
            {
                Poisk.Items.Add(item);
            }
            Poisk.Text = "Турнир";
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        public int sort = 0;
        private void SortA_Click(object sender, RoutedEventArgs e)
        {
            if (Poisk.SelectedIndex != 0)
            {
                if (sort == 0)
                {
                    table.ItemsSource = db.batsmatch.Where(w => w.nazvanie_turnira == Poisk.Text).OrderByDescending(i => i.protivnik).ToList();
                    sort = 1;
                }
                else
                {
                    table.ItemsSource = db.batsmatch.Where(w => w.nazvanie_turnira == Poisk.Text).OrderBy(a => a.protivnik).ToList();
                    sort = 0;
                }
            }
            else
            {
                if (sort == 0)
                {
                    table.ItemsSource = db.batsmatch.OrderByDescending(i => i.protivnik).ToList();
                    sort = 1;
                }
                else
                {
                    table.ItemsSource = db.batsmatch.OrderBy(a => a.protivnik).ToList();
                    sort = 0;
                }
            }
        }

        private void Poisk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var poisk = Poisk.SelectedValue as String;

            if (Poisk.SelectedIndex != 0)
            {
                table.ItemsSource = db.batsmatch.Where(w => w.nazvanie_turnira == poisk).ToList();
            }
            else
            {
                table.ItemsSource = db.batsmatch.ToList();
            }
        }

        private void Obnov_Click(object sender, RoutedEventArgs e)
        {
            table.ItemsSource = db.batsmatch.ToList();

            var poiskData = db.batsmatch.Select(w => w.nazvanie_turnira).Distinct().ToList();
            Poisk.Items.Add("Турнир");
            foreach (string item in poiskData)
            {
                Poisk.Items.Add(item);
            }
            Poisk.Text = "Турнир";
        }
    }
}