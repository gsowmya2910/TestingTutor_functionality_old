﻿using System.ComponentModel.DataAnnotations;

namespace TestingTutor.Dev.Data.Models
{
    public class ReferenceSolution
    {
        public int Id { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public byte[] FileBytes { get; set; }
    }
}