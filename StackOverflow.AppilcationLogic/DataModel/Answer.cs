using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.AppilcationLogic.DataModel
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerContent { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public DateTime DatePosted { get; set; }
        //establishing one-to-many Answer-Question
        public Question Question { get; set; }
    }
}
