﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bugTracker.Models.ViewModels
{
    public class ProjectsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfMembers { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }       
    }
}