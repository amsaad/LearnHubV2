using System.ComponentModel.DataAnnotations;

namespace LearnHub.Entities
{
    public class HubCoursesTitles:BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public TitleType TitleType { get; set; }
        public string SrcLink { get; set; }
        public string ThumbSrc { get; set; }
        public string Duration { get; set; }
        public virtual HubCoursesHeadTitles HeadTitle { get; set; }
    }
}