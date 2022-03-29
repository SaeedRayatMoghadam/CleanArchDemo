using System.Collections;
using System.Collections.Generic;
using CleanArchDemo.Domain.Models;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}