using CleanArchDemo.Domain.Models;
using System.Collections;
using System.Collections.Generic;

namespace CleanArchDemo.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}