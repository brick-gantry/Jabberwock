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

namespace Jabberwock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ViewModel.LoadProfiles();
            InitializeComponent();
        }

        ViewModel vm { get { return DataContext as ViewModel; } }

        private void bSend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miAdd_Click(object sender, RoutedEventArgs e)
        {
            var window = new CreateProfileWindow();
            window.ShowDialog();
            if(window.CreateClicked)
            {
                vm.Profiles.Add(window.DataContext as Profile);
            }
        }

        private void miEdit_Click(object sender, RoutedEventArgs e)
        {
            var window = new EditProfileWindow();
            window.ShowDialog();
        }
    }
}
