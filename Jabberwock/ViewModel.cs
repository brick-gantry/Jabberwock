using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jabberwock
{
    public class ViewModel
    {
        public ViewModel()
        {
            if (!doneInit)
            {
                profiles.CollectionChanged += (s, e) => SaveProfiles();
                doneInit = true;
            }
        }

        private static bool doneInit = false;

        public int SelectedProfileIndex { get; set; }
        private static ObservableCollection<Profile> profiles = new ObservableCollection<Profile>();
        public ObservableCollection<Profile> Profiles { get { return profiles; } }

        public Profile SelectedProfile { get { return profiles[SelectedProfileIndex]; } }

        static XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Profile>));


        public static void LoadProfiles()
        {

        }

        public static void SaveProfiles()
        {
            
        }
    }
}
