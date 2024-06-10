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
    /// Логика взаимодействия для Soobsheniya.xaml
    /// </summary>
    public partial class Soobsheniya : Window
    {
        user154_dbEntities db = new user154_dbEntities();
        public Soobsheniya()
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
            var Join = (from a in db.batssostavstatistika
                        join b in db.batspolzovatel
                        on a.id_igroka equals b.id_igroka
                        join c in db.batsmatch
                        on a.id_matcha equals c.id_matcha
                        select new { a.komentarii, a.id_igroka, c.data_provedenia, c.nazvanie_turnira, c.protivnik });
            list.ItemsSource = Join.Where(w => w.id_igroka == Class1.idclass && w.komentarii != null).ToList();

            var turnir = db.batsmatch.Select(w => w.nazvanie_turnira).Distinct().ToList();
            TurnirTxt.ItemsSource = turnir;
            TurnirTxt.SelectedValue = 0;

            var protivnik = db.batsmatch.Where(w => w.nazvanie_turnira == TurnirTxt.Text).Select(w => w.protivnik).Distinct().ToList();
            ProtivnikTxt.ItemsSource = protivnik;
            ProtivnikTxt.SelectedValue = 0;

            var data = db.batsmatch.Where(w => w.nazvanie_turnira == TurnirTxt.Text && w.protivnik == ProtivnikTxt.Text).Select(w => w.data_provedenia).Distinct().ToList();
            DataTxt.ItemsSource = data;
            DataTxt.SelectedValue = 0;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void TurnirTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var turnir = TurnirTxt.SelectedValue as String;

            var protivnik = db.batsmatch.Where(w => w.nazvanie_turnira == turnir).Select(w => w.protivnik).Distinct().ToList();
            ProtivnikTxt.ItemsSource = protivnik;
        }

        private void ProtivnikTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var turnir = TurnirTxt.SelectedValue as String;
            var protivnik = ProtivnikTxt.SelectedValue as String;

            var data = db.batsmatch.Where(w => w.nazvanie_turnira == turnir && w.protivnik == protivnik).Select(w => w.data_provedenia).Distinct().ToList();
            DataTxt.ItemsSource = data;
        }

        private void DataTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Obnov_Click(object sender, RoutedEventArgs e)
        {
            var Join = (from a in db.batssostavstatistika
                        join b in db.batspolzovatel
                        on a.id_igroka equals b.id_igroka
                        join c in db.batsmatch
                        on a.id_matcha equals c.id_matcha
                        select new { a.komentarii, a.id_igroka, c.data_provedenia });

            TurnirTxt.Text = "";
            ProtivnikTxt.Text = "";
            DataTxt.Text = "";

            list.ItemsSource = Join.Where(w => w.id_igroka == Class1.idclass && w.komentarii != null).ToList();
        }

        private void Poisk_Click(object sender, RoutedEventArgs e)
        {
            var turnir = TurnirTxt.SelectedValue as String;
            var protivnik = ProtivnikTxt.SelectedValue as String;
            var data = Convert.ToDateTime(DataTxt.SelectedValue);

            var Join = (from a in db.batssostavstatistika
                        join b in db.batspolzovatel
                        on a.id_igroka equals b.id_igroka
                        join c in db.batsmatch
                        on a.id_matcha equals c.id_matcha
                        select new { a.komentarii, a.id_igroka, c.data_provedenia, c.protivnik, c.nazvanie_turnira });

            list.ItemsSource = Join.Where(w => w.nazvanie_turnira == turnir && w.protivnik == protivnik && w.data_provedenia == data && w.id_igroka == Class1.idclass && w.komentarii != null).ToList();
        }
    }
}
