using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    internal class Presensi
    {
        public int IdPresensi { get; set; }
        public DateTime Tanggal { get; set; }
        public string Nim { get; set; }
        public string KodeMk { get; set; }
        public int Pertemuan { get; set; }
        public string StatusHadir { get; set; }
        public int Semester { get; set; }
    }
}