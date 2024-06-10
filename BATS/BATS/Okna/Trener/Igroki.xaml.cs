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
    /// Логика взаимодействия для Igroki.xaml
    /// </summary>
    public partial class Igroki : Window
    {
        user154_dbEntities db = new user154_dbEntities();
        public Igroki()
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
            var Join = (from a in db.batspolzovatel
                        join b in db.batsamplua
                        on a.id_amplua equals b.id_amplua
                        select new { a.familia, a.ima, a.otchestvo, a.data_rojdenia, b.nazvanie, a.igrovoi_nomer, a.id_igroka, a.login, a.parol, a.id_roli });
            table.ItemsSource = Join.Where(w => w.id_roli == 1).ToList();


            var idtext = db.batspolzovatel.Where(w => w.id_roli == 1).Select(w => w.id_igroka).ToList();
            idTxt.ItemsSource = idtext;

            var amplua = db.batsamplua.Where(w => w.nazvanie != "Нет").Select(w => w.nazvanie).ToList();
            AmpluaTxt.ItemsSource = amplua;
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
                if (FamTxt.Text == "" || ImaTxt.Text == "" || OtchTxt.Text == "" || DataTxt.Text == "" || LoginTxt.Text == "" || ParolTxt.Text == "" || AmpluaTxt.Text == "" || NomerTxt.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка");
                }
                else
                {
                    var amplua = db.batsamplua.Where(w => w.nazvanie == AmpluaTxt.Text).Select(w => w.id_amplua).FirstOrDefault();

                    batspolzovatel data = new batspolzovatel();
                    data.familia = FamTxt.Text;
                    data.ima = ImaTxt.Text;
                    data.otchestvo = OtchTxt.Text;
                    data.data_rojdenia = Convert.ToDateTime(DataTxt.Text);
                    data.id_amplua = amplua;
                    data.igrovoi_nomer = Convert.ToInt16(NomerTxt.Text);
                    data.login = LoginTxt.Text;
                    data.parol = ParolTxt.Text;
                    data.id_licenzii = 5;
                    data.id_roli = 1;
                    db.batspolzovatel.Add(data);
                    db.SaveChanges();

                    var Join = (from a in db.batspolzovatel
                                join b in db.batsamplua
                                on a.id_amplua equals b.id_amplua
                                select new { a.familia, a.ima, a.otchestvo, a.data_rojdenia, b.nazvanie, a.igrovoi_nomer, a.id_igroka, a.login, a.parol, a.id_roli });
                    table.ItemsSource = Join.Where(w => w.id_roli == 1).ToList();



                    var idtext = db.batspolzovatel.Where(w => w.id_roli == 1).Select(w => w.id_igroka).ToList();
                    idTxt.ItemsSource = idtext;

                    MessageBox.Show("Игрок добавлен!", "Успех");
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
                else if (FamTxt.Text == "" && ImaTxt.Text == "" && OtchTxt.Text == "" && DataTxt.Text == "" && LoginTxt.Text == "" && ParolTxt.Text == "" && AmpluaTxt.Text == "" && NomerTxt.Text == "")
                {
                    MessageBox.Show("Заполните хотя бы одно поле!", "Ошибка");
                }
                else
                {
                    int idtxt = Convert.ToInt32(idTxt.Text);
                    var data = db.batspolzovatel.Where(w => w.id_igroka == idtxt).FirstOrDefault();

                    var amplua = db.batsamplua.Where(w => w.nazvanie == AmpluaTxt.Text).Select(w => w.id_amplua).FirstOrDefault();

                    if (FamTxt.Text != "")
                    {
                        data.familia = FamTxt.Text;
                    }
                    if (ImaTxt.Text != "")
                    {
                        data.ima = ImaTxt.Text;
                    }
                    if (OtchTxt.Text != "")
                    {
                        data.otchestvo = OtchTxt.Text;
                    }
                    if (DataTxt.Text != "")
                    {
                        data.data_rojdenia = Convert.ToDateTime(DataTxt.Text);
                    }
                    if (AmpluaTxt.Text != "")
                    {
                        data.id_amplua = amplua;
                    }
                    if (NomerTxt.Text != "")
                    {
                        data.igrovoi_nomer = Convert.ToInt16(NomerTxt.Text);
                    }
                    if (LoginTxt.Text != "")
                    {
                        data.login = LoginTxt.Text;
                    }
                    if (ParolTxt.Text != "")
                    {
                        data.parol = ParolTxt.Text;
                    }

                    db.SaveChanges();

                    var Join = (from a in db.batspolzovatel
                                join b in db.batsamplua
                                on a.id_amplua equals b.id_amplua
                                select new { a.familia, a.ima, a.otchestvo, a.data_rojdenia, b.nazvanie, a.igrovoi_nomer, a.id_igroka, a.login, a.parol, a.id_roli });
                    table.ItemsSource = Join.Where(w => w.id_roli == 1).ToList();

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
                    var data = db.batspolzovatel.Where(w => w.id_igroka == idtxt).FirstOrDefault();
                    db.batspolzovatel.Remove(data);
                    db.SaveChanges();

                    var Join = (from a in db.batspolzovatel
                                join b in db.batsamplua
                                on a.id_amplua equals b.id_amplua
                                select new { a.familia, a.ima, a.otchestvo, a.data_rojdenia, b.nazvanie, a.igrovoi_nomer, a.id_igroka, a.login, a.parol, a.id_roli });
                    table.ItemsSource = Join.Where(w => w.id_roli == 1).ToList();



                    var idtext = db.batspolzovatel.Where(w => w.id_roli == 1).Select(w => w.id_igroka).ToList();
                    idTxt.ItemsSource = idtext;

                    MessageBox.Show("Запись удалена!", "Успех");
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
            var Join = (from a in db.batspolzovatel
                        join b in db.batsamplua
                        on a.id_amplua equals b.id_amplua
                        select new { a.familia, a.ima, a.otchestvo, a.data_rojdenia, b.nazvanie, a.igrovoi_nomer, a.id_igroka, a.login, a.parol, a.id_roli });

            if (sort == 0)
            {
                table.ItemsSource = Join.Where(w => w.id_roli == 1).OrderByDescending(i => i.familia).ToList();
                sort = 1;
            }
            else
            {
                table.ItemsSource = Join.Where(w => w.id_roli == 1).OrderBy(a => a.familia).ToList();
                sort = 0;
            }
        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Join = (from a in db.batspolzovatel
                        join b in db.batsamplua
                        on a.id_amplua equals b.id_amplua
                        select new { a.familia, a.ima, a.otchestvo, a.data_rojdenia, b.nazvanie, a.igrovoi_nomer, a.id_igroka, a.login, a.parol, a.id_roli });

            table.ItemsSource = Join.Where(
                  w => w.id_roli == 1 && (w.familia.ToLower().Contains(Poisk.Text.ToLower())
               || w.ima.ToLower().ToString().Contains(Poisk.Text.ToLower())
               || w.otchestvo.ToLower().ToString().Contains(Poisk.Text.ToLower())
               || w.igrovoi_nomer.ToString().Contains(Poisk.Text.ToLower())
               || w.nazvanie.ToLower().Contains(Poisk.Text.ToLower()))
               ).ToList();

            if (Poisk.Text == "")
            {
                table.ItemsSource = Join.Where(w => w.id_roli == 1).ToList();
            }
        }

        private void Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[а-яА-Я]"))
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

        private void Txt2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z0-9!.*:&;,]"))
            {
                e.Handled = true;
            }
        }

        private void NomerTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[0-9]"))
            {
                e.Handled = true;
            }
        }

        private void Obnov_Click(object sender, RoutedEventArgs e)
        {
            var Join = (from a in db.batspolzovatel
                        join b in db.batsamplua
                        on a.id_amplua equals b.id_amplua
                        select new { a.familia, a.ima, a.otchestvo, a.data_rojdenia, b.nazvanie, a.igrovoi_nomer, a.id_igroka, a.login, a.parol, a.id_roli });
            table.ItemsSource = Join.Where(w => w.id_roli == 1).ToList();


            var idtext = db.batspolzovatel.Where(w => w.id_roli == 1).Select(w => w.id_igroka).ToList();
            idTxt.ItemsSource = idtext;

            var amplua = db.batsamplua.Where(w => w.nazvanie != "Нет").Select(w => w.nazvanie).ToList();
            AmpluaTxt.ItemsSource = amplua;

            Poisk.Text = "";
        }
    }
}