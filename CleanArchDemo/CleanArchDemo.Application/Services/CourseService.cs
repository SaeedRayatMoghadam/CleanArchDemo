using CleanArchDemo.Application.Interfaces;
using CleanArchDemo.Application.ViewModels;
using System.Collections.Generic;
using CleanArchDemo.Domain.Interfaces;

namespace CleanArchDemo.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
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