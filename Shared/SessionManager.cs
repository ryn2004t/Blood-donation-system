using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class SessionManager
    {
        public static int LoggedInUserId { get; set; }
        public static string LoggedInUsername { get; set; }
        public static string LoggedInRole { get; set; }
    }
}
