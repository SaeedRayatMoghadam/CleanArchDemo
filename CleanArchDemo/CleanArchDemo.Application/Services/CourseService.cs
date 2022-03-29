using CleanArchDemo.Application.Interfaces;
using CleanArchDemo.Application.ViewModels;
using System.Collections.Generic;
using CleanArchDemo.Domain.Commands;
using CleanArchDemo.Domain.Core.Bus;
using CleanArchDemo.Domain.Interfaces;

namespace CleanArchDemo.Application.Services
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

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description,
                courseViewModel.ImageUrl);
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