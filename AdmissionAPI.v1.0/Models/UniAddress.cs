using AdmissionAPI.v1._0.Models;

namespace AdmissionAPI.Models
{
    public class UniAddress : BaseEntity
    {
        public string Address { get; set; }

        public District District { get; set; }
        public University University { get; set; }
    }
}
