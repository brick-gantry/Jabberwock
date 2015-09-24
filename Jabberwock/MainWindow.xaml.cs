using System.Windows;

namespace Jabberwock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ViewModel vm { get { return DataContext as ViewModel; } }

        private void bSend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miAddProfile_Click(object sender, RoutedEventArgs e)
        {
            var window = new CreateProfileWindow();
            window.ShowDialog();
            if(window.CreateClicked)
            {
                vm.Profiles.Add(window.DataContext as Profile);
            }
        }

        private void miEditProfile_Click(object sender, RoutedEventArgs e)
        {
            var window = new EditProfileWindow();
            window.ShowDialog();
        }

        private void miAddChannel_Click(object sender, RoutedEventArgs e)
        {
            var window = new CreateChannelWindow();
            window.ShowDialog();
            if(window.CreateClicked)
            {
                vm.Channels.Add(window.DataContext as ChannelOrDM);
            }
        }

        private void miEditChannel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
