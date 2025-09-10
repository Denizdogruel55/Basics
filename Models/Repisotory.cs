using System.Security.Cryptography.X509Certificates;

namespace Basics.Models;

public class Repisotory
{
    public static List<Course> _course = new();
    static Repisotory()
    {

        _course = new List<Course>() {
            new Course() { Id = 1, Title = "Aspnet core", Description = "Guzel kurs", Images = "1.webp" },
            new Course() { Id = 2, Title = "php", Description = "Guzel kurs", Images = "2.png" },
            new Course() { Id = 3, Title = "Django", Description = "Guzel kurs", Images = "4.jpg" }
        };
    }

    public static List<Course> Courses
    {
        get
        {
            return _course;
        }

    }
    public static Course? GetById(int id)
    {
        return _course.FirstOrDefault(x=>x.Id==id);
    }
} 



