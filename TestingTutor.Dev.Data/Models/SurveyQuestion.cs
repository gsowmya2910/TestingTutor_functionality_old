﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestingTutor.Dev.Data.Models
{
    public abstract class SurveyQuestion : IdentityModel<int>
    {
        [Required, DisplayName("Question's Requirement")]
        public bool Required { get; set; }

        [Required, DisplayName("Question Type")]
        public SurveyQuestionTypes Type { get; set; }

        [Required]
        public int CourseClassId { get; set; }
        public virtual CourseClass CourseClass { get; set; }

        public enum SurveyQuestionTypes
        {
            Qualitative,
            Rate,
        }

        public string TypeValue()
        {
            switch (Type)
            {
                case SurveyQuestionTypes.Qualitative:
                    return "Qualitative";
                case SurveyQuestionTypes.Rate:
                    return "Rate";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
