namespace LearnHub.Entities
{
    public class UserCourseRequest:BaseEntity
    {
        public int User { get; set; }
        public int CourseID { get; set; }
        public string CourseName  { get; set; }
    }
}