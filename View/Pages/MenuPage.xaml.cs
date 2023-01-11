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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void ProzBtn_Click(object sender, RoutedEventArgs e)
        {
            Helpers.ClassFrame.FrameList.Navigate(new ListProzPage());
        }

        private void MaterialBtn_Click(object sender, RoutedEventArgs e)
        {
            Helpers.ClassFrame.FrameList.Navigate(new DobPage());
        }

        private void SotrudnikUchetBtn_Click(object sender, RoutedEventArgs e)
        {
            Helpers.ClassFrame.FrameList.Navigate(new OtchetSotrudPage());
        }

        private void OtchetBtn_Click(object sender, RoutedEventArgs e)
        {
            Helpers.ClassFrame.FrameList.Navigate(new OtcetPeriod());
        }
    }
}
