using PracticalWork011.Interface;
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
using static System.Net.Mime.MediaTypeNames;

namespace PracticalWork011
{
    /// <summary>
    /// Логика взаимодействия для ConsultantWindow.xaml
    /// </summary>
    public partial class ConsultantWindow : Window
    {
        private CustomerData customerData;

        public ConsultantWindow()
        {
            InitializeComponent();
            customerData = new CustomerData();
            FillList();
        }


        private void FillList() => ListClients.ItemsSource = customerData.ListNotes;
       

        private void ButtonUpdatePhone_Click(object sender, RoutedEventArgs e)
        {
            long id = Convert.ToInt64(InfoID.Content);
            INote temp = customerData.ListNotes.FirstOrDefault(x => x.Id == id);
            temp.ChangeInfo = "Консультант";
            temp.DateTimeEntryWasAdded = DateTime.Now;
            customerData.UpdateFile();
            ListClients.Items.Refresh();
        }
    }
}
