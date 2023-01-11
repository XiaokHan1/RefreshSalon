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
    /// Логика взаимодействия для OtchetSotrudPage.xaml
    /// </summary>
    public partial class OtchetSotrudPage : Page
    {
        public OtchetSotrudPage()
        {
            InitializeComponent();
            SotrCmb.SelectedValuePath = "Id";
            SotrCmb.DisplayMemberPath = "Name";
            SotrCmb.ItemsSource = AppData.BS.salonEntities.Sotrudnik.ToList();
            SotrList.ItemsSource = AppData.BS.salonEntities.Uchet.ToList();
        }

        private void SotrCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectSotr = Convert.ToInt32(SotrCmb.SelectedValue);
            SotrList.ItemsSource = AppData.BS.salonEntities.Uchet.Where(x => x.IdSotrudnik == SelectSotr).ToList();

            var CountZap = AppData.BS.salonEntities.Uchet.Where(x => x.IdSotrudnik == SelectSotr).Count();
            ZapisTb.Text = Convert.ToString(CountZap);

            var SumSotr = AppData.BS.salonEntities.Uchet.Where(x => x.IdSotrudnik == SelectSotr).Select(i => i.Summa).Sum();
        }
    }
}
