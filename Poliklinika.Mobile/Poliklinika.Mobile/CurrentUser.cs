using Poliklinika.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poliklinika.Mobile
{
    class CurrentUser
    {
        public static User User { get; set; }
        public static string JWT { get; set; }
    }
}
