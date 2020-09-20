namespace LearnHub.Entities
{
    public class UserCourses : BaseEntity
    {
        public HubCourses Course { get; set; }
        public EnrollmentState EnrollmentState { get; set; }
        //public LKPath Path { get; set; }
    }
}