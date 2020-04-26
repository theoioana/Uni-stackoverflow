using StackOverflow.AppilcationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow.AppilcationLogic.Abstractions
{
    interface IUserAchievement
    {
        UserAchievement GetUserAchievementByAchievementId(Guid tagId);
        UserAchievement GetUserAchievementByUserId(Guid userId);
    }
}

