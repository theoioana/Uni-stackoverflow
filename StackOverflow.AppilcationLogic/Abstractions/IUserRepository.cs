using StackOverflow.AppilcationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow.AppilcationLogic.Abstractions
{
    interface IUserRepository
    {
        User GetUserByScoreboarPositionId(Guid scoreboarPosition);
        User GetUserByQuestionId(Guid questionId);
        User GetUserByUserAchievementId(Guid userAchievementId);

    }
}
