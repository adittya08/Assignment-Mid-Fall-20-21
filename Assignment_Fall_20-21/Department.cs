using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Fall_20_21
{
    class Department
    {
        Course[] course = new Course[100];
        private int countCourse = 0;
        private string departmentName { set; get; }
        public int totalCourses { get; set; }

        public void showInfo()
        {
            Console.WriteLine(departmentName);
        }
        public void addCourse(Course course)
        {
            this.course[countCourse++] = course;
        }

        public Department()
        {
            course = new Course[100];
            Console.WriteLine("Nothing to show. ");
        }
        public Department(string DepartmentName)
        {
            course = new Course[100];
            departmentName = DepartmentName;
        }



    }
}
