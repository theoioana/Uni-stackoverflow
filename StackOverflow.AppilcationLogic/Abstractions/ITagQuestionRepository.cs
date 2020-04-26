using StackOverflow.AppilcationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow.AppilcationLogic.Abstractions
{
    interface ITagQuestionRepository
    {
        TagQuestion GetTagQuestionByTagId(Guid tagId);
        TagQuestion GetTagQuestionByUserId(Guid userId);
    }
}

