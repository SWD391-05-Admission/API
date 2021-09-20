using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionAPI.v1._0.Models
{
    public abstract class BasePhone : BaseEntity
    {
        public int PhoneNumber { get; set; }
    }
}
