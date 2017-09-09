using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PengelolaanPegawai.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string password { get; set; }
        public bool IsRemember { get; set; }
    }
}