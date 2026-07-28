using Assignment15_28july.Controllers.Models;

namespace Assignment15_28july.Services
{
    public interface ICourseService
    {
      
            List<Course> GetAll();

            Course? GetById(int id);

            Course AddCourse(Course course);

            Course? UpdateCourse(int id, Course course);

            bool DeleteCourse(int id);
        }

    }

