using CA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
