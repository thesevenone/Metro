using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PengelolaanPegawai.Models
{
    public class PegawaiViewModel
    {
        public string NIP { set; get; }
        public string NamaDivisi { set; get; }
        public string Nama { set; get; }
        public string Alamat { set; get; }
        public DateTime TanggalLahir { set; get; }
    }
}