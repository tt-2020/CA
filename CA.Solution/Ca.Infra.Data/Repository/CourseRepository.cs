﻿using Ca.Infra.Data.Context;
using CA.Domain.Interfaces;
using CA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ca.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _context;

        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
