﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechContinuousRecognition.Models
{

    public class GrammarName
    {
        public GrammarName()
        {
            GrammarItems = new HashSet<GrammarItem>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string NameOfGrammar { get; set; } = null!;
        public ICollection<GrammarItem> GrammarItems { get; }
    }
}
