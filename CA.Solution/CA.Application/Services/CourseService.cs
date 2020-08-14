using AutoMapper;
using AutoMapper.QueryableExtensions;
using CA.Application.Interfaces;
using CA.Application.ViewModels;
using CA.Domain.Commands;
using CA.Domain.Core.Bus;
using CA.Domain.Interfaces;
using CA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CourseViewModel course)
        {
            //CreateCourseCommand createCourseCommand = new CreateCourseCommand(course.Name, course.Description, course.ImageUrl);

            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(course));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            //return new CourseViewModel()
            //{
            //    Courses = _courseRepository.GetCourses()
            //};

            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
