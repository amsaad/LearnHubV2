using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Entities
{
    public class LKInstructor : BaseLK
    {
        public int CoursesCounter { get; set; }
        public string About { get; set; }
        public string ImgID { get; set; }
        public int Rank { get; set; }
    }
}
