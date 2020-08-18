namespace LearnHub.Entities
{
    public class UserCourses:BaseEntity
    {
    public int UserID{get;set;}
        public Course Course { get; set; }
        public EnrollmentState EnrollmentState { get; set; }
        public LKPath Path { get; set; }
    }
}