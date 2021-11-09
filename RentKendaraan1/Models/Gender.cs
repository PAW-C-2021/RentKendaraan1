using System;
using System.Collections.Generic;

namespace RentKendaraan1.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customer = new HashSet<Customer>();
        }

        public int IdGender { get; set; }
        public string NamaGender { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
