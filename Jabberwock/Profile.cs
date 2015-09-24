namespace Jabberwock
{
    public class Profile
    {
        public string Username { get; set; }
        public string IconPath { get; set; }
        public string Tag { get; set; }
        public override string ToString()
        {
            return Username;
        }
    }
}
