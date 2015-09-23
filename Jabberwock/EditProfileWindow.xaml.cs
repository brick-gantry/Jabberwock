using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Jabberwock
{
    /// <summary>
    /// Interaction logic for DeleteProfileWindow.xaml
    /// </summary>
    public partial class EditProfileWindow : Window
    {
        public EditProfileWindow()
        {
            InitializeComponent();
        }

        ViewModel vm { get { return DataContext as ViewModel; } }

        private void bEdit_Click(object sender, RoutedEventArgs e)
        {
            CreateProfileWindow window = new CreateProfileWindow(vm.SelectedProfile);
            window.ShowDialog();
        }

        private void bDelete_Click(object sender, RoutedEventArgs e)
        {
            vm.Profiles.Remove(vm.SelectedProfile);
        }
    }
}
