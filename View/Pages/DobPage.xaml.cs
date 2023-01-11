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
    /// Логика взаимодействия для DobPage.xaml
    /// </summary>
    public partial class DobPage : Page
    {
        public DobPage()
        {
            InitializeComponent();
            Cmb.SelectedValuePath = "Id";
            Cmb.DisplayMemberPath = "Name";
            Cmb.ItemsSource = AppData.BS.salonEntities.Proizvoditel.ToList();
        }

        private void Ahd1Btn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(TovarTb.Text))
                mes += "Введите товар\n";
            if (string.IsNullOrWhiteSpace(Cmb.Text))
                mes += "Выберите производителя\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Models.Material material = new Models.Material()
            {
                Name = TovarTb.Text,
                Proizvoditel = Cmb.SelectedItem as Models.Proizvoditel
            };
            AppData.BS.salonEntities.Material.Add(material);
            AppData.BS.salonEntities.SaveChanges();
            MessageBox.Show("Успешно добавлена");
        }
    }
}
