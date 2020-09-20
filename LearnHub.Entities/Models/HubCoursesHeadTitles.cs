using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearnHub.Entities
{
    public class HubCoursesHeadTitles:BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string ThumbSrc { get; set; }
        public string TotalDuration { get; set; }
        public virtual HubCourses Course { get; set; }
        public IEnumerable<HubCoursesTitles> Titles { get; set; }
    }
}