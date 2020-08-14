using CA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();
        void Add(Course course);
    }
}
