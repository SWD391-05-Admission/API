namespace AdmissionAPI.Models
{
    public class University
    {
        public int Id { get; set; }
        public string UniversityName { get; set; }

        public UniStatus Status { get; set; }
    }
}
