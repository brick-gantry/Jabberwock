using System.Collections.ObjectModel;
using System.Linq;

namespace Jabberwock
{
    public class ViewModel
    {
        public ObservableCollection<Profile> Profiles {
            get { return new ObservableCollection<Profile>(Model.Instance.profiles.ToList()); } }
        public int SelectedProfileIndex { get; set; }
        public Profile SelectedProfile { get { return Profiles[SelectedProfileIndex]; } }

        public ObservableCollection<ChannelOrDM> Channels {
            get { return new ObservableCollection<ChannelOrDM>(Model.Instance.channels); } }
        public int SelectedChannelIndex { get; set; }
        public ChannelOrDM SelectedChannel {  get { return Channels[SelectedChannelIndex]; } }
    }
}
