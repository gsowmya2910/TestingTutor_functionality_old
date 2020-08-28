﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

namespace TestingTutor.Dev.Data.Models
{
    public class Survey : IdentityModel<string>
    {
        [Required, DisplayName("Posted Time")]
        public DateTime PostedTime { get; set; } = DateTime.Now;
        [Required]
        public string StudentId { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<Snapshot> Snapshots { get; set; } = new List<Snapshot>();
        [Required, DisplayName("Completed")]
        public bool IsCompleted { get; set; } = false;
        [DisplayName("Survey Responses")]
        public virtual ICollection<SurveyResponse> SurveyResponses { get; set; } = new List<SurveyResponse>();
    }
}
