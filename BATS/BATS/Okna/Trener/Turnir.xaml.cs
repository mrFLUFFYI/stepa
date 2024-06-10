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
    /// Логика взаимодействия для Turnir.xaml
    /// </summary>
    public partial class Turnir : Window
    {
        user154_dbEntities db = new user154_dbEntities();
        public Turnir()
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
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TurnirTxt.Text == "" || MestoTxt.Text == "" || DataTxt.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка");
                }
                else
                {
                    batsmatch data = new batsmatch();
                    data.nazvanie_turnira = TurnirTxt.Text;
                    data.mesto_provedenia = MestoTxt.Text;
                    data.data_provedenia = Convert.ToDateTime(DataTxt.Text);
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
                else if (TurnirTxt.Text == "" && DataTxt.Text == "" && MestoTxt.Text == "")
                {
                    MessageBox.Show("Заполните хотя бы одно поле!", "Ошибка");
                }
                else
                {
                    int idkl = Convert.ToInt32(idTxt.Text);
                    var data = db.batsmatch.Where(w => w.id_matcha == idkl).FirstOrDefault();

                    var mesto = db.batsmatch.Where(w => w.nazvanie_turnira == TurnirTxt.Text).Select(w => w.mesto_provedenia).FirstOrDefault();

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

        private void TurnirTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[а-яА-Я0-9.,!;:]"))
            {
                e.Handled = true;
            }
        }

        private void MestoTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[а-яА-Я0-9.,!;:]"))
            {
                e.Handled = true;
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
    }
}
