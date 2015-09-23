using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jabberwock
{
    public class ViewModel
    {
        public int SelectedProfileIndex { get; set; }
        private ObservableCollection<Profile> profiles = new ObservableCollection<Profile>();
        public ObservableCollection<Profile> Profiles { get { return profiles; } }

        public Profile SelectedProfile { get { return profiles[SelectedProfileIndex]; } }
    }
}
