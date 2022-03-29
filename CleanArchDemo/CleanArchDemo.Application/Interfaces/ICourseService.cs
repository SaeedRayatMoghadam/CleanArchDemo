using System.Collections;
using System.Collections.Generic;
using CleanArchDemo.Application.ViewModels;

namespace CleanArchDemo.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
        void Create(CourseViewModel courseViewModel);
    }
}