using System;
using System.Collections.Generic;

namespace RentKendaraan1.Models
{
    public partial class JenisKendaraan
    {
        public JenisKendaraan()
        {
            Kendaraan = new HashSet<Kendaraan>();
        }

        public int IdJenisKendaraan { get; set; }
        public string NamaJenisKendaraan { get; set; }

        public virtual ICollection<Kendaraan> Kendaraan { get; set; }
    }
}
