using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Fall_20_21
{
    class Course
    {
        Section[] section= new Section[100];
        private int countSection = 0;
        public int TotalSection { get; set; }
        public string courseName { get; set; }
        public string courseId { get; set; }
        public int totalTimeOfTeaching { get; set; }

        public void addSection(Section section)

        {
            this.section[countSection++] = section;
        }

        public Course()
        {
            Console.WriteLine("Empty Course Constructor.");
            section = new Section[25];
        }
        public Course(string CourseName, string CourseId, double TotalTimeOfTeaching)
        {
            CourseName = courseName;
            CourseId = courseId;
            TotalTimeOfTeaching = totalTimeOfTeaching;
            
        }



        public void showSectionAndFaculty()
        {
            for (int i = 0; i < countSection; i++)
            {
                section[i].showDetails();
            }
        }

    }
}
