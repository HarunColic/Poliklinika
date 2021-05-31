using Poliklinika.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class UpdatePasswordVM
    {
        public string password { get; set; }
        public int UserId { get; set; }
    }
}
