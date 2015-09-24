using System.Windows;

namespace Jabberwock
{
    /// <summary>
    /// Interaction logic for CreateChannelWindow.xaml
    /// </summary>
    public partial class CreateChannelWindow : Window
    {
        public CreateChannelWindow()
        {
            InitializeComponent();
        }

        public bool CreateClicked = false;

        ChannelOrDM channel { get { return DataContext as ChannelOrDM; } }

        private void bCreate_Click(object sender, RoutedEventArgs e)
        {
            if (channel.Name.Length > 0 && cbType.SelectedIndex != -1)
            {
                CreateClicked = true;
                Close();
            }
        }
    }
}
