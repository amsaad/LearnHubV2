namespace LearnHub.Entities
{
    public class CourseRequest:BaseEntity
    {
        public int User { get; set; }
        public int CourseID { get; set; }
        public string CourseName  { get; set; }
    }
}