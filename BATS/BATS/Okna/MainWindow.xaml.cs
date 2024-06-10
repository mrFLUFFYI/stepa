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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BATS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        user154_dbEntities db = new user154_dbEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginTxt.Text == "" || ParolTxt.Password.ToString() == "")
                {
                    MessageBox.Show("Проверьте заполненность всех полей!", "Ошибка");
                    return;
                }
                if (db.batspolzovatel.Where(w => w.id_roli == 2).Select(w => w.login + " " + w.parol).Contains(LoginTxt.Text + " " + ParolTxt.Password))
                {
                    MessageBox.Show("Вы авторизовались!", "Успех");
                    Class1.idclass = db.batspolzovatel.Where(w => w.login == LoginTxt.Text && w.parol == ParolTxt.Password && w.id_roli == 2).Select(w => w.id_igroka).FirstOrDefault();
                    Menu a = new Menu();
                    a.Show();
                    this.Close();
                }
                else if (db.batspolzovatel.Where(w => w.id_roli == 1).Select(w => w.login + " " + w.parol).Contains(LoginTxt.Text + " " + ParolTxt.Password))
                {
                    MessageBox.Show("Вы авторизовались!", "Успех");
                    Class1.idclass = db.batspolzovatel.Where(w => w.login == LoginTxt.Text && w.parol == ParolTxt.Password && w.id_roli == 1).Select(w => w.id_igroka).FirstOrDefault();
                    MenuK a = new MenuK();
                    a.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка");
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка на сервере!", "Ошибка");
            }
        }

        private void Vihod_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите выйти из аккаунта?", "Сообщение", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void Txt2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z0-9!.*:&;,]"))
            {
                e.Handled = true;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
