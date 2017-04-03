﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sauna.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string  FaceBookUrl  { get; set; }
        public string TwitterUrl { get; set; }
        public string GooglePlusUrl { get; set; } 

    }
}