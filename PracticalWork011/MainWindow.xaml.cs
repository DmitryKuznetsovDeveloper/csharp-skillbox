using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PracticalWork011
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string _passwordConsultant = "123";
        private readonly string _passwordManager = "12345";

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedState = ComboBoxAccount.SelectedIndex;
            if (selectedState == 0 &&  TextBlockPassword.Password.ToString() == _passwordConsultant)
            {
                new ConsultantWindow().ShowDialog();
            }
            else if (selectedState == 1 && TextBlockPassword.Password.ToString() == _passwordManager)
            {
                new ManagerWindow().ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите категорию и введите пароль.","Предупреждение", MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }


    }
}
