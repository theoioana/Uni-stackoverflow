using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.AppilcationLogic.DataModel
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        //many-to-many Tag-Question
        public ICollection<TagQuestion> TagQuestions { get; set; }
    }
}
