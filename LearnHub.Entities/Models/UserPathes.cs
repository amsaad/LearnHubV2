namespace LearnHub.Entities
{
    public class UserPathes : BaseEntity
    {
        public LKPath Course { get; set; }
        public EnrollmentState EnrollmentState { get; set; }
    }
}