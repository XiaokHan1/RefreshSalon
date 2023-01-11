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

namespace RefreshSalon.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListProzPage.xaml
    /// </summary>
    public partial class ListProzPage : Page
    {
        public ListProzPage()
        {
            InitializeComponent();
        }

        private void AhdBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(ProzTb.Text))
                mes += "Введите производителя\n";

            if(mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Models.Proizvoditel proizvoditel = new Models.Proizvoditel()
            {
                Name = ProzTb.Text
            };
            AppData.BS.salonEntities.Proizvoditel.Add(proizvoditel);
            AppData.BS.salonEntities.SaveChanges();
            MessageBox.Show("Производитель добавлен");

            ProzTb.Text = "";
        }
    }
}
