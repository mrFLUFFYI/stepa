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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BATS
{
    /// <summary>
    /// Логика взаимодействия для Match.xaml
    /// </summary>
    public partial class Match : Window
    {
        user154_dbEntities db = new user154_dbEntities();
        public Match()
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
            table.ItemsSource = db.batsmatch.ToList();

            var idtext = db.batsmatch.Select(w => w.id_matcha).ToList();
            idTxt.ItemsSource = idtext;

            var turnir = db.batsmatch.Select(w => w.nazvanie_turnira).Distinct().ToList();
            TurnirTxt.ItemsSource = turnir;
            TurnirTxt.SelectedIndex = 0;

            var mesto = db.batsmatch.Where(w => w.nazvanie_turnira == TurnirTxt.Text).Select(w => w.mesto_provedenia).Distinct().ToList();
            MestoTxt.ItemsSource = mesto;
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TurnirTxt.Text == "" || DataTxt.Text == "" || ProtivnikTxt.Text == "" || MestoTxt.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка");
                }
                else
                {
                    batsmatch data = new batsmatch();
                    data.nazvanie_turnira = TurnirTxt.Text;
                    data.mesto_provedenia = MestoTxt.Text;
                    data.data_provedenia = Convert.ToDateTime(DataTxt.Text);
                    data.protivnik = ProtivnikTxt.Text;
                    db.batsmatch.Add(data);
                    db.SaveChanges();

                    table.ItemsSource = db.batsmatch.ToList();
                    MessageBox.Show("Запись добавлена!", "Успех");



                    var idtext = db.batsmatch.Select(w => w.id_matcha).ToList();
                    idTxt.ItemsSource = idtext;
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка на сервере!", "Ошибка");
            }
        }

        private void izmenit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (idTxt.Text == "")
                {
                    MessageBox.Show("Заполните поле ID!", "Ошибка");
                }
                else if (TurnirTxt.Text == "" && DataTxt.Text == "" && ProtivnikTxt.Text == "" && MestoTxt.Text == "")
                {
                    MessageBox.Show("Заполните хотя бы одно поле!", "Ошибка");
                }
                else
                {
                    int idkl = Convert.ToInt32(idTxt.Text);
                    var data = db.batsmatch.Where(w => w.id_matcha == idkl).FirstOrDefault();

                    if (TurnirTxt.Text != "")
                    {
                        data.nazvanie_turnira = TurnirTxt.Text;
                    }
                    if (MestoTxt.Text != "")
                    {
                        data.mesto_provedenia = MestoTxt.Text;
                    }
                    if (DataTxt.Text != "")
                    {
                        data.data_provedenia = Convert.ToDateTime(DataTxt.Text);
                    }
                    if (ProtivnikTxt.Text != "")
                    {
                        data.protivnik = ProtivnikTxt.Text;
                    }

                    db.SaveChanges();


                    table.ItemsSource = db.batsmatch.ToList();
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
                    int idkl = Convert.ToInt32(idTxt.Text);
                    var data = db.batsmatch.Where(w => w.id_matcha == idkl).FirstOrDefault();
                    db.batsmatch.Remove(data);
                    db.SaveChanges();
                    table.ItemsSource = db.batsmatch.ToList();
                    MessageBox.Show("Запись удалена!", "Успех");



                    var idtext = db.batsmatch.Select(w => w.id_matcha).ToList();
                    idTxt.ItemsSource = idtext;
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка на сервере!", "Ошибка");
            }
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

        private void DataTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[0-9.-]"))
            {
                e.Handled = true;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ProtivnikTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Zа-яА-Я0-9]"))
            {
                e.Handled = true;
            }
        }

        private void Obnov_Click(object sender, RoutedEventArgs e)
        {
            table.ItemsSource = db.batsmatch.ToList();

            Poisk.Text = "";
        }

        private void TurnirTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var turnir = TurnirTxt.SelectedValue as String;

            var mesto = db.batsmatch.Where(w => w.nazvanie_turnira == turnir).Select(w => w.mesto_provedenia).Distinct().ToList();
            MestoTxt.ItemsSource = mesto;
        }
    }
}
