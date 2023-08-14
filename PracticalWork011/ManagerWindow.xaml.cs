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

namespace PracticalWork011
{
    /// <summary>
    /// Логика взаимодействия для ConsultantWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        private CustomerData customerData;

        public ManagerWindow()
        {
            InitializeComponent();
            customerData = new CustomerData();
            ListClients.ItemsSource = customerData.ListNotes;
        }
        private void ButtonUpdatePhone_Click(object sender, RoutedEventArgs e)
        {
            long id = Convert.ToInt64(InfoID.Content);
            INote temp = customerData.ListNotes.FirstOrDefault(x => x.Id == id);
            temp.ChangeInfo = "Менеджер";
            temp.DateTimeEntryWasAdded = DateTime.Now;
            customerData.UpdateFile();
            ListClients.Items.Refresh();
        }

        private void ButtonAddedClient_Click(object sender, RoutedEventArgs e)
        {
            INote newClient = new Note((long)customerData.ListNotes.Count + 1, DateTime.Now, new Client(TextSecondNameAdd.Text, TextNameAdd.Text, TextSurnameAdd.Text,
                TextNewPhoneAdd.Text,TextPassportAdd.Text),"Менеджер");
            customerData.ListNotes.Add(newClient);
            customerData.UpdateFile();
            ListClients.Items.Refresh();

        }

        private void ButtonDeleteClient_Click(object sender, RoutedEventArgs e)
        {
            long id = Convert.ToInt64(InfoID.Content);
            INote temp = customerData.ListNotes.FirstOrDefault(x => x.Id == id);
            customerData.ListNotes.Remove(temp);
            customerData.UpdateFile();
            ListClients.Items.Refresh();
        }
    }
}
