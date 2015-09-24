namespace Jabberwock
{
    public class ChannelOrDM
    {
        public enum CoDType { Undefined = -1, Channel, DM}
        public string Name { get; set; }
        public CoDType Type { get; set; }
        public string Tag { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
