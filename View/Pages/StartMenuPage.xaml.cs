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
    /// Логика взаимодействия для StartMenuPage.xaml
    /// </summary>
    public partial class StartMenuPage : Page
    {
        public StartMenuPage()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Helpers.ClassFrame.FrameMenu.Navigate(new MenuPage());
        }
    }
}
