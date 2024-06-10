using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для SostavNaMatch.xaml
    /// </summary>
    public partial class SostavNaMatch : Window
    {
        user154_dbEntities db = new user154_dbEntities();
        public SostavNaMatch()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            var napl = db.batspolzovatel.Where(w => w.familia + " " + w.ima + " " + w.otchestvo == NapLTxt.Text).Select(w => w.id_igroka).FirstOrDefault();

            var napr = db.batspolzovatel.Where(w => w.familia + " " + w.ima + " " + w.otchestvo == NapRTxt.Text).Select(w => w.id_igroka).FirstOrDefault();

            var zashl = db.batspolzovatel.Where(w => w.familia + " " + w.ima + " " + w.otchestvo == ZashitnikLTxt.Text).Select(w => w.id_igroka).FirstOrDefault();

            var zashr = db.batspolzovatel.Where(w => w.familia + " " + w.ima + " " + w.otchestvo == ZashitnikRTxt.Text).Select(w => w.id_igroka).FirstOrDefault();

            var vrat = db.batspolzovatel.Where(w => w.familia + " " + w.ima + " " + w.otchestvo == VratarTxt.Text).Select(w => w.id_igroka).FirstOrDefault();

            var turnir = db.batsmatch.Select(w => w.nazvanie_turnira).Distinct().ToList();
            TurnirTxt.ItemsSource = turnir;
            TurnirTxt.SelectedValue = 0;

            var protivnik = db.batsmatch.Where(w => w.nazvanie_turnira == TurnirTxt.Text).Select(w => w.protivnik).Distinct().ToList();
            ProtivnikTxt.ItemsSource = protivnik;
            ProtivnikTxt.SelectedValue = 0;

            var data = db.batsmatch.Where(w => w.nazvanie_turnira == TurnirTxt.Text && w.protivnik == ProtivnikTxt.Text).Select(w => w.data_provedenia).Distinct().ToList();
            DataTxt.ItemsSource = data;
            DataTxt.SelectedValue = 0;

            var idmatch = db.batsmatch.Where(w => w.nazvanie_turnira == TurnirTxt.Text && w.protivnik == ProtivnikTxt.Text).Select(w => w.id_matcha).FirstOrDefault();

            var naplD = db.batspolzovatel.Where(w => w.id_amplua == 1).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
            foreach (string item in naplD)
            {
                NapLTxt.Items.Add(item);
            }

            var naprD = db.batspolzovatel.Where(w => w.id_amplua == 1).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
            foreach (string item in naprD)
            {
                NapRTxt.Items.Add(item);
            }

            var zashlD = db.batspolzovatel.Where(w => w.id_amplua == 2).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
            foreach (string item in zashlD)
            {
                ZashitnikLTxt.Items.Add(item);
            }

            var zashrD = db.batspolzovatel.Where(w => w.id_amplua == 2).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
            foreach (string item in zashrD)
            {
                ZashitnikRTxt.Items.Add(item);
            }

            var vratD = db.batspolzovatel.Where(w => w.id_amplua == 3).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
            VratarTxt.ItemsSource = vratD;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (NapLTxt.Text == "" || NapRTxt.Text == "" || ZashitnikLTxt.Text == "" || ZashitnikRTxt.Text == "" || VratarTxt.Text == "" || TurnirTxt.Text == "" || DataTxt.Text == "" || ProtivnikTxt.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка");
                }
                else
                {
                    var datatxt1 = Convert.ToDateTime(DataTxt.Text);
                    var idmatch = db.batsmatch.Where(w => w.nazvanie_turnira == TurnirTxt.Text && w.protivnik == ProtivnikTxt.Text && w.data_provedenia == datatxt1).Select(w => w.id_matcha).FirstOrDefault();

                    var napl = db.batspolzovatel.Where(w => w.familia + " " + w.ima + " " + w.otchestvo == NapLTxt.Text).Select(w => w.id_igroka).FirstOrDefault();

                    var napr = db.batspolzovatel.Where(w => w.familia + " " + w.ima + " " + w.otchestvo == NapRTxt.Text).Select(w => w.id_igroka).FirstOrDefault();

                    var zashl = db.batspolzovatel.Where(w => w.familia + " " + w.ima + " " + w.otchestvo == ZashitnikLTxt.Text).Select(w => w.id_igroka).FirstOrDefault();

                    var zashr = db.batspolzovatel.Where(w => w.familia + " " + w.ima + " " + w.otchestvo == ZashitnikRTxt.Text).Select(w => w.id_igroka).FirstOrDefault();

                    var vrat = db.batspolzovatel.Where(w => w.familia + " " + w.ima + " " + w.otchestvo == VratarTxt.Text).Select(w => w.id_igroka).FirstOrDefault();

                    var match333 = db.batssostavstatistika.Where(w => w.id_matcha == idmatch).Select(w => w.id_matcha).FirstOrDefault();

                    if (TurnirTxt.Text == "" || ProtivnikTxt.Text == "" || DataTxt.Text == "" || NapLTxt.Text == "" || NapRTxt.Text == "" || ZashitnikLTxt.Text == "" || ZashitnikRTxt.Text == "" || VratarTxt.Text == "")
                    {
                        MessageBox.Show("Заполните все поля!", "Ошибка");
                    }
                    else if (db.batssostavstatistika.Select(w => w.id_matcha).Contains(idmatch))
                    {
                        MessageBox.Show("Нельзя изменить уже закрепленый состав!", "Ошибка");
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите закрепить данный состав? После закрепления состав нельзя будет изменить.", "Сообщение", MessageBoxButton.YesNo);

                        if (result == MessageBoxResult.Yes)
                        {
                            batssostavstatistika data = new batssostavstatistika();
                            data.id_matcha = idmatch;
                            data.id_igroka = napl;
                            db.batssostavstatistika.Add(data);
                            db.SaveChanges();

                            data.id_matcha = idmatch;
                            data.id_igroka = napr;
                            db.batssostavstatistika.Add(data);
                            db.SaveChanges();

                            data.id_matcha = idmatch;
                            data.id_igroka = zashl;
                            db.batssostavstatistika.Add(data);
                            db.SaveChanges();

                            data.id_matcha = idmatch;
                            data.id_igroka = zashr;
                            db.batssostavstatistika.Add(data);
                            db.SaveChanges();

                            data.id_matcha = idmatch;
                            data.id_igroka = vrat;
                            db.batssostavstatistika.Add(data);
                            db.SaveChanges();


                            MessageBox.Show("Состав сохранен!", "Успех");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка на сервере!", "Ошибка");
            }
        }

        private void Vihod_Click(object sender, RoutedEventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Close();
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
        private void ZashitnikRTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = ZashitnikRTxt.SelectedItem;
            var ZL = ZashitnikLTxt.SelectedValue as String;
            var ZR = ZashitnikRTxt.SelectedValue as String;

            if (ZashitnikLTxt.Text == "")
            {
                ZashitnikLTxt.Items.Clear();

                var zashlD = db.batspolzovatel.Where(w => w.id_amplua == 2).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
                foreach (string item in zashlD)
                {
                    ZashitnikLTxt.Items.Add(item);
                }

                ZashitnikLTxt.Items.Remove(selectedItem);
            }
            else if (ZL == ZR)
            {
                ZashitnikLTxt.Items.Clear();

                var zashlD = db.batspolzovatel.Where(w => w.id_amplua == 2).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
                foreach (string item in zashlD)
                {
                    ZashitnikLTxt.Items.Add(item);
                }

                ZashitnikLTxt.Items.Remove(selectedItem);
            }
        }

        private void ZashitnikLTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = ZashitnikLTxt.SelectedItem;
            var ZL = ZashitnikLTxt.SelectedValue as String;
            var ZR = ZashitnikRTxt.SelectedValue as String;

            if (ZashitnikRTxt.Text == "")
            {
                ZashitnikRTxt.Items.Clear();

                var zashrD = db.batspolzovatel.Where(w => w.id_amplua == 2).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
                foreach (string item in zashrD)
                {
                    ZashitnikRTxt.Items.Add(item);
                }

                ZashitnikRTxt.Items.Remove(selectedItem);
            }
            else if (ZR == ZL)
            {
                ZashitnikRTxt.Items.Clear();

                var zashrD = db.batspolzovatel.Where(w => w.id_amplua == 2).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
                foreach (string item in zashrD)
                {
                    ZashitnikRTxt.Items.Add(item);
                }

                ZashitnikRTxt.Items.Remove(selectedItem);
            }
        }

        private void NapLTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = NapLTxt.SelectedItem;
            var NL = NapLTxt.SelectedValue as String;
            var NR = NapRTxt.SelectedValue as String;

            if (NapRTxt.Text == "")
            {
                NapRTxt.Items.Clear();

                var naprD = db.batspolzovatel.Where(w => w.id_amplua == 1).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
                foreach (string item in naprD)
                {
                    NapRTxt.Items.Add(item);
                }

                NapRTxt.Items.Remove(selectedItem);
            }
            else if (NR == NL)
            {
                NapRTxt.Items.Clear();

                var naprD = db.batspolzovatel.Where(w => w.id_amplua == 1).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
                foreach (string item in naprD)
                {
                    NapRTxt.Items.Add(item);
                }

                NapRTxt.Items.Remove(selectedItem);
            }
        }

        private void NapRTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = NapRTxt.SelectedItem;
            var NL = NapLTxt.SelectedValue as String;
            var NR = NapRTxt.SelectedValue as String;

            if (NapLTxt.Text == "")
            {
                NapLTxt.Items.Clear();

                var idd = db.batspolzovatel.Where(w => w.id_amplua == 1).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
                foreach (string item in idd)
                {
                    NapLTxt.Items.Add(item);
                }
                NapLTxt.Items.Remove(selectedItem);
            }
            else if (NL == NR)
            {
                NapLTxt.Items.Clear();

                var idd = db.batspolzovatel.Where(w => w.id_amplua == 1).Select(w => w.familia + " " + w.ima + " " + w.otchestvo).ToList();
                foreach (string item in idd)
                {
                    NapLTxt.Items.Add(item);
                }
                NapLTxt.Items.Remove(selectedItem);
            }
        }
    }
}
