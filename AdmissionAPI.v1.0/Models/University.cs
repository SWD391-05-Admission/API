using AdmissionAPI.v1._0.Models;
using System;

namespace AdmissionAPI.Models
{
    public class University : BaseEntity
    {
        //public int Id { get; set; }
        public string UniversityName { get; set; }

        public UniStatus Status { get; set; }
    }
}
