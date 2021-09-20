namespace AdmissionAPI.v1._0.Models
{
    public class Answer : BaseEntity
    {
        public string Content { get; set; }

        public Question Question { get; set; }
    }
}
