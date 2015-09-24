using System.Data.Entity;

namespace Jabberwock
{
    public class Model : DbContext
    {
        public DbSet<Profile> profiles { get; set; }
        public DbSet<ChannelOrDM> channels { get; set; }

        public static Model Instance = new Model();

        private Model()
            : base()
        {

        }
    }
}
