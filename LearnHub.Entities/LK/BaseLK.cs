using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Entities
{
    class BaseLK : BaseEntity
    {
        [Required, StringLength(maximumLength: 250, MinimumLength = 10)]
        public string Name { get; set; }
    }
}
