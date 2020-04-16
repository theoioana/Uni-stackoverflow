using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Status { get; set; }
        public string QuestionContent { get; set; }
        public DateTime DatePosted { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        //configuring one-to-many User-Question relationship
        public User User { get; set; }
        
        //many-to-many Question-Tag
        public ICollection<TagQuestion> TagQuestions { get; set; }

        //one-to-many Question-Answer

        public ICollection<Answer> Answers { get; set; }
    }
}
