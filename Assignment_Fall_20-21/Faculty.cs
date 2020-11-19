using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Fall_20_21
{
    class Faculty
    {
        private string facultyName;
        private string facultyId;
        public double totalTimeOfTeaching;

        Section[] section = new Section[100];
        private int countSection = 0;

        public String FacultyName
        {
            get { return facultyName; }
            set { facultyName = value; }
        }

        public String FacultyId
        {
            get { return facultyId; }
            set { facultyId = value; }
        }

        public double TotalTimeOfTeaching
        {
            get { return totalTimeOfTeaching; }
            set { totalTimeOfTeaching = value; }
        }

        public Faculty()
        {
            Console.WriteLine("Nothing to show.");
            section = new Section[100];
        }

        public Faculty(string facultyName, string facultyId, double TotalTimeOfTeaching)
        {
            FacultyName = facultyName;
            FacultyId = facultyId;
            TotalTimeOfTeaching = 0;
        }

        public void addSection(Section section)
        {
            this.section[countSection] = section;
            countSection++;
            TotalTimeOfTeaching =TotalTimeOfTeaching + 1.5;
        }

        public void showFacultyInfo()
        {
            Console.WriteLine("The name of the faculty is :" + FacultyName);
            Console.WriteLine("Faculty's ID is :" + FacultyId);
            if (TotalTimeOfTeaching <= 21)
            {
                Console.WriteLine("Faculties working hour in week :" + TotalTimeOfTeaching);
            }
            else
                Console.WriteLine("can not work more than 21 hour in a week");

        }

        public void showSectionDetails()
        {
            for (int i = 0; i < countSection; i++)
            {
                section[i].showDetails();
            }
        }

    }
}
