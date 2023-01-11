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
    /// Логика взаимодействия для OtcetPeriod.xaml
    /// </summary>
    public partial class OtcetPeriod : Page
    {
        public OtcetPeriod()
        {
            InitializeComponent();
        }

        private void OtchetBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(Pik1.Text))
                mes += "Выберите начало периода\n";
            if (string.IsNullOrWhiteSpace(Pik2.Text))
                mes += "Выберите конец периода\n";
            if(mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            var a = (DateTime)Pik1.SelectedDate;
            var b = (DateTime)Pik2.SelectedDate;

            var qwerty = AppData.BS.salonEntities.View_1.Where(x => x.Datelspol >= a && x.Datelspol <= b)
                .GroupBy(y => y.Name).Select(q => new { Сотрудник = q.Key, Сумма = q.Sum(s => s.Summa) })
                .OrderBy(i => i.Сотрудник);

            Dtg.ItemsSource = qwerty.ToList();
        }
    }
}
