using StackOverflow.AppilcationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow.AppilcationLogic.Abstractions
{
    interface IScoreboardPosition
    {
        ScoreboardPosition GetScoreboardPositionByUserId(Guid userId);
    }
}
