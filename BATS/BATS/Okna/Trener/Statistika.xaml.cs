using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Statistika.xaml
    /// </summary>
    public partial class Statistika : Window
    {
        user154_dbEntities db = new user154_dbEntities();
        public Statistika()
        {
            InitializeComponent();
        }
        private void Vihod_Click(object sender, RoutedEventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var Join = (from a in db.batssostavstatistika
                        join b in db.batspolzovatel
                        on a.id_igroka equals b.id_igroka
                        select new { b.familia, b.ima, b.otchestvo, a.id_matcha, a.statistika_igroka, a.goli, a.peredachi, a.krasnie_kartochki, a.jeltie_kartochki, a.komentarii, a.id_sostava_statistika });
            table.ItemsSource = Join.ToList();


            var idtext = db.batssostavstatistika.Select(w => w.id_sostava_statistika).ToList();
            idTxt.ItemsSource = idtext;

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
                        select new { b.familia, b.ima, b.otchestvo, a.id_matcha, a.statistika_igroka, a.goli, a.peredachi, a.krasnie_kartochki, a.jeltie_kartochki, a.komentarii, a.id_sostava_statistika });

            TurnirTxt.Text = "";
            ProtivnikTxt.Text = "";
            DataTxt.Text = "";
            table.ItemsSource = Join.ToList();
        }

        private void izmenit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (idTxt.Text == "")
                {
                    MessageBox.Show("Заполните поле ID!", "Ошибка");
                }
                else if (GolTxt.Text == "" && PeredTxt.Text == "" && KKartTxt.Text == "" && JKartTxt.Text == "" && KommTxt.Text == "")
                {
                    MessageBox.Show("Заполните хотя бы одно поле!", "Ошибка");
                }
                else
                {
                    int idtxt = Convert.ToInt32(idTxt.Text);
                    var data = db.batssostavstatistika.Where(w => w.id_sostava_statistika == idtxt).FirstOrDefault();

                    int gol = 0;
                    int pered = 0;

                    if (data.goli != null)
                    {
                        gol = Convert.ToInt16(data.goli);
                    }
                    if (data.peredachi != null)
                    {
                        pered = Convert.ToInt16(data.peredachi);
                    }

                    if (GolTxt.Text != "")
                    {
                        gol = Convert.ToInt16(GolTxt.Text);
                        data.goli = gol;
                    }
                    if (PeredTxt.Text != "")
                    {
                        pered = Convert.ToInt16(PeredTxt.Text);
                        data.peredachi = pered;
                    }
                    if (KKartTxt.Text != "")
                    {
                        data.krasnie_kartochki = Convert.ToInt16(KKartTxt.Text);
                    }
                    if (JKartTxt.Text != "")
                    {
                        data.jeltie_kartochki = Convert.ToInt16(JKartTxt.Text);
                    }
                    if (KommTxt.Text != "")
                    {
                        data.komentarii = KommTxt.Text;
                    }
                    data.statistika_igroka = "";
                    data.statistika_igroka = gol + pered + " гол_+_пас";


                    db.SaveChanges();

                    var Join = (from a in db.batssostavstatistika
                                join b in db.batspolzovatel
                                on a.id_igroka equals b.id_igroka
                                select new { b.familia, b.ima, b.otchestvo, a.id_matcha, a.statistika_igroka, a.goli, a.peredachi, a.krasnie_kartochki, a.jeltie_kartochki, a.komentarii, a.id_sostava_statistika });

                    var turnir = TurnirTxt.SelectedValue as String;
                    var protivnik = ProtivnikTxt.SelectedValue as String;
                    var data2 = DataTxt.SelectedValue as String;
                    var datat = Convert.ToDateTime(data2);

                    var idmatch = db.batsmatch.Where(w => w.nazvanie_turnira == turnir && w.protivnik == protivnik && w.data_provedenia == datat).Select(w => w.id_matcha).FirstOrDefault();

                    if (db.batssostavstatistika.Select(w => w.id_matcha).Contains(idmatch))
                    {
                        table.ItemsSource = Join.Where(w => w.id_matcha == idmatch).ToList();
                    }
                    else
                    {
                        table.ItemsSource = Join.ToList();
                    }

                    MessageBox.Show("Запись изменена!", "Успех");
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка на сервере!", "Ошибка");
            }
        }

        private void udalit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (idTxt.Text == "")
                {
                    MessageBox.Show("Заполните поле ID!", "Ошибка");
                }
                else
                {
                    int idtxt = Convert.ToInt32(idTxt.Text);
                    var data = db.batssostavstatistika.Where(w => w.id_sostava_statistika == idtxt).FirstOrDefault();
                    db.batssostavstatistika.Remove(data);
                    db.SaveChanges();

                    var Join = (from a in db.batssostavstatistika
                                join b in db.batspolzovatel
                                on a.id_igroka equals b.id_igroka
                                select new { b.familia, b.ima, b.otchestvo, a.id_matcha, a.statistika_igroka, a.goli, a.peredachi, a.krasnie_kartochki, a.jeltie_kartochki, a.komentarii, a.id_sostava_statistika });

                    var turnir = TurnirTxt.SelectedValue as String;
                    var protivnik = ProtivnikTxt.SelectedValue as String;
                    var data2 = DataTxt.SelectedValue as String;
                    var datat = Convert.ToDateTime(data2);

                    var idmatch = db.batsmatch.Where(w => w.nazvanie_turnira == turnir && w.protivnik == protivnik && w.data_provedenia == datat).Select(w => w.id_matcha).FirstOrDefault();

                    if (db.batssostavstatistika.Select(w => w.id_matcha).Contains(idmatch))
                    {
                        table.ItemsSource = Join.Where(w => w.id_matcha == idmatch).ToList();
                    }
                    else
                    {
                        table.ItemsSource = Join.ToList();
                    }



                    var idtext = db.batssostavstatistika.Select(w => w.id_sostava_statistika).ToList();
                    idTxt.ItemsSource = idtext;

                    MessageBox.Show("Запись удалена!", "Успех");
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка на сервере!", "Ошибка");
            }
        }

        private void NomerTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[0-9]"))
            {
                e.Handled = true;
            }
        }

        private void Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[а-яА-Я!.,?:;0-9]"))
            {
                e.Handled = true;
            }
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
                        select new { b.familia, b.ima, b.otchestvo, a.id_matcha, a.statistika_igroka, a.goli, a.peredachi, a.krasnie_kartochki, a.jeltie_kartochki, a.komentarii, a.id_sostava_statistika, c.nazvanie_turnira, c.protivnik, c.data_provedenia });

            //var Join = (from a in db.batspolzovatel
            //               join c in db.batssostavstatistika on a.id_igroka equals c.id_igroka into ps
            //               from p in ps.DefaultIfEmpty()
            //               select new { a.familia, a.ima, a.otchestvo, p.id_matcha, p.statistika_igroka, p.goli, p.peredachi, p.krasnie_kartochki, p.jeltie_kartochki, p.komentarii, p.id_sostava_statistika});

            table.ItemsSource = Join.Where(w => w.nazvanie_turnira == turnir && w.protivnik == protivnik && w.data_provedenia == data).ToList();
        }
    }
}
