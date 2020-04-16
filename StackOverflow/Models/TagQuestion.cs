using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
    public class TagQuestion
    {
        //class to create many-to-many relation Tag-Question
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
