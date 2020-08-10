using CA.Application.Interfaces;
using CA.Application.ViewModels;
using CA.Domain.Commands;
using CA.Domain.Core.Bus;
using CA.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel course)
        {
            CreateCourseCommand createCourseCommand = new CreateCourseCommand(course.Name, course.Description, course.ImageUrl);

            _bus.SendCommand(createCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
