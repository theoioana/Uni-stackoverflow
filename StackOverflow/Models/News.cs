using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
    public class News
    {
        public int NewsId { get; set; }
        public string NewsContent { get; set; }
        public string NewsTitle { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
