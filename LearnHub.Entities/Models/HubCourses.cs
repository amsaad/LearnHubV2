using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearnHub.Entities
{
    public class HubCourses : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImgID { get; set; }

        public int LikesCounter { get; set; }
        public int RestrictionCode { get; set; } = 0;
        public decimal Price { get; set; } = 0.0m;
        public string ExternalLink { get; set; }
        [Url]
        public string RepositoryLink { get; set; }
        public virtual LKInstructor Instructor { get; set; }
        public IEnumerable<HubCoursesHeadTitles> Titles { get; set; }
    }
}