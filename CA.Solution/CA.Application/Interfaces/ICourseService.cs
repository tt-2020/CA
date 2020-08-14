using CA.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses(); 
        void Create(CourseViewModel course);
    }
}
