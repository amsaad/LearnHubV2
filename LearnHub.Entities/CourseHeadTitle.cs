namespace LearnHub.Entities
{
    public class CourseHeadTitle:BaseEntity
    {
        public string Title { get; set; }
        public string ThumbSrc { get; set; }
        public string TotalDuration { get; set; }
        public Course Course { get; set; }
        public IEnumerable<CourseTitle> Titles { get; set; }
    }
}