﻿using ForekBase.Domain.Entities.Common;
using ForekBase.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForekBase.Domain.Entities
{
    public class Question : BaseEntityModel
    {
        public Guid QuestionId { get; set; }

        public string QuestionText { get; set; }

        public QuestionType Type { get; set; }

        public Guid SurveyId { get; set; }

        public Survey Survey { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
