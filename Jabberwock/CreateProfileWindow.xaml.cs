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
using System.Windows.Shapes;

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
