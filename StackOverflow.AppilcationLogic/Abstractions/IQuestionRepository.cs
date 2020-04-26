using StackOverflow.AppilcationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow.AppilcationLogic.Abstractions
{
    interface IQuestionRepository
    {
        Question GetQuestionByAnswerId(Guid answerId);
        Question GetQuestionByUserId(Guid userId);
        Question GetAnswerByTagQuestionId(Guid tagQuestionId);
    }
}

