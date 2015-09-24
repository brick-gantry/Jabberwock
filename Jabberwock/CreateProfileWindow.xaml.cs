using System.Windows;

namespace Jabberwock
{
    /// <summary>
    /// Interaction logic for CreateProfileWindow.xaml
    /// </summary>
    public partial class CreateProfileWindow : Window
    {
        public bool CreateClicked = false;

        public CreateProfileWindow()
        {
            InitializeComponent();
        }

        public CreateProfileWindow(Profile profile)
        {
            DataContext = profile;
            Title = "Edit Profile";
            bCreate.Content = "Edit";
            InitializeComponent();
        }

        private void bCreate_Click(object sender, RoutedEventArgs e)
        {
            if (CreatedProfile.Username.Length > 0 &&
                CreatedProfile.IconPath.Length > 0)
            {
                CreateClicked = true;
                Close();
            }
        }
    }
}
