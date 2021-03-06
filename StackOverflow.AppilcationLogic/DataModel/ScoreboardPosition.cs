﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.AppilcationLogic.DataModel
{
    public class ScoreboardPosition
    {   //we will configure a one-to-one relationship with the user entity
        public int ScoreboardPositionId { get; set; }
        public int ScoreboardPositionNumber { get; set; }
        public int ScoreboardPositionScore { get; set; }
        //Writing foreign key for user
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
