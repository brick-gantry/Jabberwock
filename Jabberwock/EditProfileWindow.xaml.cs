using System.Windows;

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
