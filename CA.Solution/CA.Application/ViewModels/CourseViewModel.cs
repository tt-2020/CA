﻿using CA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Application.ViewModels
{
    public class CourseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
