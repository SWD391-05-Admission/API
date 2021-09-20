namespace AdmissionAPI.v1._0.Models
{
    public class CounUniMajor : BaseEntity
    {
        public Counselor Counselor { get; set; }
        public UniMajor UniMajor { get; set; }
    }
}
