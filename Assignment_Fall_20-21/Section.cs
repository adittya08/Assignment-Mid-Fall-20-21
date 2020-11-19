using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Fall_20_21
{
    class Section
    {
        public string section { get; set; }
        public Faculty facultyName;
        public Course course;

        public Section()
        {
            Console.WriteLine("Empty section. Nothing to show.");
        }

        public void addTeacher(Faculty facultyName)
        {
            if (facultyName.totalTimeOfTeaching<21)
            {
                this.facultyName = facultyName;
            }
            else
            {
                Console.WriteLine("Can not add another course due to overtiming. ");
            }

        }

        public Section(string section)
        {
            this.section = section;
        }

        public Section(string section, Faculty FacultyName, Course course)
        {
            section = section;
            this.facultyName = facultyName;
            this.course = course;
        }


        public void showDetails()
        {
            Console.WriteLine("Name of the section is: " + section);
            facultyName.showFacultyInfo();
        }
    }

}
