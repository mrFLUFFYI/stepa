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
    /// Логика взаимодействия для Kabinet.xaml
    /// </summary>
    public partial class Kabinet : Window
    {
        user154_dbEntities db = new user154_dbEntities();
        public Kabinet()
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
                        join b in db.batslizenzia
                        on a.id_licenzii equals b.id_licenzii
                        select new { a.familia, a.ima, a.otchestvo, a.data_rojdenia, b.kategoria, a.id_igroka, a.login, a.parol });

            table.ItemsSource = Join.Where(w => w.id_igroka == Class1.idclass).ToList();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void izmenit_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                if (LoginTxt.Text == "" && ParolTxt.Text == "")
                {
                    MessageBox.Show("Заполните хотя бы одно поле!", "Ошибка");
                }
                else
                {
                    var data = db.batspolzovatel.Where(w => w.id_igroka == Class1.idclass).FirstOrDefault();

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
                                join b in db.batslizenzia
                                on a.id_licenzii equals b.id_licenzii
                                select new { a.familia, a.ima, a.otchestvo, a.data_rojdenia, b.kategoria, a.id_igroka, a.login, a.parol });

                    table.ItemsSource = Join.Where(w => w.id_igroka == Class1.idclass).ToList();

                    MessageBox.Show("Запись изменена!", "Успех");
                }
        //}
        //    catch
        //    {
        //        MessageBox.Show("Произошла ошибка на сервере!", "Ошибка");
        //    }
        }

        private void Txt2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z0-9!.*:&;,]"))
            {
                e.Handled = true;
            }
        }
    }
}