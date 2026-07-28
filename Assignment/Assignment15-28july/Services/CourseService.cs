using Assignment15_28july.Controllers.Models;
using Assignment15_28july.Services;




namespace Assignment15_28july.Services
{
    public class CourseService : ICourseService
    {
        private static List<Course> courses = new List<Course>()
        {
            new Course
            {
                Id = 1,
                Title = "ASP.NET Core",
                Credits = 4,
                Duration = 45
            },
            new Course
            {
                Id = 2,
                Title = "C#",
                Credits = 3,
                Duration = 30
            }
        };

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course? GetById(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }

        public Course AddCourse(Course course)
        {
            courses.Add(course);
            return course;
        }

        public Course? UpdateCourse(int id, Course course)
        {
            var existingCourse = courses.FirstOrDefault(c => c.Id == id);

            if (existingCourse == null)
            {
                return null;
            }

            existingCourse.Duration = course.Duration;

            return existingCourse;
        }

        public bool DeleteCourse(int id)
        {
            var existingCourse = courses.FirstOrDefault(c => c.Id == id);

            if (existingCourse == null)
            {
                return false;
            }

            courses.Remove(existingCourse);

            return true;
        }
    }
}
