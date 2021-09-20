using AdmissionAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionAPI.v1._0.Models
{
    public class UniMajor : BaseEntity
    {
        public University University { get; set; }
        public Major Major { get; set; }
    }
}
