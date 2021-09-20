using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionAPI.v1._0.Models
{
    public abstract class BaseStatus : BaseEntity
    {
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
