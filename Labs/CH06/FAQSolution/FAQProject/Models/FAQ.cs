namespace FAQProject.Models
{
    public class FAQ
    {
        public int FAQId { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer {  get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty; // foreign key
        public Category Category { get; set; } = null!; // nav property
        public string TopicId {  get; set; } = string.Empty; // foreign key
        public Topic Topic { get; set; } = null!; // nav property
    }
}
