using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jabberwock
{
    public class Profile
    {
        public string Username { get; set; }
        public string IconPath { get; set; }
        public override string ToString()
        {
            return Username;
        }
    }
}
