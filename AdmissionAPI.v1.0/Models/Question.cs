using AdmissionAPI.Models;

namespace AdmissionAPI.v1._0.Models
{
    public class Question : BaseEntity
    {
        public string Content { get; set; }

        public University University { get; set; }
    }
}
