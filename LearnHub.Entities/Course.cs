using System;
using System.Collections;
using System.Collections.Generic;

namespace LearnHub.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Description { get; set; }
        public string ImgID { get; set; }
        public int LikesCounter { get; set; }
        public int RestrictionCode { get; set; } = 0;
        public decimal Price { get; set; } = 0;
        public string ExternalLink { get; set; }
        public string RepositoryLink { get; set; }
        public LKInstructor Instructor { get; set; }
        public IEnumerable<CourseHeadTitle> Titles { get; set; }
    }
}