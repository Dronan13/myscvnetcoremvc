﻿using System;
using System.Collections.Generic;

namespace apiCurriculum.Models
{
    public partial class Articles
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Journal { get; set; }
        public string Volume { get; set; }
        public string Issue { get; set; }
        public string Pages { get; set; }
        public string Year { get; set; }
        public string City { get; set; }
        public string Publisher { get; set; }
        public string Issn { get; set; }
        public string Doi { get; set; }
        public string Abstract { get; set; }
        public string Keywords { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
